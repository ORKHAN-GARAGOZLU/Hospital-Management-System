using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Departments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public DepartmentController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Department> departments = _context.Departments
                .Where(d => !d.IsDelete)
                .Include(d => d.Doctors)
                .ToList();
            return View(departments);
        }

        public IActionResult Detail(int id)
        {
            if (id == null) return NotFound();

            Department department = _context.Departments.Include(d => d.Doctors).FirstOrDefault(d => d.Id == id);

            return View(department);
        }
    }
}
