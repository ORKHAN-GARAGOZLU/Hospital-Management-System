using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Admin.Setting
{
    public class SettingEditVM
    {
        public int Id { get; set; }

        [Required]
        public string Key { get; set; }
        public string? Value { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
