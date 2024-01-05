using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Gallery;
using Lumina_Hospital.Entities.Testimonial;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin.Gallery;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class GalleryController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GalleryController(LuminaHospitalDbContex context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var images = _context.Galleries.Where(i => !i.IsDelete).ToList();
            return View(images);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(GalleryCreateVM galleryVM)
        {
            Gallery gallery = new();

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }
            if (!galleryVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }
            if (galleryVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }
            gallery.ImagePath = galleryVM.ImagePath.SaveImage("./assets/images/gallery/", _webHostEnvironment);
            _context.Galleries.Add(gallery);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var image = _context.Galleries.FirstOrDefault(i => i.Id == id);
            if (image == null) return NotFound();

            return View(new GalleryEditVM
            {
                ImagePath = image.ImagePath,
            });

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(GalleryEditVM galleryVM)
        {
            var gallery = _context.Galleries.FirstOrDefault(g => g.Id == galleryVM.Id);

            var photo = galleryVM.Photo;

            if (photo != null)
            {
                if (!photo.CheckImage())
                {
                    ModelState.AddModelError("Photo", "Only Photo.");
                }

                if (photo.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photo", "Size is high.");
                }

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/gallery/", gallery.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                gallery.ImagePath = photo.SaveImage("./assets/images/gallery/", _webHostEnvironment);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var image = _context.Galleries
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (image == null) return NotFound();
            image.IsDelete = true;
            image.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Gallery? image = _context.Galleries.FirstOrDefault(s => s.Id == id);
            return image is null ? BadRequest() : View(image);
        }

    }
}
