using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.UserOrder;
using Microsoft.AspNetCore.Identity;

namespace Lumina_Hospital.Entities.AppUser
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public List<BlogComment> Comments { get; set; }
        public List<OrderInfo> OrderInfos { get; set; }
        public User()
        {
            Comments = new();
        }

    }
}
