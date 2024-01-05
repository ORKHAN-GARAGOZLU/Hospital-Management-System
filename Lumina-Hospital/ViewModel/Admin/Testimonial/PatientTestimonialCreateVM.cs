using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Testimonial
{
    public class PatientTestimonialCreateVM
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Position { get; set; }
        public IFormFile ImagePath { get; set; }
        public DateTime CreateAt { get; set; }
    }

    public class PatientTestimonialCreateVMValidator : AbstractValidator<PatientTestimonialCreateVM>
    {
        public PatientTestimonialCreateVMValidator()
        {
            RuleFor(a => a.Name)
                 .NotEmpty()
                 .MaximumLength(30);
            RuleFor(a => a.Content)
                .NotEmpty()
                .MaximumLength(200);
            RuleFor(a => a.Position)
                .NotEmpty()
                .MaximumLength(30);
        }
    }
}
