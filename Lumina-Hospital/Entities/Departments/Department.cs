using Lumina_Hospital.Entities.Doctors;

namespace Lumina_Hospital.Entities.Departments
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<Doctor> Doctors { get; set; }

    }
}
