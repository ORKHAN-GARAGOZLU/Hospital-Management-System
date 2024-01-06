using Lumina_Hospital.Entities.Appointments;
using Lumina_Hospital.Entities.Departments;

namespace Lumina_Hospital.Entities.Doctors
{
    public class Doctor : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string ImagePath { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public DoctorBio DoctorBios { get; set; }
        public List<Appointment> Appointments { get; set; }
        public  List<Availability> Availabilities { get; set; }


    }
}
