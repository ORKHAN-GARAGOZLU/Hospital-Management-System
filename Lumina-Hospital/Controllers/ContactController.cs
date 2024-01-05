using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Contact;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Controllers
{
    public class ContactController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public ContactController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult ContactRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactRequest(ContactFormVM contactVM)
        {
            ContactForm contact = new();
            contact.Name = contactVM.Name;
            contact.Email = contactVM.Email;
            contact.Tel = contactVM.Tel;
            contact.Message = contactVM.Mesaage;

            _context.ContactForms.Add(contact);
            _context.SaveChanges();

            return Content("your request sent");

        }


    }
}
