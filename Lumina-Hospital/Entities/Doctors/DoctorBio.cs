namespace Lumina_Hospital.Entities.Doctors
{
    public class DoctorBio : BaseEntity
    {
        public string Summary { get; set; }
        public string Degree { get; set; }
        public string Experience { get; set; }
        public string Faculty { get; set; }
        public string Mail { get; set; }
        public string CallNumber { get; set; }
        public double Salary { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
