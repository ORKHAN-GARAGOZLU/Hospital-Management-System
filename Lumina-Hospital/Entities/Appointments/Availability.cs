using Lumina_Hospital.Entities.Doctors;

namespace Lumina_Hospital.Entities.Appointments
{
    public class Availability : BaseEntity
    {
        public string Time { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
