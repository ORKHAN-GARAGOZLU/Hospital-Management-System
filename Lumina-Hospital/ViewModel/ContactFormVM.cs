using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel
{
    public class ContactFormVM
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "Message is required")]
        [MaxLength(1000, ErrorMessage = "Message must be at most 1000 characters")]
        public string Mesaage { get; set; }
    }
}
