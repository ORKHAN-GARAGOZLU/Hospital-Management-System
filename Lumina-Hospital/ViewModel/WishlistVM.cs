namespace Lumina_Hospital.ViewModel
{
    public class WishlistVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public int CategoryId { get; set; }
        public int BasketCount { get; set; }
    }
}
