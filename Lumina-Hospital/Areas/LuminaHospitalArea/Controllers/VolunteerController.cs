using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Entities.Volunteer;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel;
using Lumina_Hospital.ViewModel.Admin.AboutPage;
using Lumina_Hospital.ViewModel.Admin.Volunteer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class VolunteerController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public VolunteerController(IMapper mapper, LuminaHospitalDbContex contex, IWebHostEnvironment webHostEnvironment)
        {
            _mapper = mapper;
            _contex = contex;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var volunteer = _contex.Volunteers.Where(v => !v.IsDelete).ToList();
            return View(volunteer);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(VolunteerCreateVM volunterVM)
        {
            Volunteer volunteer = _mapper.Map<Volunteer>(volunterVM);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }
            if (!volunterVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }
            if (volunterVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }
            volunteer.ImagePath = volunterVM.ImagePath.SaveImage("./assets/images/volunteers/", _webHostEnvironment);
            _contex.Volunteers.Add(volunteer);
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var volunteer = _contex.Volunteers.FirstOrDefault(v => v.Id == id);
            if (volunteer == null) return NotFound();
            var volunterVM = _mapper.Map<VolunteerEditVM>(volunteer);
            return View(volunterVM);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(VolunteerEditVM volunterVM)
        {
            var volunter = _contex.Volunteers.FirstOrDefault(v => v.Id == volunterVM.Id);
            if (volunter == null) return NotFound();
            volunter.Name = volunterVM.Name;
            volunter.Position = volunterVM.Position;
            volunter.Testimonial = volunterVM.Testimonial;

            var photo = volunterVM.Photo;

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

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/volunteers/", volunter.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                volunter.ImagePath = photo.SaveImage("./assets/images/volunteers/", _webHostEnvironment);
            }

            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var volunteer = _contex.Volunteers
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (volunteer == null) return NotFound();
            volunteer.IsDelete = true;
            volunteer.DeleteAt = DateTime.Now;
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Volunteer? volunteer = _contex.Volunteers.FirstOrDefault(s => s.Id == id);
            return volunteer is null ? BadRequest() : View(volunteer);
        }



    }
}
