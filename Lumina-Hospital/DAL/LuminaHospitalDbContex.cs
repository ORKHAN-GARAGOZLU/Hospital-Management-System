using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Entities.AboutSection;
using Lumina_Hospital.Entities.AppUser;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.Contact;
using Lumina_Hospital.Entities.Departments;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.Entities.DonateSection;
using Lumina_Hospital.Entities.Donation;
using Lumina_Hospital.Entities.Gallery;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.Entities.Settings;
using Lumina_Hospital.Entities.SubscribeSection;
using Lumina_Hospital.Entities.Testimonial;
using Lumina_Hospital.Entities.UserOrder;
using Lumina_Hospital.Entities.VideoSection;
using Lumina_Hospital.Entities.Volunteer;
using Lumina_Hospital.Extension;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lumina_Hospital.DAL
{
    public class LuminaHospitalDbContex: IdentityDbContext<User>
    {
        public LuminaHospitalDbContex(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<VideoTitle> VideoTitles { get; set; }
        public DbSet<AboutSection> AboutSections { get; set; }
        public DbSet<DonateSection> DonateSections { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<PatientTestimonial> PatientTestimonials { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
        public DbSet<VolunteerOnboarding> VolunteerOnboardings { get; set; }
        public DbSet<VolunteerOnboardingPoint> VolunteerOnboardingPoints { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorBio> DoctorBios { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<DrugImage> DrugImages { get; set; }
        public DbSet<ShippingInformation> ShippingInformations { get; set; }
        public DbSet<Donate> Donates { get; set; }
        public DbSet<VolunteerForm> VolunteerForms { get; set; }
        public DbSet<ContactForm> ContactForms { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<SubscribeSection> SubscribeSections { get; set; }
        public DbSet<Subsicriber> Subsicribers { get; set; }
        public DbSet<OrderInfo> OrderInfos { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Seed();
        }
    }
}
