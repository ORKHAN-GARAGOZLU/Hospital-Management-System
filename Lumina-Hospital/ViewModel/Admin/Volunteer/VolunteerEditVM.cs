using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Volunteer
{
    public class VolunteerEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string? Testimonial { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Photo { get; set; }
        public DateTime UpdateAt { get; set; }
    }

    public class VolunteerEditVMValidator : AbstractValidator<VolunteerEditVM>
    {
        public VolunteerEditVMValidator()
        {
            RuleFor(v => v.Name)
                 .NotEmpty()
                 .MaximumLength(30);
            RuleFor(v => v.Position)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(v => v.Testimonial)
                .MaximumLength(450);
        }
    }
}
