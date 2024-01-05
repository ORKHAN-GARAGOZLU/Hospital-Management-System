namespace Lumina_Hospital.Entities.Volunteer
{
    public class VolunteerOnboarding : BaseEntity
    {
        public string Title { get; set; }
        public List<VolunteerOnboardingPoint> VolunteerOnboardingPoints { get; set; }

 
    }
    
}
