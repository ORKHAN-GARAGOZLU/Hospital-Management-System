using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Account
{
    public class RegisterVM
	{
        [Required, StringLength(30)]
        public string FullName { get; set; }

        [Required, StringLength(30)]
        public string UserName { get; set; }

        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        [Required]
        public bool Terms { get; set; }
	}
	
}
