using Lumina_Hospital.Entities.AppUser;
using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Account
{
    public class ForgetPasswordVM
    {
        public User appUser { get; set; }

		[Required, DataType(DataType.Password)]
		public string Password { get; set; }

		[Required, DataType(DataType.Password), Compare(nameof(Password))]
		public string ConfirmPasswod { get; set; }
    }
}
