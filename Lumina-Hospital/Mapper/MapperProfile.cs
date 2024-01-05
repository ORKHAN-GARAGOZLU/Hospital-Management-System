using AutoMapper;
using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Entities.AboutSection;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.Departments;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.Entities.DonateSection;
using Lumina_Hospital.Entities.Testimonial;
using Lumina_Hospital.Entities.VideoSection;
using Lumina_Hospital.Entities.Volunteer;
using Lumina_Hospital.ViewModel.Admin;
using Lumina_Hospital.ViewModel.Admin.AboutPage;
using Lumina_Hospital.ViewModel.Admin.Blog;
using Lumina_Hospital.ViewModel.Admin.Department;
using Lumina_Hospital.ViewModel.Admin.Doctor;
using Lumina_Hospital.ViewModel.Admin.Testimonial;
using Lumina_Hospital.ViewModel.Admin.Volunteer;

namespace Lumina_Hospital.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            //CreateMap<Video, VideoSectionEditVM>();

            CreateMap<AboutSection, AboutSectionEditVM>().ReverseMap();

            CreateMap<DonateSection, DonateSectionEditVM>().ReverseMap();


            CreateMap<Department, DepartmentCreateVM>().ReverseMap();
            CreateMap<Department, DepartmentEditVM>();



            CreateMap<About, AboutCreateVM>().ReverseMap(); 
            CreateMap<About, AboutEditVM>(); 


            CreateMap<PatientTestimonial, PatientTestimonialCreateVM>().ReverseMap();
            CreateMap<PatientTestimonial, PatientTestimonialEditVM>();


            CreateMap<Volunteer, VolunteerCreateVM>().ReverseMap();
            CreateMap<Volunteer, VolunteerEditVM>();


            CreateMap<Blog, BlogCreateVM>().ReverseMap();
            CreateMap<Blog, BlogEditVM>();









        }
    }
}
