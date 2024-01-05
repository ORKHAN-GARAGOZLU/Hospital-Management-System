using Lumina_Hospital.DAL;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Controllers
{
    public class AboutController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public AboutController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            AboutVM vm = new()
            {
                Abouts = _context.Abouts.Where(a => !a.IsDelete).ToList(),
                PatientTestimonials = _context.PatientTestimonials.Where(p => !p.IsDelete).ToList(),
            };
            return View(vm);
        }

        public IActionResult Faq()
        {
            return View();
        }
    }
}
