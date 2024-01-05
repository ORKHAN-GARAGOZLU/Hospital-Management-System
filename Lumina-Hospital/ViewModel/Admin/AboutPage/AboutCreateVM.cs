using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.AboutPage
{
    public class AboutCreateVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile ImagePath { get; set; }
        public DateTime CreateAt { get; set; }
    }

    public class AboutCreateVMValidator : AbstractValidator<AboutCreateVM>
    {
        public AboutCreateVMValidator()
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
