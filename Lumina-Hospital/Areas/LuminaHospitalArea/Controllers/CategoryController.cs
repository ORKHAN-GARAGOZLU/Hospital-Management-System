using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.ViewModel.Admin.ProductCategory;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public CategoryController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var category = _context.Categories.Where(c => !c.IsDelete).ToList();
            return View(category);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(CategoryCreateVM categoryVM)
        {
            Category category = new()
            {
                Name = categoryVM.Name,
            };
            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(new CategoryEditVM
            {
                Id = category.Id,
                Name = category.Name,
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(CategoryEditVM categoryVM)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == categoryVM.Id);
            if (category == null) return NotFound();
            category.Name = categoryVM.Name;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var category = _context.Categories
                .Where(c => !c.IsDelete)
                .FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            category.IsDelete = true;
            category.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
