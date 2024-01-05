using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin.AboutPage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class AboutPageController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public AboutPageController(LuminaHospitalDbContex context, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts
                .Where(a => !a.IsDelete)
                .ToList();
            return View(about);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(AboutCreateVM aboutCreateVM)
        {
            About about = _mapper.Map<About>(aboutCreateVM);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }
            if (!aboutCreateVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }
            if (aboutCreateVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }
            about.ImagePath = aboutCreateVM.ImagePath.SaveImage("./assets/images/about/", _webHostEnvironment);
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var existAbout = _context.Abouts.FirstOrDefault(a => a.Id == id);
            if (existAbout == null) return NotFound();
            var aboutVM = _mapper.Map<AboutEditVM>(existAbout);
            return View(aboutVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(AboutEditVM aboutEditVM)
        {
            var about = _context.Abouts.FirstOrDefault(a => a.Id == aboutEditVM.Id);
            if (about == null) return NotFound();
            about.Title = aboutEditVM.Title;
            about.Description = aboutEditVM.Description;

            var photo = aboutEditVM.Photo;

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

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/about/", about.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                about.ImagePath = photo.SaveImage("./assets/images/about/", _webHostEnvironment);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var existAbout = _context.Abouts
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (existAbout == null) return NotFound();
            existAbout.IsDelete = true;
            existAbout.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            About? about = _context.Abouts.FirstOrDefault(s => s.Id == id);
            return about is null ? BadRequest() : View(about);
        }
    }
}
