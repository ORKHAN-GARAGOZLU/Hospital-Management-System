using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Donation;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Controllers
{
    public class DonateController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;

        public DonateController(LuminaHospitalDbContex contex)
        {
            _contex = contex;
        }

        public IActionResult DonateRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DonateRequest(DonateVM donateVM)
        {
            if (CalculateAge(donateVM.BirthDate) < 18)
            {
                ModelState.AddModelError("BirthDate", "You must be 18 or older to donate.");
                return View(donateVM);
            }
            if ((DateTime.Now - donateVM.LastDonateDate).TotalDays < 30)
            {
                ModelState.AddModelError("LastDonateDate", "You must wait at least 1 month before donating again.");
                return View(donateVM);
            }

            Donate donate = new()
            {
                Name = donateVM.FullName,
                Email = donateVM.Email,
                Phone = donateVM.Phone,
                BirthDate = donateVM.BirthDate,
                LastDonateDate = donateVM.LastDonateDate,
                BloodGroup = donateVM.BloodGroup
            };
            _contex.Donates.Add(donate);
            _contex.SaveChanges();
            return Content("Thansk for donate request");


        }
        private int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }
    }
}
