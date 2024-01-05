using Lumina_Hospital.DAL;
using Lumina_Hospital.Entities.Settings;
using Lumina_Hospital.Extension;
using Lumina_Hospital.ViewModel.Admin.Setting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Lumina_Hospital.Areas.LuminaHospitalArea.Controllers
{
    [Area("LuminaHospitalArea")]
    [Authorize(Roles = "Admin")]
    public class SettingController : Controller
    {
        private readonly LuminaHospitalDbContex _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingController(LuminaHospitalDbContex context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var setting = _context.Settings.Where(s => !s.IsDelete).ToList();
            return View(setting);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create(SettingCreateVM settingCreateVM)
        {
            if (!ModelState.IsValid) return View();

            Setting setting = new();
            setting.Key = settingCreateVM.Key;
            if (settingCreateVM.Value != null)
            {
                setting.Vaule = settingCreateVM.Value;
            }
            else if (settingCreateVM.Photo != null)
            {
                if (!settingCreateVM.Photo.CheckImage())
                {
                    ModelState.AddModelError("Photo", "Add only photo");
                    return View();
                }
                if (settingCreateVM.Photo.CheckImageSize(1000))
                {
                    ModelState.AddModelError("Photo", "Size is high");
                    return View();
                }
                setting.Vaule = settingCreateVM.Photo.SaveImage("./assets/images/logo/", _webHostEnvironment);
            }
            _context.Settings.Add(setting);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            var settingEdit = _context.Settings.FirstOrDefault(s => s.Id == id);
            if (settingEdit == null) return NotFound();

            return View(new SettingEditVM
            {
                Id = settingEdit.Id,
                Key = settingEdit.Key,
                Value = settingEdit.Vaule
            });
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Edit(SettingEditVM settingEditVM)
        {
            if (ModelState.IsValid)
            {
                var setting = _context.Settings.FirstOrDefault(s => s.Id == settingEditVM.Id);

                if (setting == null) return NotFound();

                setting.Key = settingEditVM.Key;

                var value = settingEditVM.Value;
                var photo = settingEditVM.Photo;

                if (value != null)
                {
                    setting.Vaule = value;
                }
                else if (photo != null)
                {
                    if (!photo.CheckImage())
                    {
                        ModelState.AddModelError("Photo", "Only Photo.");
                        return View(settingEditVM);
                    }

                    if (photo.CheckImageSize(1000))
                    {
                        ModelState.AddModelError("Photo", "Size is high.");
                        return View(settingEditVM);
                    }

                    var imagePathToDelete = Path.Combine(_webHostEnvironment.WebRootPath, "./assets/images/logo/", setting.Vaule);
                    if (System.IO.File.Exists(imagePathToDelete))
                    {
                        System.IO.File.Delete(imagePathToDelete);
                    }

                    setting.Vaule = photo.SaveImage("./assets/images/logo/", _webHostEnvironment);
                }

                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(settingEditVM);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var setting = _context.Settings
                .Where(d => !d.IsDelete)
                .FirstOrDefault(d => d.Id == id);
            if (setting == null) return NotFound();
            setting.IsDelete = true;
            setting.DeleteAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }



    }
}
