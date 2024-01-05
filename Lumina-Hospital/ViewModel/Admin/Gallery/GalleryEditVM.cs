namespace Lumina_Hospital.ViewModel.Admin.Gallery
{
    public class GalleryEditVM
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public IFormFile Photo { get; set; }
    }
}
