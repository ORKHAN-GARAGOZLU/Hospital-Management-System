namespace Lumina_Hospital.Entities.Product
{
    public class Drug : BaseEntity
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<DrugImage> DrugImages { get; set; }

    }
}
