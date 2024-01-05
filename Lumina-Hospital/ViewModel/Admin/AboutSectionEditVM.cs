using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin
{
    public class AboutSectionEditVM
    {
        public int Id { get; set; }
        public string TitleFirst { get; set; }
        public string TitleTwo { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }
        public DateTime? UpdateAt { get; set; }
    }

    public class AboutSectionEditVMValidator : AbstractValidator<AboutSectionEditVM>
    {
        public AboutSectionEditVMValidator()
        {
            RuleFor(t => t.TitleFirst)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(t => t.TitleTwo)
                .NotEmpty()
                .MaximumLength(100);
            RuleFor(t => t.Description)
                .NotEmpty()
                .MaximumLength(150);
        }
    }
}
