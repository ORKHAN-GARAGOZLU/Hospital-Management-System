using Lumina_Hospital.Entities.Doctors;

namespace Lumina_Hospital.Entities.Appointments
{
    public class Appointment : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Day { get; set; }
        public string AvailableTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
