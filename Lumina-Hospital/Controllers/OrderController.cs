using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.Entities.UserOrder;
using Lumina_Hospital.ViewModel;
using Lumina_Hospital.ViewModel.Operator;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Lumina_Hospital.Controllers
{
    public class OrderController : Controller
    {
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly LuminaHospitalDbContex _contex;
        private readonly UserManager<User> _userManager;

        public OrderController(LuminaHospitalDbContex contex, IHttpContextAccessor contextAccessor, UserManager<User> userManager)
        {
            _contex = contex;
            _contextAccessor = contextAccessor;
            _userManager = userManager;
        }

        public IActionResult Order()
        {
            string basket = Request.Cookies["basket"];
            List<BasketVM> basketItems = new List<BasketVM>();

            if (!string.IsNullOrEmpty(basket))
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                basketItems = UpdateBasket(basketItems);
            }

            OrderDetailVM vm = new OrderDetailVM
            {
                BasketItems = basketItems
            };

            return View(vm);

        }

        [HttpPost]
        public async Task<IActionResult> Order(OrderDetailVM vm)
        {
            string basket = Request.Cookies["basket"];
            List<BasketVM> basketItems = new List<BasketVM>();

            if (!string.IsNullOrEmpty(basket))
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                basketItems = UpdateBasket(basketItems);

                double totalPrice = basketItems.Sum(item => item.Price * item.BasketCount);
                List<string> productNames = basketItems.Select(item => item.Name).ToList();

                var currentUser = _contex.Users.FirstOrDefault(u => u.UserName == User.Identity.Name);

                if (currentUser != null)
                {
                    OrderInfo order = new()
                    {
                        Country = vm.Country,
                        City = vm.City,
                        Phone = vm.Phone,
                        Postcode = vm.Postcode,
                        Note = vm.Note,
                        Address = vm.Address,
                        TotalPrice = totalPrice,
                        User = currentUser,
                    };

                    _contex.OrderInfos.Add(order);
                    _contex.SaveChanges();

                    foreach (var basketItem in basketItems)
                    {
                        OrderDetail orderDetail = new OrderDetail
                        {
                            ProductName = basketItem.Name,
                            ProductPrice = basketItem.Price,
                            ProductCount = basketItem.BasketCount,
                            OrderInfoId = order.Id,
                        };

                        _contex.OrderDetails.Add(orderDetail);
                    }

                    _contex.SaveChanges();

                    return Content("Thanks for order");

                }
                else
                {
                    return Content("User not found");
                }
            }

            return RedirectToAction("Order");


        }

        private List<BasketVM> UpdateBasket(List<BasketVM> drugs)
        {
            foreach (var basketproduct in drugs)
            {
                var existproduct = _contex.Drugs
                    .Include(d => d.DrugImages)
                    .FirstOrDefault(d => d.Id == basketproduct.Id);
                basketproduct.Name = existproduct.Name;
                basketproduct.Price = existproduct.Price;
                basketproduct.ImagePath = existproduct.DrugImages.FirstOrDefault(d => d.IsMain).ImagePath;
            }
            return drugs;
        }


    }
}
