using Lumina_Hospital.Entities.AppUser;

namespace Lumina_Hospital.Entities.Blog
{
    public class BlogComment : BaseEntity
    {
        public string Message { get; set; }
        public User User { get; set; }
        public DateTime CreationTime { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
       
    }
}
