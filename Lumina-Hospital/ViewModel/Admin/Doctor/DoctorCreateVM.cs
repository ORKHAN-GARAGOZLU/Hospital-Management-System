using FluentValidation;

namespace Lumina_Hospital.ViewModel.Admin.Doctor
{
    public class DoctorCreateVM
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public IFormFile ImagePath { get; set; }
        public string Summary { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Faculty { get; set; }
        public string Mail { get; set; }
        public string CallNumber { get; set; }
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
    }

    public class DoctorCreateVMValidator : AbstractValidator<DoctorCreateVM>
    {
        public DoctorCreateVMValidator()
        {
            RuleFor(d => d.Name)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(d => d.Position)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(d => d.Summary)
                .NotEmpty()
                .MaximumLength(2000);
            RuleFor(d => d.Degree)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(d => d.Position)
                .NotEmpty()
                .MaximumLength(30);
            RuleFor(d => d.Experience)
                 .NotEmpty()
                .MaximumLength(50);
            RuleFor(d => d.Faculty)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(d => d.Mail)
                .NotEmpty()
                .MaximumLength(40);
            RuleFor(d => d.CallNumber)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(d => d.Faculty)
                .NotEmpty()
                .MaximumLength(50);
            RuleFor(d => d.DepartmentId)
                .NotEmpty();

        }
    }
}
