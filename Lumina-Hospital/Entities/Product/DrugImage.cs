namespace Lumina_Hospital.Entities.Product
{
    public class DrugImage : BaseEntity
    {
        public string ImagePath { get; set; }
        public bool IsMain { get; set; }
        public bool IsHover { get; set; }
        public int DrugId { get; set; }
        public Drug Drug { get; set; }
    }
}
