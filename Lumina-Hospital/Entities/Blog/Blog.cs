namespace Lumina_Hospital.Entities.Blog
{
    public class Blog : BaseEntity
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<BlogComment> Comments { get; set; }
    }
}
