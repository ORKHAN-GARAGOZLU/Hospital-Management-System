using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Department
{
    public class DepartmentCreateVM
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public IFormFile ImagePath { get; set; }
        public DateTime CreateAt { get; set; }
    }

    public class DepartmentCreateVMValidator : AbstractValidator<DepartmentCreateVM>
    {
        public DepartmentCreateVMValidator()
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
