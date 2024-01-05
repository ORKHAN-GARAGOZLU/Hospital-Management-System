using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AboutSection;
using Lumina_Hospital.ViewModel.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class AboutSectionController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IMapper _mapper;

        public AboutSectionController(LuminaHospitalDbContex context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var aboutSection = _context.AboutSections.FirstOrDefault();
            var aboutSectionVM = _mapper.Map<AboutSectionEditVM>(aboutSection);
            return View(aboutSectionVM);
        }

        public IActionResult Edit(int? id)
        {
            var aboutSection = _context.AboutSections.FirstOrDefault(a => a.Id == id);
            if (aboutSection == null) return NotFound();
            var aboutSectionVM = _mapper.Map<AboutSectionEditVM>(aboutSection);
            return View(aboutSectionVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, AboutSectionEditVM aboutSectionEditVM)
        {
            if (id != aboutSectionEditVM.Id) return NotFound();
            var aboutSectionEntity = _mapper.Map<AboutSection>(aboutSectionEditVM);
            _context.AboutSections.Update(aboutSectionEntity);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
