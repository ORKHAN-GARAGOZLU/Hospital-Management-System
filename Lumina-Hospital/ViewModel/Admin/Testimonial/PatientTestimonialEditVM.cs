using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Testimonial
{
    public class PatientTestimonialEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Position { get; set; }
        public string ImagePath { get; set; }
        public IFormFile? Photo { get; set; }

    }
    public class PatientTestimonialEditVMValidator: AbstractValidator<PatientTestimonialEditVM>
    {
        public PatientTestimonialEditVMValidator()
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
