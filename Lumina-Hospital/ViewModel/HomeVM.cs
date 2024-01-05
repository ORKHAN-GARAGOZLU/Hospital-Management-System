using Lumina_Hospital.Entities.AboutSection;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.Departments;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.Entities.DonateSection;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.Entities.SubscribeSection;
using Lumina_Hospital.Entities.VideoSection;

namespace Lumina_Hospital.ViewModel
{
    public class HomeVM
    {
        public Video Video { get; set; }
        public List<VideoTitle> VideoTitles { get; set; }
        public AboutSection AboutSection { get; set; }
        public DonateSection DonateSection { get; set; }
        public List<Department> Departments { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Drug> Drugs { get; set; }
        public List<Doctor> Doctors { get; set; }
        public Dictionary<string, string> Settings { get; set; }



    }
}
