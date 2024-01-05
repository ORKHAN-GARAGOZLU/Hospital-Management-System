using AutoMapper;
using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Entities.Departments;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin.Department;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class DepartmentController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public DepartmentController(LuminaHospitalDbContex context, IWebHostEnvironment webHostEnvironment, IMapper mapper)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var departments = _context.Departments
                .Where(a => !a.IsDelete)
                .ToList();
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(DepartmentCreateVM departmentCreateVM)
        {
            Department depaertment = _mapper.Map<Department>(departmentCreateVM);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("ImagePath", "Add photo");
                return View();
            }

            if (!departmentCreateVM.ImagePath.CheckImage())
            {
                ModelState.AddModelError("ImagePath", "Add only photo");
                return View();
            }

            if (departmentCreateVM.ImagePath.CheckImageSize(1000))
            {
                ModelState.AddModelError("ImagePath", "Size is high, maximum size will be 1mb");
                return View();
            }

            depaertment.ImagePath = departmentCreateVM.ImagePath.SaveImage("./assets/images/department-detail/", _webHostEnvironment);
            _context.Departments.Add(depaertment);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var department = _context.Departments.FirstOrDefault(x => x.Id == id);
            if (department == null) return NotFound();
            var departmentVM = _mapper.Map<DepartmentEditVM>(department);

            return View(departmentVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(DepartmentEditVM departmentEditVM)
        {
            var department = _context.Departments.FirstOrDefault(d => d.Id == departmentEditVM.Id);
            if (department == null) return NotFound();

            department.Name = departmentEditVM.Name;
            department.ShortDescription = departmentEditVM.ShortDescription;
            department.Description = departmentEditVM.Description;

            var photo = departmentEditVM.Photo;

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

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/department-detail/", department.ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                department.ImagePath = photo.SaveImage("./assets/images/department-detail/", _webHostEnvironment);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var existDepartment = _context.Departments
                .Where(d =>!d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (existDepartment == null) return NotFound();
            existDepartment.IsDelete = true;
            existDepartment.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Department? department = _context.Departments.FirstOrDefault(s => s.Id == id);
            return department is null ? BadRequest() : View(department);
        }

    }
}
