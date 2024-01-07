using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.Extension;
using Lumina_Hospital.Services.Abstract;
using Lumina_Hospital.ViewModel.Admin.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class DrugController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ISendEmail _sendEmail;

        public DrugController(LuminaHospitalDbContex contex, IWebHostEnvironment webHostEnvironment, ISendEmail sendEmail)
        {
            _webHostEnvironment = webHostEnvironment;
            _contex = contex;
            _sendEmail = sendEmail;
        }


        public IActionResult Index()
        {
            var drug = _contex.Drugs
                .Where(d => !d.IsDelete)
                .Include(d => d.DrugImages)
                .ToList();
            return View(drug);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_contex.Categories.ToList(), "Id", "Name");

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(DrugCreateVM drugVM)
        {
            ViewBag.Categories = new SelectList(_contex.Categories.ToList(), "Id", "Name");
            Drug drug = new()
            {
                Name = drugVM.Name,
                Price = drugVM.Price,
                ShortDescription = drugVM.ShortDescription,
                LongDescription = drugVM.LongDescription,
                InStock = drugVM.InStock,
                CategoryId = drugVM.CategoryId,
            };
            drug.DrugImages = new();
            if (drugVM.MainPhoto != null)
            {
                if (!drugVM.MainPhoto.CheckImage())
                {
                    ModelState.AddModelError("MainPhoto", "Add only photo");
                    return View();
                }
                if (drugVM.MainPhoto.CheckImageSize(1000))
                {
                    ModelState.AddModelError("MainPhoto", "Size is high");
                    return View();
                }
                DrugImage mainPhoto = new();
                mainPhoto.ImagePath = drugVM.MainPhoto.SaveImage("./assets/images/products/", _webHostEnvironment);
                mainPhoto.IsMain = true;
                drug.DrugImages.Add(mainPhoto);
            }
            if (drugVM.HoverPhoto != null)
            {
                if (!drugVM.HoverPhoto.CheckImage())
                {
                    ModelState.AddModelError("HoverPhoto", "Add only photo");
                    return View();
                }
                if (drugVM.HoverPhoto.CheckImageSize(1000))
                {
                    ModelState.AddModelError("HoverPhoto", "Size is high");
                    return View();
                }
                DrugImage hoverPhoto = new();
                hoverPhoto.ImagePath = drugVM.HoverPhoto.SaveImage("./assets/images/products/", _webHostEnvironment);
                hoverPhoto.IsHover = true;
                drug.DrugImages.Add(hoverPhoto);
            }

            foreach (var photo in drugVM.Photos)
            {
                if (!photo.CheckImage())
                {
                    ModelState.AddModelError("Photos", "Add only photo");
                    return View();
                }
                if (photo.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photos", "Size is high");
                    return View();
                }
                DrugImage drugImage = new();
                drugImage.ImagePath = photo.SaveImage("./assets/images/products/", _webHostEnvironment);
                drug.DrugImages.Add(drugImage);
            }

            drug.CreateAt = DateTime.Now;
            _contex.Drugs.Add(drug);
            _contex.SaveChanges();

            //Send Email

            var productUrl = Url.Action(nameof(Detail), "Product", new { id = drug.Id });

            var subscriber = _contex.Subsicribers.ToList();
            foreach (var user in subscriber)
            {
                if (!string.IsNullOrEmpty(user.Email))
                {
                    var subject = "New product";

                    _sendEmail.SendEmail(user.Email, subject, productUrl, "wwwroot/templates/product/index.html");
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            ViewBag.Categories = new SelectList(_contex.Categories.ToList(), "Id", "Name");
            if (id == null) return NotFound();
            var drug = _contex.Drugs.Include(d => d.DrugImages).Include(d => d.Category)
                .FirstOrDefault(dr => dr.Id == id);
            if (drug == null) return NotFound();
            return View(new DrugEditVM
            {
                Id = drug.Id,
                Name = drug.Name,
                Price = drug.Price,
                ShortDescription = drug.ShortDescription,
                LongDescription = drug.LongDescription,
                InStock = drug.InStock,
                CategoryId = drug.CategoryId,
                ImagePathMain = drug.DrugImages.FirstOrDefault(d => d.IsMain).ImagePath,
                ImagePathHover = drug.DrugImages.FirstOrDefault(d => d.IsHover).ImagePath,
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(DrugEditVM drugVM)
        {
            ViewBag.Categories = new SelectList(_contex.Categories.ToList(), "Id", "Name");

            var drug = _contex.Drugs.Include(d => d.DrugImages).FirstOrDefault(d => d.Id == drugVM.Id);
            if (drug == null) return NotFound();
            drug.Name = drugVM.Name;
            drug.Price = drugVM.Price;
            drug.ShortDescription = drugVM.ShortDescription;
            drug.LongDescription = drugVM.LongDescription;
            drug.InStock = drugVM.InStock;
            drug.CategoryId = drugVM.CategoryId;

            var mainPhoto = drugVM.MainPhoto;

            if (mainPhoto != null)
            {
                if (!mainPhoto.CheckImage())
                {
                    ModelState.AddModelError("Photo", "Only Photo.");
                }

                if (mainPhoto.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photo", "Size is high.");
                }

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/products/", drug.DrugImages.FirstOrDefault(d => d.IsMain).ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                drug.DrugImages.FirstOrDefault(d => d.IsMain).ImagePath = mainPhoto.SaveImage("./assets/images/products/", _webHostEnvironment);
            }

            var hoverPhoto = drugVM.HoverPhoto;

            if (hoverPhoto != null)
            {
                if (!mainPhoto.CheckImage())
                {
                    ModelState.AddModelError("Photo", "Only Photo.");
                }

                if (mainPhoto.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photo", "Size is high.");
                }

                var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/products/", drug.DrugImages.FirstOrDefault(d => d.IsHover).ImagePath);
                if (System.IO.File.Exists(imagePathToDelete))
                {
                    System.IO.File.Delete(imagePathToDelete);
                }
                drug.DrugImages.FirstOrDefault(d => d.IsHover).ImagePath = hoverPhoto.SaveImage("./assets/images/products/", _webHostEnvironment);
            }

            foreach (var photo in drugVM.Photos)
            {
                if (!photo.CheckImage())
                {
                    ModelState.AddModelError("Photos", "Only Photo.");
                    return View();
                }
                if (photo.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photos", "Size is high.");
                    return View();
                }

                DrugImage drugImage = new();
                drugImage.ImagePath = photo.SaveImage("./assets/images/products/", _webHostEnvironment);
                drug.DrugImages.Add(drugImage);
            }


            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var drug = _contex.Drugs
                .Where(d => !d.IsDelete)
                .Include(d => d.DrugImages)
                .FirstOrDefault(d => d.Id == id);
            if (drug == null) return NotFound();
            drug.IsDelete = true;
            drug.DeleteAt = DateTime.Now;
            _contex.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            Drug? drug = _contex.Drugs.Include(d => d.DrugImages).FirstOrDefault(s => s.Id == id);
            return drug is null ? BadRequest() : View(drug);
        }




    }
}
