using Lumina_Hospital.DAL;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly LuminaHospitalDbContex _contex;

        public FooterViewComponent(LuminaHospitalDbContex contex)
        {
            _contex = contex;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            HomeVM vm = new HomeVM
            {
                Settings = _contex.Settings.ToDictionary(s => s.Key, s => s.Vaule)
            };

            return View(await Task.FromResult(vm));
        }
    }
}
