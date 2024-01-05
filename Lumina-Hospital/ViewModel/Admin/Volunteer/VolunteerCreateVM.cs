using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Volunteer
{
    public class VolunteerCreateVM
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string? Testimonial { get; set; }
        public IFormFile ImagePath { get; set; }

    }

    public class VolunteerCreateVMValidator : AbstractValidator<VolunteerCreateVM>
    {
        public VolunteerCreateVMValidator()
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
