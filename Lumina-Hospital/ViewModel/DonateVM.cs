using FluentValidation;

namespace Lumina_Hospital.ViewModel
{
    public class DonateVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LastDonateDate { get; set; }
        public string BloodGroup { get; set; }
    }

    public class DonateVMValidator : AbstractValidator<DonateVM>
    {
        public DonateVMValidator()
        {
            RuleFor(d => d.FullName)
                .NotEmpty();
            RuleFor(d => d.Email)
                .NotEmpty();
            RuleFor(d => d.Phone)
                .NotEmpty();
            RuleFor(d => d.BirthDate)
                .NotEmpty();
            RuleFor(d => d.LastDonateDate)
                .NotEmpty();
            RuleFor(d => d.BloodGroup)
                .NotEmpty();
        }
    }
}
