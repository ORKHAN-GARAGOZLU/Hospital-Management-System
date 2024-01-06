using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.Services.Abstract;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly IBasket _basketService;
        private readonly UserManager<User> _userManager;


        public HeaderViewComponent(LuminaHospitalDbContex contex, IBasket basketService, UserManager<User> userManager)
        {
            _contex = contex;
            _basketService = basketService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.Count = _basketService.GetBasketCount();

            //ViewBag.UserFullName = null;
            //if (User.Identity.IsAuthenticated)
            //{
            //    var user = await _userManager.FindByNameAsync(User.Identity.Name);

            //    ViewBag.UserFullName = user.FullName;
            //}

            HomeVM vm = new HomeVM
            {
                Settings = _contex.Settings.Where(s => !s.IsDelete).ToDictionary(s => s.Key, s => s.Vaule),
                Departments = _contex.Departments.Where(d => !d.IsDelete).Include(d => d.Doctors).ToList(),
                
            };

            return View(await Task.FromResult(vm));
        }
    }
}
