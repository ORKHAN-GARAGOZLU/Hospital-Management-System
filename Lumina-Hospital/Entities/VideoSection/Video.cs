namespace Lumina_Hospital.Entities.VideoSection
{
    public class Video : BaseEntity
    {
        public string VideoPath { get; set; }
        public List<VideoTitle> VideoTitles { get; set; }

    }
}
