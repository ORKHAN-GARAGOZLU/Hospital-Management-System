using Lumina_Hospital.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Controllers
{
    public class GalleryController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public GalleryController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var images = _context.Galleries
                .Where(i => !i.IsDelete)
                .ToList();
            return View(images);
        }
    }
}
