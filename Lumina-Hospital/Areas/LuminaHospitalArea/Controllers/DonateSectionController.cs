using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.DonateSection;
using Lumina_Hospital.ViewModel.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class DonateSectionController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IMapper _mapper;

        public DonateSectionController(LuminaHospitalDbContex context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var donateSection = _context.DonateSections.FirstOrDefault();
            var donateSectionVM = _mapper.Map<DonateSectionEditVM>(donateSection);
            return View(donateSectionVM);
        }

        public IActionResult Edit(int? id)
        {
            var donateSection = _context.DonateSections.FirstOrDefault(d => d.Id == id);
            if (donateSection == null) return NotFound();
            var donateSectionVM = _mapper.Map<DonateSectionEditVM>(donateSection);
            return View(donateSectionVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Edit(int id, DonateSectionEditVM donateSectionEditVM)
        {
            if(id != donateSectionEditVM.Id) return NotFound();
            var donateSectionEntity = _mapper.Map<DonateSection>(donateSectionEditVM);
            _context.DonateSections.Update(donateSectionEntity);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


    }
}
