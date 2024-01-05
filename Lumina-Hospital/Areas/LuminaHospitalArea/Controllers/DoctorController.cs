using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.Extension;
using Lumina_Hospital.Helper;
using Lumina_Hospital.ViewModel.Admin.Doctor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class DoctorController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public DoctorController(LuminaHospitalDbContex contex, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _webHostEnvironment = webHostEnvironment;
            _contex = contex;
            _mapper = mapper;
        }

        public IActionResult Index(int page = 1, int take = 6)
        {
            ViewBag.CurrentPage = page;

            var query = _contex.Doctors.AsQueryable();

            var doctor = query
                .Where(d => !d.IsDelete)
                .Include(d => d.DoctorBios)
                .Include(d => d.Department)
                .AsNoTracking()
                .Skip((page - 1) * take)
                .Take(take)
                .ToList();

            var pageCount = Pagination<Doctor>.CalculatePage(query.Count(), take);
            Pagination<Doctor> pagination = new(doctor, pageCount, page);
            return View(pagination);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = new SelectList(_contex.Departments.ToList(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(DoctorCreateVM doctorVM)
        {
            ViewBag.Departments = new SelectList(_contex.Departments.ToList(), "Id", "Name");

            Doctor doctor = new()
            {
                Name = doctorVM.Name,
                Position = doctorVM.Position,
                DepartmentId = doctorVM.DepartmentId,
                DoctorBios = new DoctorBio()
                {
                    Salary = doctorVM.Salary,
                    Mail = doctorVM.Mail,
                    CallNumber = doctorVM.CallNumber,
                    Faculty = doctorVM.Faculty,
                    Degree = doctorVM.Degree,
                    Summary = doctorVM.Summary,
                    Experience = doctorVM.Experience,
                }
            };

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }
            if (!doctorVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }
            if (doctorVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }
            doctor.ImagePath = doctorVM.ImagePath.SaveImage("./assets/images/doctor/", _webHostEnvironment);
            _contex.Doctors.Add(doctor);
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            ViewBag.Departments = new SelectList(_contex.Departments.ToList(), "Id", "Name");

            if (id == null) return NotFound();
            var doctor = _contex.Doctors
                .Where(d => !d.IsDelete)
                .Include(d => d.DoctorBios)
                .Include(d => d.Department)
                .FirstOrDefault(d => d.Id == id);
            if (doctor == null) return NotFound();

            return View(new DoctorEditVM
            {
                Id = doctor.Id,
                Name = doctor.Name,
                Position = doctor.Position,
                Salary = doctor.DoctorBios.Salary,
                Mail = doctor.DoctorBios.Mail,
                CallNumber = doctor.DoctorBios.CallNumber,
                Faculty = doctor.DoctorBios.Faculty,
                Experience = doctor.DoctorBios.Experience,
                Degree = doctor.DoctorBios.Degree,
                Summary = doctor.DoctorBios.Summary,
                DepartmentId = doctor.DepartmentId,
                ImagePath = doctor.ImagePath,
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(DoctorEditVM doctorVM)
        {
            ViewBag.Departments = new SelectList(_contex.Departments.ToList(), "Id", "Name");

            var doctor = _contex.Doctors.Include(d => d.DoctorBios).FirstOrDefault(d => d.Id == doctorVM.Id);
            if (doctor == null) return NotFound();

            doctor.Name = doctorVM.Name;
            doctor.Position = doctorVM.Position;
            doctor.DepartmentId = doctorVM.DepartmentId;
            doctor.DoctorBios.Summary = doctorVM.Summary;
            doctor.DoctorBios.Faculty = doctorVM.Faculty;
            doctor.DoctorBios.Salary = doctorVM.Salary;
            doctor.DoctorBios.Experience = doctorVM.Experience;
            doctor.DoctorBios.Mail = doctorVM.Mail;
            doctor.DoctorBios.CallNumber = doctorVM.CallNumber;
            doctor.DoctorBios.Degree = doctorVM.Degree;

            var photo = doctorVM.Photo;

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

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/doctor/", doctor.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                doctor.ImagePath = photo.SaveImage("./assets/images/doctor/", _webHostEnvironment);
            }

            _contex.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var doctor = _contex.Doctors
                .Where(d => !d.IsDelete)
                .Include(d =>d.DoctorBios)
                .FirstOrDefault(d => d.Id == id);
            if (doctor == null) return NotFound();
            doctor.IsDelete = true;
            doctor.DeleteAt = DateTime.Now;
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Doctor? doctor = _contex.Doctors.Include(d => d.DoctorBios).FirstOrDefault(s => s.Id == id);
            return doctor is null ? BadRequest() : View(doctor);
        }


    }
}
