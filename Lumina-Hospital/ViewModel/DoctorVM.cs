using Lumina_Hospital.Entities.Departments;
using Lumina_Hospital.Entities.Doctors;

namespace Lumina_Hospital.ViewModel
{
    public class DoctorVM
    {
        public List<Department> Departments { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
