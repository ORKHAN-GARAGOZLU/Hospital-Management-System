namespace Lumina_Hospital.Entities.Product
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Drug> Drugs { get; set; }
    }
}
