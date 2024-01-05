using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.SubscribeSection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.ViewComponents
{
    public class SubscribeViewComponent : ViewComponent
    {
        private readonly LuminaHospitalDbContex _context;

        public SubscribeViewComponent(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var subscribe = _context.SubscribeSections.FirstOrDefault();
            return View(await Task.FromResult(subscribe));
        }

        


    }
}
