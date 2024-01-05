namespace Lumina_Hospital.ViewModel.Admin.Product
{
    public class DrugEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public string ImagePathMain { get; set; }
        public string ImagePathHover { get; set; }
        public IFormFile MainPhoto { get; set; }
        public IFormFile HoverPhoto { get; set; }
        public List<IFormFile> Photos { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
