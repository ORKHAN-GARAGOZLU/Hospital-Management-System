namespace Lumina_Hospital.Entities.VideoSection
{
    public class VideoTitle : BaseEntity
    {
        public string Title { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }

    }
}
