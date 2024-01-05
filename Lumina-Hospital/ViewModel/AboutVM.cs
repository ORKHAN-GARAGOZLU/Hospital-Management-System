using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Entities.Testimonial;

namespace Lumina_Hospital.ViewModel
{
    public class AboutVM
    {
        public List<About> Abouts { get; set; }
        public List<PatientTestimonial> PatientTestimonials { get; set; }
    }
}
