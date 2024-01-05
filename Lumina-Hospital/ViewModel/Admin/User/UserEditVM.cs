using Lumina_Hospital.Entities.UserOrder;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Admin.User
{
    public class UserEditVM : IdentityUser
    {
        [StringLength(30)]
        public string? FullName { get; set; }

        [StringLength(30)]
        public string? UserName { get; set; }

        [EmailAddress, DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [DataType(DataType.Password)]
        public string? OldPassword { get; set; }

        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }
        public OrderInfo OrderInfo { get; set; }
    }
}
