namespace Lumina_Hospital.Entities.Volunteer
{
    public class Volunteer : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string? Testimonial { get; set; }
        public string ImagePath { get; set; }


    }
}
