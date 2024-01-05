namespace Lumina_Hospital.Entities.UserOrder
{
    public class OrderDetail : BaseEntity
    {
        public string ProductName { get; set; }
        public int ProductCount { get; set; }
        public double ProductPrice { get; set; }
        public int OrderInfoId { get; set; }
        public OrderInfo OrderInfo { get; set; }
    }
}
