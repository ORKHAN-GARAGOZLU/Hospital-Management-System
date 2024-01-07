using Lumina_Hospital.DAL;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;


namespace Lumina_Hospital.Controllers
{
    public class BasketController : Controller
    {
        private readonly LuminaHospitalDbContex _context;

        public BasketController(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBasket(int? id)
        {
            if (id == null) return NotFound();
            var existDrug = _context.Drugs
                .Include(d => d.DrugImages)
                .FirstOrDefault(d => d.Id == id);
            if (existDrug == null) return NotFound();

            List<BasketVM> list = CheckBasket();
            CheckBasketItemCount(list, existDrug.Id);

            Response.Cookies.Append("basket",JsonConvert.SerializeObject(list), 
                new CookieOptions { MaxAge = TimeSpan.FromMinutes(20) });
            return RedirectToAction("index" ,"product");
        }

 
        public IActionResult ShowBasket()
        {
            string basket = Request.Cookies["basket"];
            List<BasketVM> drugs = new();
            if (basket != null)
            {
                drugs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                drugs = UpdateBasket(drugs);
            }
            return View(drugs);
        }

        private List<BasketVM> UpdateBasket(List<BasketVM> drugs)
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

        private List<BasketVM> CheckBasket()
        {
            List<BasketVM> list;

            string basket = Request.Cookies["basket"];

            if (basket == null)
            {
                list = new();
            }
            else
            {
                list = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            return list;
        }

        private void CheckBasketItemCount(List<BasketVM> list, int id)
        {
            var existProductInBaket = list.FirstOrDefault(p => p.Id == id);
            if (existProductInBaket == null)
            {
                BasketVM basketVM = new();
                basketVM.Id = id;
                basketVM.BasketCount = 1;
                list.Add(basketVM);
            }
            else
            {
                existProductInBaket.BasketCount++;
            }
        }

        public IActionResult Remove(int? id)
        {
            string basket = Request.Cookies["basket"];
            var drugs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            var basketItem = drugs.FirstOrDefault(p => p.Id == id);
            if (basketItem != null)
            {
                drugs.Remove(basketItem);
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(drugs),
                new CookieOptions { MaxAge = TimeSpan.FromMinutes(20) });

            return RedirectToAction("showbasket");
        }

        public IActionResult Increase(int? id)
        {
            string basket = Request.Cookies["basket"];
            var products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            var increaseProduct = products.FirstOrDefault(p => p.Id == id);

            if (increaseProduct != null)
            {
                if (increaseProduct.BasketCount < 10 && increaseProduct.BasketCount > increaseProduct.InStock)
                {
                    increaseProduct.BasketCount++;
                    
                    Response.Cookies.Append("basket", JsonConvert.SerializeObject(products),
                    new CookieOptions { MaxAge = TimeSpan.FromMinutes(15) });
                    
                }
                else
                {
                    ModelState.AddModelError("Increase", "Insufficient stock to increase the quantity.");
                    return RedirectToAction("ShowBasket");
                }
            }

            return RedirectToAction("ShowBasket");
        }

        public IActionResult Decrease(int? id)
        {

            string basket = Request.Cookies["basket"];
            var products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            var decreaseProduct = products.FirstOrDefault(p => p.Id == id);

            if (decreaseProduct != null)
            {
                if (decreaseProduct.BasketCount > 1)
                {
                    decreaseProduct.BasketCount--;
                }
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(products),
                new CookieOptions { MaxAge = TimeSpan.FromMinutes(15) });
            return RedirectToAction("ShowBasket");
        }


    }
}
