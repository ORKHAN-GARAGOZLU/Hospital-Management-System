using FluentValidation;
using Lumina_Hospital.Entities.Volunteer;
using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel
{
    public class VolunterVM
    {
        public List<Volunteer> Volunteers { get; set; }
        public List<VolunteerOnboarding> VolunteerOnboardings { get; set; }
        public List<VolunteerOnboardingPoint> VolunteerOnboardingPoints { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, 40, ErrorMessage = "Age must be between 18 and 99")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Education is required")]
        [MaxLength(30, ErrorMessage = "Education must be at most 30 characters")]
        public string Education { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [MaxLength(20, ErrorMessage = "Phone number must be at most 20 characters")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "About yourself is required")]
        [MaxLength(1500, ErrorMessage = "About yourself must be at most 1500 characters")]
        public string AboutYourself { get; set; }

    }
   



}
