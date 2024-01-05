using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Volunteer;
using Lumina_Hospital.ViewModel.Admin.Volunteer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class VolunteerOnboardingController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly IMapper _mapper;

        public VolunteerOnboardingController(LuminaHospitalDbContex contex, IMapper mapper)
        {
            _contex = contex;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var table = _contex.VolunteerOnboardings
                .Where(v => !v.IsDelete)
                .Include(v => v.VolunteerOnboardingPoints)
                .ToList();
            return View(table);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(VolunteerOnboardingCreateVM volunteerVM)
        {

            VolunteerOnboarding onboarding = new()
            {
                Title = volunteerVM.Title,

            };
            

            _contex.VolunteerOnboardings.Add(onboarding);
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult CreateDetail()
        {
            ViewBag.TitleList = new SelectList(_contex.VolunteerOnboardings.ToList(), "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult CreateDetail(VolunteerOnboardingCreateVM vm)
        {
            ViewBag.TitleList = new SelectList(_contex.VolunteerOnboardings.ToList(), "Id", "Title");
            VolunteerOnboardingPoint onboarding = new()
            {
                Detail = vm.Detail,
                VolunteerOnboardingId = vm.TitleId
            };
            _contex.VolunteerOnboardingPoints.Add(onboarding);
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
