using Lumina_Hospital.Entities.Contact;
using Lumina_Hospital.Entities.Donation;
using Lumina_Hospital.Entities.SubscribeSection;
using Lumina_Hospital.Entities.Volunteer;

namespace Lumina_Hospital.ViewModel.Operator
{
    public class RequestFormsVM
    {
        public List<VolunteerForm> VolunteerForms { get; set; }
        public List<Donate> Donates { get; set; }
        public List<ContactForm> ContactForms { get; set; }
        public List<Subsicriber> Subscribers { get; set; }
    }
}
