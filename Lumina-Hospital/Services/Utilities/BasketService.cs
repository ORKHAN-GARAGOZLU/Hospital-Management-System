using Lumina_Hospital.Services.Helpers;
using Lumina_Hospital.ViewModel;
using Newtonsoft.Json;

namespace Lumina_Hospital.Services.Utilities
{
    public class BasketService : IBasket
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public BasketService(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }

        public int GetBasketCount()
        {
            string basket = _contextAccessor.HttpContext.Request.Cookies["basket"];
            if (basket != null)
            {
                var drugs = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                return drugs.Sum(d => d.BasketCount);
            }
            return 0;
        }
    }
}
