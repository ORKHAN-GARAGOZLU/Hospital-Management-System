using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.ProductCategory
{
    public class CategoryCreateVM
    {
        public string Name { get; set; }
    }

    public class CategoryCreateVMValidator : AbstractValidator<CategoryCreateVM>
    {
        public CategoryCreateVMValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .MaximumLength(25);
                
        }
    }
}
