using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.SubscribeSection;
using Lumina_Hospital.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly LuminaHospitalDbContex _contex;

        public HomeController(LuminaHospitalDbContex contex)
        {
            _contex = contex;
        }

        public IActionResult Index()
        {
            HomeVM vm = new()
            {
                Video = _contex.Videos.FirstOrDefault(),
                VideoTitles = _contex.VideoTitles.Where(v => !v.IsDelete).ToList(),
                AboutSection = _contex.AboutSections.FirstOrDefault(),
                DonateSection = _contex.DonateSections.FirstOrDefault(),
                Departments = _contex.Departments.Where(d => !d.IsDelete).Include(d => d.Doctors).ToList(),
                Blogs = _contex.Blogs.Where(b => !b.IsDelete).ToList(),
                Drugs = _contex.Drugs.Where(d => !d.IsDelete).Include(d => d.DrugImages).ToList(),
            };
            return View(vm);
        }

        
        public IActionResult Search(string search)
        {
            HomeVM vm = new()
            {
                Departments = _contex.Departments
                .Where(d => !d.IsDelete)
                .Include(d => d.Doctors)
                .Where(d => d.Name.ToLower().Contains(search.ToLower()))
                .OrderBy(d => d.Id)
                .ToList(),

                Drugs = _contex.Drugs
                .Where(d => !d.IsDelete)
                .Include(d => d.DrugImages)
                .Where(d => d.Name.ToLower().Contains(search.ToLower()))
                .OrderBy(d => d.Id)
                .ToList(),

                Blogs = _contex.Blogs
                .Where(b => !b.IsDelete)
                .Where(d => d.Title.ToLower().Contains(search.ToLower()))
                .ToList(),

                Doctors = _contex.Doctors
                .Where(d => !d.IsDelete)
                .Include(d => d.DoctorBios)
                .Where(d => d.Name.ToLower().Contains(search.ToLower()))
                .ToList(),

            };

            return PartialView("_SearchPartial", vm);
        }

    }
}