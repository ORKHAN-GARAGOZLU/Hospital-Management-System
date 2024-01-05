namespace Lumina_Hospital.ViewModel.Admin.Product
{
    public class DrugCreateVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public IFormFile MainPhoto { get; set; }
        public IFormFile HoverPhoto { get; set; }
        public List<IFormFile> Photos { get; set; }

    }
}
