using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.SubscribeSection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class SubscribeController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public SubscribeController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult SubscribeRequest(Subsicriber subscriber)
        {
            if (ModelState.IsValid)
            {
                Subsicriber newSubscriber = new()
                {
                    Email = subscriber.Email,
                };
                newSubscriber.CreateAt = DateTime.Now;
                _context.Subsicribers.Add(newSubscriber);
                _context.SaveChanges();


                return Content("Thanks");
            }

            return View("Subscribe", subscriber);
        }
    }
}
