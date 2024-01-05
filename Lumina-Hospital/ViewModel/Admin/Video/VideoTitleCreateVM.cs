using System.ComponentModel.DataAnnotations;

namespace Lumina_Hospital.ViewModel.Admin.Video
{
    public class VideoTitleCreateVM
    {
        [Required, StringLength(30)]
        public string Title { get; set; }

        [Required]
        public int VideoId { get; set; }

    }
}
