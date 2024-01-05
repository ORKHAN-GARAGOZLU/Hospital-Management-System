using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Account
{
    public class LoginVM
    {
        [Required, StringLength(30)]
        public string UserNameOrEmail { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
