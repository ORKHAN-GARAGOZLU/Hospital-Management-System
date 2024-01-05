using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Department
{
    public class DepartmentEditVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public IFormFile? Photo { get; set; }

    }

    public class DepartmentEditVMValidator : AbstractValidator<DepartmentEditVM>
    {
        public DepartmentEditVMValidator()
        {
            RuleFor(d => d.Name)
                .NotEmpty()
                .MaximumLength(20);
            RuleFor(d => d.Description)
                .NotEmpty()
                .MaximumLength(1000);
            RuleFor(d => d.ShortDescription)
                .NotEmpty()
                .MaximumLength(100);
        }
    }
}
