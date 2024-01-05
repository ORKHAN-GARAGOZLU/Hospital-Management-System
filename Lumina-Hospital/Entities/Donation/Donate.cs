namespace Lumina_Hospital.Entities.Donation
{
    public class Donate : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LastDonateDate { get; set; }
        public string BloodGroup { get; set; }
    }
}
