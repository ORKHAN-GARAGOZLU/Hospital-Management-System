using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.ViewModel.Admin;
using Lumina_Hospital.ViewModel.Admin.Subsicribe;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class SubscribeController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public SubscribeController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var subscribe = _context.SubscribeSections.Where(s => !s.IsDelete).FirstOrDefault();
            return View(subscribe);
        }

        public IActionResult Edit(int? id)
        {
            var subscribe = _context.SubscribeSections.FirstOrDefault(a => a.Id == id);
            if (subscribe == null) return NotFound();
            return View(new SubscribeSectionEditVM
            {
                Id = subscribe.Id,
                Title = subscribe.Title,
                ShortDescription = subscribe.ShortDescription,
                LongDescription = subscribe.LongDescription,
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(SubscribeSectionEditVM vm)
        {
            var subscribe = _context.SubscribeSections.FirstOrDefault(a => a.Id == vm.Id);
            if (subscribe == null) return NotFound();

            subscribe.Title = vm.Title;
            subscribe.ShortDescription = vm.ShortDescription;
            subscribe.LongDescription = vm.LongDescription;

            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
