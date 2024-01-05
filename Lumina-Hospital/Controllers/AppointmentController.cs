using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult Assignment()
        {
            return View();
        }
    }
}
