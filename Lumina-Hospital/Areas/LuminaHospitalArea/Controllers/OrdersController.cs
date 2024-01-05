using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AppUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class OrdersController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly UserManager<User> _userManager;


        public OrdersController(LuminaHospitalDbContex contex, UserManager<User> userManager)
        {
            _contex = contex;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var orders = _contex.OrderInfos.Where(o => !o.IsDelete)
                .Include(o => o.OrderDetails).Include(o => o.User).ToList();
            return View(orders);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var order = _contex.OrderInfos.Include(o => o.OrderDetails).FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();

            return View();
        }
    }
}
