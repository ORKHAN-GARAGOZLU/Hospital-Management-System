using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin
{
    public class DonateSectionEditVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? UpdateAt { get; set; }
    }

    public class DonateSectionEditVMValidator : AbstractValidator<DonateSectionEditVM>
    {
        public DonateSectionEditVMValidator()
        {
            RuleFor(t => t.Title)
                .NotEmpty()
                .MaximumLength(45);

            RuleFor(t => t.Description)
                .NotEmpty()
                .MaximumLength(95);
        }
    }
}
