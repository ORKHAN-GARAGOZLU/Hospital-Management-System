namespace Lumina_Hospital.Entities.Volunteer
{
    public class VolunteerOnboardingPoint : BaseEntity
    {
        public string Detail { get; set; }
        public int VolunteerOnboardingId { get; set; }
        public VolunteerOnboarding VolunteerOnboarding { get; set; }
    }
}
