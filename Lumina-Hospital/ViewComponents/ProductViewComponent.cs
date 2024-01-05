using Lumina_Hospital.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        private readonly LuminaHospitalDbContex _context;

        public ProductViewComponent(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var drug = _context.Drugs
                .Where(d => !d.IsDelete)
                .Include(d => d.Category)
                .Include(d => d.DrugImages)
                .ToList();

            return View(await Task.FromResult(drug));

        }
    }
}
