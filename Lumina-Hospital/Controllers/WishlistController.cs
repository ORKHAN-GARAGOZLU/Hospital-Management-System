using Lumina_Hospital.DAL;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Lumina_Hospital.Controllers
{
    public class WishlistController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public WishlistController(LuminaHospitalDbContex context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddWishlist(int? id)
        {
            if (id == null) return NotFound();
            var existDrug = _context.Drugs
                .Include(d => d.DrugImages)
                .FirstOrDefault(d => d.Id == id);
            if (existDrug == null) return NotFound();

            List<WishlistVM> list = CheckWishlist();
            CheckWishlistItemCount(list, existDrug.Id);

            Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(list),
                new CookieOptions { MaxAge = TimeSpan.FromMinutes(20) });
            return RedirectToAction("index", "product");
        }

        private void CheckWishlistItemCount(List<WishlistVM> list, int id)
        {
            var existProductInBaket = list.FirstOrDefault(p => p.Id == id);
            if (existProductInBaket == null)
            {
                WishlistVM basketVM = new();
                basketVM.Id = id;
                basketVM.BasketCount = 1;
                list.Add(basketVM);
            }
            else
            {
                existProductInBaket.BasketCount++;
            }
        }

        private List<WishlistVM> CheckWishlist()
        {
            List<WishlistVM> list;

            string basket = Request.Cookies["wishlist"];

            if (basket == null)
            {
                list = new();
            }
            else
            {
                list = JsonConvert.DeserializeObject<List<WishlistVM>>(basket);
            }
            return list;
        }
        private List<WishlistVM> UpdateWishlist(List<WishlistVM> drugs)
        {
            foreach (var basketproduct in drugs)
            {
                var existproduct = _context.Drugs
                    .Include(d => d.DrugImages)
                    .FirstOrDefault(d => d.Id == basketproduct.Id);
                basketproduct.Name = existproduct.Name;
                basketproduct.Price = existproduct.Price;
                basketproduct.ImagePath = existproduct.DrugImages.FirstOrDefault(d => d.IsMain).ImagePath;
            }
            return drugs;
        }

        public IActionResult ShowWishlist()
        {
            string wishlist = Request.Cookies["wishlist"];
            List<WishlistVM> drugs = new();
            if (wishlist != null)
            {
                drugs = JsonConvert.DeserializeObject<List<WishlistVM>>(wishlist);
                drugs = UpdateWishlist(drugs);
            }
            return View(drugs);
        }


        public IActionResult RemoveFromWishlist(int? id)
        {
            string basket = Request.Cookies["wishlist"];
            var drugs = JsonConvert.DeserializeObject<List<WishlistVM>>(basket);
            var basketItem = drugs.FirstOrDefault(p => p.Id == id);
            if (basketItem != null)
            {
                drugs.Remove(basketItem);
            }
            Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(drugs),
                new CookieOptions { MaxAge = TimeSpan.FromMinutes(20) });

            return RedirectToAction("showwishlist");
        }
    }
}
