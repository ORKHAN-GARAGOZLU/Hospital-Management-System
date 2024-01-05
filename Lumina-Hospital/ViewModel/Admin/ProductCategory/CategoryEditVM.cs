using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.ProductCategory
{
    public class CategoryEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CategoryEditVMValidator : AbstractValidator<CategoryEditVM>
    {
        public CategoryEditVMValidator()
        {
            RuleFor(c => c.Name)
               .NotEmpty()
               .MaximumLength(25);
        }
    }
}
