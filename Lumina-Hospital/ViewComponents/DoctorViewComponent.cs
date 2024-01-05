using Lumina_Hospital.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.ViewComponents
{
    public class DoctorViewComponent : ViewComponent
    {
        private readonly LuminaHospitalDbContex _context;

        public DoctorViewComponent(LuminaHospitalDbContex context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var doctor = _context.Doctors
                .Where(d => !d.IsDelete)
                .Include(d => d.Department)
                .Include(d => d.DoctorBios)
                .ToList();
            return View(await Task.FromResult(doctor));
        }
    }
}
