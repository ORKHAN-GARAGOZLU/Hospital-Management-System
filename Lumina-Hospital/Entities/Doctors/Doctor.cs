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
       

    }
}
