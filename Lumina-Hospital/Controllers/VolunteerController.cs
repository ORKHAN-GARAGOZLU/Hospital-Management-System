using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Volunteer;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public VolunteerController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            VolunterVM vm = new()
            {
                Volunteers = _context.Volunteers.Where(v => !v.IsDelete).ToList(),
                VolunteerOnboardings = _context.VolunteerOnboardings.Where(v => !v.IsDelete).ToList(),
                VolunteerOnboardingPoints = _context.VolunteerOnboardingPoints.Where(v => !v.IsDelete).ToList(),
            };
            return View(vm);
        }


        [HttpPost]
        public IActionResult Index(VolunterVM vm)
        {
            vm.Volunteers = _context.Volunteers.Where(v => !v.IsDelete).ToList();
            vm.VolunteerOnboardings = _context.VolunteerOnboardings.Where(v => !v.IsDelete).ToList();
            vm.VolunteerOnboardingPoints = _context.VolunteerOnboardingPoints.Where(v => !v.IsDelete).ToList();

            VolunteerForm volunteerForm = new()
            {
                Name = vm.Name,
                Email = vm.Email,
                Education = vm.Education,
                Age = vm.Age,
                Gender = vm.Gender,
                PhoneNumber = vm.PhoneNumber,
                AboutYourself = vm.AboutYourself
            };
            _context.VolunteerForms.Add(volunteerForm);
            _context.SaveChanges();

            return Content("Thanks for your request");
            
        }
    }
}
