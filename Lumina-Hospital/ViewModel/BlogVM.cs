using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.Entities.Blog;

namespace Lumina_Hospital.ViewModel
{
    public class BlogVM
    {
        public Blog Blogs { get; set; }
        public List<Blog> Blogss { get; set; }

        public List<BlogComment> BlogComments { get; set; }

        public User User { get; set; }
    }
}
