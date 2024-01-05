namespace Lumina_Hospital.ViewModel.Operator
{
    public class OrderDetailVM
    {
        public string Country { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public string? ProductName { get; set; }
        public double TotalPrice { get; set; }
        public int UserId { get; set; }
        public List<BasketVM> BasketItems { get; set; }
    }
}
