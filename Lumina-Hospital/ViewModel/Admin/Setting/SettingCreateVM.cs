using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Admin.Setting
{
    public class SettingCreateVM
    {
        [Required]
        public string Key { get; set; }
        public string? Value { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
