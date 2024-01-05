using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.AboutPage
{
    public class AboutEditVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public IFormFile? Photo { get; set; }

    }

    public class AboutEditVMValidator : AbstractValidator<AboutEditVM>
    {
        public AboutEditVMValidator()
        {
            RuleFor(a => a.Title)
                 .NotEmpty()
                 .MaximumLength(40);
            RuleFor(a => a.Description)
                .NotEmpty()
                .MaximumLength(800);
        }
    }
}
