using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Appointments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public AppointmentController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public ActionResult Assignment()
        {
            ViewBag.Doctors = _context.Doctors.Include(d => d.Availabilities).ToList();

            return View();
        }

        [HttpPost]
        public JsonResult Assignment(string phone, DateTime start, DateTime? end, int doctorId, string time)
        {
            try
            {
                var currentUser = _context.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);
                var newAppointment = new Appointment
                {
                    Phone = phone,
                    Day = start,
                    DoctorId = doctorId,
                    AvailableTime = time,
                    User = currentUser,
                };

                _context.Appointments.Add(newAppointment);
                _context.SaveChanges();

                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }



        [HttpGet]
        public JsonResult GetDoctorAvailability(int doctorId)
        {
            try
            {
                var doctor = _context.Doctors.Include(d => d.Availabilities).FirstOrDefault(d => d.Id == doctorId);

                if (doctor != null)
                {
                    var availabilities = doctor.Availabilities.Select(a => a.Time).ToList();
                    return Json(availabilities);
                }

                return Json(new List<string>());
            }
            catch (Exception ex)
            {
                return Json(new { error = ex.Message });
            }
        }

      


    }
}
