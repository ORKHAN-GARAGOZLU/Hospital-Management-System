namespace Lumina_Hospital.Entities.Volunteer
{
    public class VolunteerForm : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Education { get; set; }
        public string PhoneNumber { get; set; }
        public string AboutYourself { get; set; }
    }
}
