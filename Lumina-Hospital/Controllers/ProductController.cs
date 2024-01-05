using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class ProductController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public ProductController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ProductVM vm = new()
            {
                Categories = _context.Categories.Where(c => !c.IsDelete).ToList(),
                Drugs = _context.Drugs.Where(d => !d.IsDelete).Include(d =>d.DrugImages).ToList(),
            };
            return View(vm);
        }

        public IActionResult Detail(int id)
        {
            var currentProduct = _context.Drugs
                .Include(d => d.Category)
                .Include(d => d.DrugImages)
                .FirstOrDefault(d => d.Id == id);

            if (currentProduct == null) return NotFound();

            var relatedProducts = _context.Drugs
                .Where(d => d.CategoryId == currentProduct.CategoryId && d.Id != currentProduct.Id && !d.IsDelete)
                .Include(d => d.DrugImages)
                .ToList();

            var vm = new ProductVM
            {
                CurrentProduct = currentProduct,
                RelatedProducts = relatedProducts,
                ShippingInformations = _context.ShippingInformations.Where(s => !s.IsDelete).ToList(),
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult GetProductsByCategory(string category)
        {
            List<Drug> drugs;

            if (category == "all")
            {
                drugs = _context.Drugs.Where(d => !d.IsDelete).Include(d => d.DrugImages).ToList();
            }
            else
            {
                drugs = _context.Drugs.Where(d => d.Category.Name == category && !d.IsDelete).Include(d => d.DrugImages).ToList();
            }

            ProductVM vm = new()
            {
                Categories = _context.Categories.Where(c => !c.IsDelete).ToList(),
                Drugs = drugs
            };

            return PartialView("_ProductPartial", vm);
        }

        

    }
}
