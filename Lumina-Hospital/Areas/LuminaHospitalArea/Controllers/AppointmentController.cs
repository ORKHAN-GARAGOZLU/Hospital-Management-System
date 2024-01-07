using Lumina_Hospital.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class AppointmentController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public AppointmentController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var appointments = _context.Appointments.Where(a => !a.IsDelete)
                .Include(a => a.Doctor)
                .Include(o => o.User).ToList();
            return View(appointments);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var appointment = _context.Appointments
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (appointment == null) return NotFound();
            appointment.IsDelete = true;
            appointment.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
