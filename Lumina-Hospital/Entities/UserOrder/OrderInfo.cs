using Lumina_Hospital.Entities.AppUser;

namespace Lumina_Hospital.Entities.UserOrder
{
    public class OrderInfo : BaseEntity
    {
        public string Country { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public double TotalPrice { get; set; }
        public User User { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
