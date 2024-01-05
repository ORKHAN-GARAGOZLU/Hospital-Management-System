using Lumina_Hospital.Entities.Product;

namespace Lumina_Hospital.ViewModel
{
    public class ProductVM
    {
        public List<Category> Categories { get; set; }
        public List<Drug> Drugs { get; set; }
        public List<Drug> RelatedProducts { get; set; }
        public Drug CurrentProduct { get; set; }
        public List<ShippingInformation> ShippingInformations { get; set; }


    }
}
