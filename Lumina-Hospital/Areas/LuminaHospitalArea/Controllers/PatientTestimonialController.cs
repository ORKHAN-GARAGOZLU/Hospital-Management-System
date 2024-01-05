using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Testimonial;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin.Testimonial;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class PatientTestimonialController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public PatientTestimonialController(LuminaHospitalDbContex context, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var patientTestimonial = _context.PatientTestimonials
                .Where(p => !p.IsDelete)
                .ToList();
            return View(patientTestimonial);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(PatientTestimonialCreateVM patientVM)
        {
            PatientTestimonial patient = _mapper.Map<PatientTestimonial>(patientVM);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }
            if (!patientVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }
            if (patientVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }
            patient.ImagePath = patientVM.ImagePath.SaveImage("./assets/images/testimonials/", _webHostEnvironment);
            _context.PatientTestimonials.Add(patient);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var patient = _context.PatientTestimonials.FirstOrDefault(a => a.Id == id);
            if (patient == null) return NotFound();
            var patientVM = _mapper.Map<PatientTestimonialEditVM>(patient);
            return View(patientVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(PatientTestimonialEditVM patientVM)
        {
            var patient = _context.PatientTestimonials.FirstOrDefault(p => p.Id == patientVM.Id);
            if (patient == null) return NotFound();
            patient.Name = patientVM.Name;
            patient.Content = patientVM.Content;
            patient.Position = patientVM.Position;

            var photo = patientVM.Photo;

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

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/testimonials/", patient.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                patient.ImagePath = photo.SaveImage("./assets/images/testimonials/", _webHostEnvironment);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var patient = _context.PatientTestimonials
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (patient == null) return NotFound();
            patient.IsDelete = true;
            patient.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            PatientTestimonial? patient = _context.PatientTestimonials.FirstOrDefault(s => s.Id == id);
            return patient is null ? BadRequest() : View(patient);
        }
    }
}
