using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Admin.Video
{
    public class VideoTitleEditVM
    {
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string Title { get; set; }
    }
}
