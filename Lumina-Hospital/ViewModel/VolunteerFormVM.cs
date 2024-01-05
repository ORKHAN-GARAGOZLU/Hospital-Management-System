using FluentValidation;

namespace Lumina_Hospital.ViewModel
{
    public class VolunteerFormVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string PhoneNumber { get; set; }
        public string AboutYourself { get; set; }
    }

    public class VolunteerFormVMValidator : AbstractValidator<VolunteerFormVM>
    {
        public VolunteerFormVMValidator()
        {
            RuleFor(v => v.Name).NotEmpty();
            RuleFor(v => v.Email).NotEmpty();
            RuleFor(v => v.Age).NotNull();
            RuleFor(v => v.Gender).NotEmpty();
            RuleFor(v => v.Education).NotEmpty();
            RuleFor(v => v.PhoneNumber).NotEmpty();
            RuleFor(v => v.AboutYourself).NotEmpty();
        }
    }
}
