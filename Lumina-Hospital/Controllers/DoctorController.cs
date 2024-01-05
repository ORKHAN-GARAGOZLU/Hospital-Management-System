using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace Lumina_Hospital.Controllers
{
    public class DoctorController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;

        public DoctorController(LuminaHospitalDbContex contex)
        {
            _contex = contex;
        }

        public IActionResult Index()
        {
            DoctorVM vm = new()
            {
                Departments = _contex.Departments.Where(d => !d.IsDelete).ToList(),
                Doctors = _contex.Doctors.Where(d => !d.IsDelete).Include(d => d.Department).ToList(),
            };
            return View(vm);
        }

        public IActionResult Detail(int id)
        {
            if (id == 0) return NotFound();
            var doctor = _contex.Doctors
                .Include(d => d.Department)
                .Include(d => d.DoctorBios)
                .FirstOrDefault(d => d.Id == id);
            return View(doctor);
        }

        [HttpGet]
        public IActionResult FilterDoctors(string department)
        {
            if (department == null) return NotFound();

            List<Doctor> filteredDoctors;

            if (department == "All")
            {
                filteredDoctors = _contex.Doctors.Where(d => !d.IsDelete).Include(d => d.Department).ToList();
            }
            else
            {
                filteredDoctors = _contex.Doctors
                    .Where(d => !d.IsDelete && d.Department.Name == department)
                    .Include(d => d.Department)
                    .ToList();
            }

            DoctorVM vm = new DoctorVM
            {
                Departments = _contex.Departments.Where(d => !d.IsDelete).ToList(),
                Doctors = filteredDoctors,
            };

            return PartialView("_DoctorPartialView", vm);
        }


        



    }
}
