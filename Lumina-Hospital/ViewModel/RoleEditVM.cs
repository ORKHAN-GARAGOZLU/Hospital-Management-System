using Lumina_Hospital.Entities.AppUser;
using Microsoft.AspNetCore.Identity;

namespace Lumina_Hospital.ViewModel
{
    public class RoleEditVM
    {
        public List<IdentityRole> Roles { get; set; }
        public IList<string> UserRoles { get; set; }
        public User User { get; set; }
    }
}
