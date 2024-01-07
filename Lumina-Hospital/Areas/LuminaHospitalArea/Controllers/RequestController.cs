using Lumina_Hospital.DAL;
using Lumina_Hospital.ViewModel.Operator;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class RequestController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public RequestController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            RequestFormsVM vm = new()
            {
                VolunteerForms = _context.VolunteerForms.Where(v => !v.IsDelete).ToList(),
                ContactForms = _context.ContactForms.Where(c => !c.IsDelete).ToList(),
                Donates = _context.Donates.Where(d => !d.IsDelete).ToList(),
                Subscribers = _context.Subsicribers.Where(d => !d.IsDelete).ToList(),
            };
            return View(vm);
        }

        public IActionResult Delete(string type, int? id)
        {
            if (id == null) return NotFound();

            switch (type)
            {
                case "volunteer":
                    var volunteer = _context.VolunteerForms
                    .Where(v => !v.IsDelete).FirstOrDefault(d => d.Id == id);
                    if (volunteer == null) return NotFound();
                    volunteer.IsDelete = true;
                    volunteer.DeleteAt = DateTime.Now;
                    _context.SaveChanges();

                    break;

                case "contact":
                    var contact = _context.ContactForms
                    .Where(v => !v.IsDelete).FirstOrDefault(d => d.Id == id);
                    if (contact == null) return NotFound();
                    contact.IsDelete = true;
                    contact.DeleteAt = DateTime.Now;
                    _context.SaveChanges();
                    break;

                case "donate":
                    var donate = _context.Donates
                    .Where(v => !v.IsDelete).FirstOrDefault(d => d.Id == id);
                    if (donate == null) return NotFound();
                    donate.IsDelete = true;
                    donate.DeleteAt = DateTime.Now;
                    _context.SaveChanges();
                    break;

                case "subscriber":
                    var subscriber = _context.Subsicribers
                    .Where(v => !v.IsDelete).FirstOrDefault(d => d.Id == id);
                    if (subscriber == null) return NotFound();
                    subscriber.IsDelete = true;
                    subscriber.DeleteAt = DateTime.Now;
                    _context.SaveChanges();
                    break;

                default:
                    break;
            }

            return RedirectToAction("Index");
        }

    }
}
