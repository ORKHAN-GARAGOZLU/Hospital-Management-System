using Lumina_Hospital.Entities.AboutPage;
using Lumina_Hospital.Entities.AboutSection;
using Lumina_Hospital.Entities.Appointments;
using Lumina_Hospital.Entities.Blog;
using Lumina_Hospital.Entities.Departments;
using Lumina_Hospital.Entities.Doctors;
using Lumina_Hospital.Entities.DonateSection;
using Lumina_Hospital.Entities.Gallery;
using Lumina_Hospital.Entities.Product;
using Lumina_Hospital.Entities.Settings;
using Lumina_Hospital.Entities.SubscribeSection;
using Lumina_Hospital.Entities.Testimonial;
using Lumina_Hospital.Entities.VideoSection;
using Lumina_Hospital.Entities.Volunteer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Lumina_Hospital.Extension
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {

            //foreach (var item in modelBuilder.Model
            //    .GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //    .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?))))
            //{
            //    item.SetColumnType("decimal(6,2)");
            //}

            #region Video Section

            string videoPath = "med.mp4";
            modelBuilder.Entity<Video>().HasData(

                new Video
                {
                    Id = 1,
                    VideoPath = videoPath,
                    IsDelete = false,
                    CreateAt = DateTime.Now
                });



            modelBuilder.Entity<VideoTitle>().HasData(

                new VideoTitle
                {
                    Id = 1,
                    Title = "Your Trusted Destination",
                    VideoId = 1,
                    IsDelete = false,
                    CreateAt = DateTime.Now

                },
                new VideoTitle
                {
                    Id = 2,
                    Title = "Here for You and Your Health",
                    VideoId = 1,
                    IsDelete = false,
                    CreateAt = DateTime.Now
                },
                new VideoTitle
                {
                    Id = 3,
                    Title = "Good Living, Good Health",
                    VideoId = 1,
                    IsDelete = false,
                    CreateAt = DateTime.Now
                },
                new VideoTitle
                {
                    Id = 4,
                    Title = "We Care, Your Smile Matters",
                    VideoId = 1,
                    IsDelete = false,
                    CreateAt = DateTime.Now
                });

            #endregion

            #region About Section

            modelBuilder.Entity<AboutSection>().HasData(
                new AboutSection
                {
                    Id = 1,
                    TitleFirst = "We are rewriting healthcare, together",
                    TitleTwo = "Together, we’re making an impact and building a healthier, equitable, and thriving Lumina.",
                    Description = "We are dedicated to delivering innovative care that bridges our expertise and your individual needs, so you can be your healthiest self.",
                    CreateAt = DateTime.Now
                });

            #endregion

            #region Donate Section

            modelBuilder.Entity<DonateSection>().HasData(
            new DonateSection
            {
                Id = 1,
                Title = "Your gift holds great power donate today!",
                Description = "Blood donation, a life-saving act transcending borders and cultures, share the gift of life.",
                CreateAt = DateTime.Now
            });

            #endregion

            #region Departments

            modelBuilder.Entity<Department>().HasData(
            new Department
            {
                Id = 1,
                Name = "Ophthalmology",
                ImagePath = "department-detail-Ophthalmology.jpg",
                ShortDescription = "Eye health experts; diagnose and treat vision issues, perform eye surgeries for better ocular well-being.",
                Description = "Ophthalmology is a medical specialty dedicated to the health of the eyes. Ophthalmologists are highly trained physicians who diagnose and treat a wide range of eye conditions, from refractive errors like myopia and hyperopia to more complex issues such as glaucoma, cataracts, and retinal disorders. They use advanced diagnostic tools, including retinal imaging and visual field testing, and perform surgical procedures like LASIK for vision correction and cataract removal. Beyond addressing medical concerns, ophthalmologists also play a crucial role in enhancing the quality of life for individuals by preserving and improving their eyesight.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 2,
                Name = "Neurology",
                ImagePath = "department-detail-Neurology.jpg",
                ShortDescription = "Nervous system specialists; diagnose and treat epilepsy, strokes, and brain-related disorders.",
                Description = "Neurology is the branch of medicine focused on the intricate network of the nervous system. Neurologists specialize in diagnosing and managing a diverse array of neurological disorders, encompassing conditions like epilepsy, multiple sclerosis, and Parkinson's disease. These specialists utilize advanced imaging technologies, such as magnetic resonance imaging (MRI) and electroencephalography (EEG), to study the brain's structure and function. Neurologists not only provide medical interventions but also work collaboratively with other healthcare professionals to enhance the overall well-being of patients dealing with complex neurological challenges.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 3,
                Name = "Radiology",
                ImagePath = "department-detail-Radiology.jpg",
                ShortDescription = "Imaging specialists; diagnose diseases using X-rays, CT scans, and MRIs, crucial for various medical fields.",
                Description = "Radiology is a medical discipline integral to modern healthcare, utilizing various imaging techniques to visualize the internal structures of the body. Radiologists employ X-rays, computed tomography (CT) scans, magnetic resonance imaging (MRI), and other technologies to diagnose and monitor diseases. They play a critical role in guiding treatment decisions for conditions ranging from fractures to cancers. Radiology's continuous advancements contribute significantly to medical research, enabling a deeper understanding of anatomical structures and pathologies, ultimately leading to improved patient outcomes.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 4,
                Name = "Dermatology",
                ImagePath = "department-detail-Dermatology.jpg",
                ShortDescription = "Skin experts; treat infections, cancer, and provide cosmetic dermatology services.",
                Description = "Dermatology, the study of skin, hair, and nails, encompasses a broad spectrum of medical and aesthetic concerns. Dermatologists diagnose and treat skin conditions such as acne, eczema, and psoriasis, as well as skin cancer. Additionally, they provide cosmetic dermatology services, including Botox injections and laser treatments. Dermatologists are at the forefront of skin cancer prevention, conducting regular screenings and promoting sun safety. Their expertise extends beyond medical interventions, emphasizing holistic skin health and personalized care.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 5,
                Name = "Haematology",
                ImagePath = "department-detail-Hematology.jpg",
                ShortDescription = "Blood disorder specialists; diagnose and treat anemia, leukemia, and clotting issues.",
                Description = "Haematology is the specialized field of medicine dedicated to the study and treatment of blood-related disorders. Hematologists investigate conditions such as anemia, leukemia, and clotting disorders. They employ diagnostic tools like blood tests and bone marrow examinations to determine the nature of blood disorders. Treatment modalities may include chemotherapy, blood transfusions, and stem cell transplants. Hematologists also contribute to research, advancing our understanding of blood diseases and developing innovative therapies to improve patient outcomes.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 6,
                Name = "Dentistry",
                ImagePath = "department-detail-Dentistry.jpg",
                ShortDescription = "Oral health care providers; offer preventive care, diagnose dental issues, perform surgeries.",
                Description = "Dentistry is a multifaceted medical specialty encompassing oral health and overall well-being. Dentists provide preventive care, including regular cleanings and oral examinations, to maintain optimal dental health. They diagnose and treat conditions such as cavities, gum disease, and oral infections. Dentistry also extends to restorative procedures like fillings, root canals, and extractions. Beyond clinical care, dentists emphasize patient education, promoting healthy oral hygiene practices to prevent dental issues and enhance overall quality of life.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 7,
                Name = "Orthopedic Surgery",
                ImagePath = "department-detail-Orthopedic-Surgery.jpg",
                ShortDescription = "Musculoskeletal surgeons; perform joint replacements, fracture repairs.",
                Description = "Orthopedic surgery specializes in the treatment of musculoskeletal conditions, addressing issues related to bones, joints, ligaments, and muscles. Orthopedic surgeons perform a range of procedures, including joint replacements, arthroscopic surgeries, and fracture repairs. These interventions aim to alleviate pain, restore function, and improve the overall quality of life for patients with orthopedic concerns. Orthopedic surgeons collaborate closely with rehabilitation professionals to ensure comprehensive care, emphasizing both surgical expertise and holistic patient recovery.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 8,
                Name = "Anesthesiology",
                ImagePath = "department-detail-Anesthesiology.jpg",
                ShortDescription = "Anesthesia specialists; ensure pain-free surgeries, monitor vital signs for safe procedures.",
                Description = "Anesthesiology is a critical medical discipline responsible for ensuring patient comfort and safety during surgical and medical procedures. Anesthesiologists administer anesthesia, carefully monitoring vital signs and adjusting dosage to maintain an optimal balance between unconsciousness and physiological stability. Their expertise extends to pain management, pre-operative assessments, and post-operative care. Anesthesiologists play a pivotal role in surgical teams, contributing to the success of procedures and minimizing patient discomfort. Their commitment to precision and patient well-being is paramount in facilitating positive surgical outcomes.",
                CreateAt = DateTime.Now
            },
            new Department
            {
                Id = 9,
                Name = "Rheumatology",
                ImagePath = "department-detail-Rheumatology.jpg",
                ShortDescription = "Joint and tissue disorder experts; diagnose and treat arthritis, autoimmune diseases.",
                Description = "Rheumatology focuses on the diagnosis and treatment of disorders affecting the joints, muscles, and connective tissues. Rheumatologists address conditions such as rheumatoid arthritis, lupus, and osteoarthritis. These specialists employ a comprehensive approach, utilizing medical history, physical examinations, and advanced imaging to formulate accurate diagnoses. Treatment plans may involve medication management, physical therapy, and lifestyle modifications. Rheumatologists also contribute to ongoing research, advancing our understanding of autoimmune and inflammatory conditions to optimize patient care and enhance long-term outcomes.",
                CreateAt = DateTime.Now
            });

            #endregion

            #region About Page

            modelBuilder.Entity<About>().HasData(
            new About
            {
                Id = 1,
                Title = "Expert care that's here for you",
                ImagePath = "about-1.jpg",
                Description = "Welcome to Lumina Hospital, where expert care is always here for you. Our dedicated team provides personalized, compassionate care in a state-of-the-art facility. From routine check-ups to advanced procedures, we prioritize your well-being. With cutting-edge technology and a focus on innovation, we ensure accurate diagnoses and effective treatments. Compassion is at our core. Our skilled professionals build meaningful connections, fostering trust throughout your healthcare journey. We embrace innovation, staying ahead with the latest medical advancements. Specialized services across various disciplines cater to your unique health needs. At Lumina Hospital, your health is our mission. Experience the difference of expert care.",
                CreateAt = DateTime.Now
            },
            new About
            {
                Id = 2,
                Title = "A national leader in cutting-edge research",
                ImagePath = "about-2.jpg",
                Description = "A beacon of excellence as a national leader in cutting-edge research. Our commitment to advancing medical knowledge sets us apart, driving innovation and improving patient outcomes. Our dedicated team of researchers, clinicians, and healthcare professionals collaborates on groundbreaking studies, pushing the boundaries of medical science. At the forefront of discovery, Lumina Hospital is proud to contribute to the latest advancements in healthcare. Our state-of-the-art research facilities, empower our experts to explore new frontiers in medicine. We actively engage in clinical trials, pioneering treatments that shape the future of healthcare. In addition to providing top-notch patient care. our institution is a hub for intellectual curiosity and scientific exploration.",
                CreateAt = DateTime.Now
            },
            new About
            {
                Id = 3,
                Title = "Transforming health care",
                ImagePath = "about-3.jpg",
                Description = "At Lumina Hospital, we are dedicated to transforming health care through innovation and a commitment to excellence. As a leading institution, we embrace a dynamic approach to healthcare that goes beyond traditional boundaries. Our multidisciplinary team of healthcare professionals is united in the pursuit of transforming the patient experience, focusing on personalized care and positive outcomes. Innovative technologies are at the core of our transformative journey. Lumina Hospital invests in state-of-the-art medical equipment and cutting-edge solutions to enhance diagnostic accuracy and treatment efficacy. From artificial intelligence applications to telemedicine advancements, we leverage the latest tools to provide accessible, efficient, and high-quality care.",
                CreateAt = DateTime.Now
            });

            #endregion

            #region Patient Testimonial

            modelBuilder.Entity<PatientTestimonial>().HasData(
            new PatientTestimonial
            {
                Id = 1,
                Name = "Eleanor Foster",
                Content = "Eleanor Foster expresses gratitude for the compassionate care and cutting-edge facilities at this healthcare leader, where a commitment to excellence defines every aspect of medical services.",
                Position = "Patient",
                ImagePath = "patient-testimonial-1.jpg",
                CreateAt = DateTime.Now
            },
            new PatientTestimonial
            {
                Id = 2,
                Name = "David Miller",
                Content = "David Miller highly recommends this hospital for its top-notch medical services, emphasizing the institution's reputation for compassion and excellence in healthcare delivery.",
                Position = "Patient",
                ImagePath = "patient-testimonial-2.jpg",
                CreateAt = DateTime.Now
            },
            new PatientTestimonial
            {
                Id = 3,
                Name = "Sophie Bennett",
                Content = "Sophie Bennett commends the hospital's exceptional care and expertise, highlighting a warm and welcoming patient environment that ensures a positive healthcare experience.",
                Position = "Patient",
                ImagePath = "patient-testimonial-3.jpg",
                CreateAt = DateTime.Now
            },
            new PatientTestimonial
            {
                Id = 4,
                Name = "Jackson Chen",
                Content = "Jackson Chen shares appreciation for the efficient and friendly staff who provided unparalleled support, contributing to a positive and reassuring hospital experience.",
                Position = "Patient",
                ImagePath = "patient-testimonial-5.jpg",
                CreateAt = DateTime.Now
            },
            new PatientTestimonial
            {
                Id = 5,
                Name = "Olivia Ramirez",
                Content = "Olivia Ramirez praises the skillful professionals and welcoming atmosphere that define this patient-centered hospital, offering a healthcare setting that prioritizes individual needs and comfort.",
                Position = "Patient",
                ImagePath = "patient-testimonial-4.jpg",
                CreateAt = DateTime.Now
            });

            #endregion

            #region Gallery

            modelBuilder.Entity<Gallery>().HasData(
            new Gallery
            {
                Id = 1,
                ImagePath = "gallery-1.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 2,
                ImagePath = "gallery-2.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 3,
                ImagePath = "gallery-3.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 4,
                ImagePath = "gallery-4.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 5,
                ImagePath = "gallery-5.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 6,
                ImagePath = "gallery-6.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 7,
                ImagePath = "gallery-7.jpg",
                CreateAt = DateTime.Now
            },
            new Gallery
            {
                Id = 8,
                ImagePath = "gallery-8.jpg",
                CreateAt = DateTime.Now
            });


            #endregion

            #region Volunteer

            modelBuilder.Entity<Volunteer>().HasData(
                new Volunteer
                {
                    Id = 1,
                    Name = "JASMINE THOMPSON",
                    Position = "Volunteer",
                    Testimonial = "Hospital is a remarkable hospital that provides excellent medical care and service. The hospital is very clean, modern, and comfortable. The staff are very kind, attentive, and caring. The doctors are very skilled, knowledgeable, and reliable. They made me feel comfortable and confident and gave me the best treatment possible. I am very thankful to Lumina Hospital and I would gladly go back to them if I need to.",
                    ImagePath = "volunteer-1.jpg",
                    CreateAt = DateTime.Now
                },
                new Volunteer
                {
                    Id = 2,
                    Name = "GRACE MARTINEZ",
                    Position = "Volunteer",
                    Testimonial = "I had a great experience at Lumina Hospital. The staff were friendly, professional, and attentive. The facilities were clean, modern, and comfortable. The doctors were knowledgeable, caring, and skilled. I received the best treatment possible and I am very satisfied with the outcome. I would highly recommend Lumina Hospital to anyone who needs medical care.",
                    ImagePath = "volunteer-2.jpg",
                    CreateAt = DateTime.Now
                },
                new Volunteer
                {
                    Id = 3,
                    Name = "HENRY EVANS",
                    Position = "Volunteer",
                    Testimonial = "Lumina Hospital is the best hospital I have ever been to. The quality of care is outstanding, the prices are reasonable, and the service is excellent. The hospital has a wide range of specialties and equipment, and the doctors are experts in their fields. I felt safe, respected, and well-informed throughout my stay. I am very grateful to Lumina Hospital for saving my life.",
                    ImagePath = "volunteer-3.jpg",
                    CreateAt = DateTime.Now
                },
                new Volunteer
                {
                    Id = 4,
                    Name = "ISAAC TAYLOR",
                    Position = "Volunteer",
                    Testimonial = "Lumina Hospital is a wonderful hospital that offers high-quality medical care and service. The hospital is very spacious, bright, and cozy. The staff are very courteous, polite, and cheerful. The doctors are very qualified, dedicated, and respectful. They listened to my concerns and gave me the best advice and treatment. I am very impressed by Lumina Hospital and I would highly praise them to anyone.",
                    ImagePath = "volunteer-4.jpg",
                    CreateAt = DateTime.Now
                }, 
                new Volunteer
                {
                    Id = 5,
                    Name = "HANNAH REED",
                    Position = "Volunteer",
                    Testimonial = "The hospital is very neat, elegant, and relaxing. The staff are very warm, friendly, and supportive. The doctors are very professional, competent, and honest. They treated me with dignity and respect and gave me the best care possible. I am very pleased with Lumina Hospital and I would strongly recommend them to anyone.",
                    ImagePath = "volunteer-5.jpg",
                    CreateAt = DateTime.Now
                }, 
                new Volunteer
                {
                    Id = 6,
                    Name = "SEBASTIAN ROSS",
                    Position = "Volunteer",
                    Testimonial = "I can’t thank Lumina Hospital enough for the amazing care they provided to me and my family. The hospital is very clean, organized, and efficient. The staff are very friendly, helpful, and compassionate. The doctors are very experienced, confident, and trustworthy. They explained everything clearly and answered all my questions. I am very happy with the results and I would definitely choose Lumina Hospital again.",
                    ImagePath = "volunteer-6.jpg",
                    CreateAt = DateTime.Now
                });


            modelBuilder.Entity<VolunteerOnboarding>().HasData(
                new VolunteerOnboarding
                {
                    Id = 1,
                    Title = "Diversity Is At Our Core",
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboarding
                {
                    Id = 2,
                    Title = "Interview",
                    CreateAt = DateTime.Now
                }, 
                new VolunteerOnboarding
                {
                    Id = 3,
                    Title = "On-Boarding",
                    CreateAt = DateTime.Now
                });


            modelBuilder.Entity<VolunteerOnboardingPoint>().HasData(
                new VolunteerOnboardingPoint
                {
                    Id = 1,
                    Detail = "Lumina Hospital is committed to creating and sustaining an inclusive workplace where employees and volunteers are valued and engaged, not in spite of, but because of, our differences – whether seen or unseen.",
                    VolunteerOnboardingId = 1,
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboardingPoint
                {
                    Id = 2,
                    Detail = "We believe that there is strength in diversity. Diversity enables the success of our mission; ensuring that we are a caring, open place to work and reflect the communities we serve.",
                    VolunteerOnboardingId = 1,
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboardingPoint
                {
                    Id = 3,
                    Detail = "Selected applicants will be notified of times for a phone interview. Phone interviews are generally about 20 minutes to confirm the information on your application and find out a little more about you and your interest in volunteering.",
                    VolunteerOnboardingId = 2,
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboardingPoint
                {
                    Id = 4,
                    Detail = "Applicants may then be brought in for an in-person interview with a Volunteer Services team member to determine placement in a volunteer role.",
                    VolunteerOnboardingId = 2,
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboardingPoint
                {
                    Id = 5,
                    Detail = "Prospective volunteers will be invited to a volunteer orientation once a volunteer placement has been confirmed.",
                    VolunteerOnboardingId = 3,
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboardingPoint
                {
                    Id = 6,
                    Detail = "Prior to orientation, prospective volunteers will need to have an in-person appointment with Luminas’s Occupational Health to review required immunizations and vaccinations. All volunteers must be fully vaccinated against COVID.",
                    VolunteerOnboardingId = 3,
                    CreateAt = DateTime.Now
                },
                new VolunteerOnboardingPoint
                {
                    Id = 7,
                    Detail = "After volunteer orientation and Occupational Health clearance, volunteers are then able to obtain their ID badge and begin volunteering.",
                    VolunteerOnboardingId = 3,
                    CreateAt = DateTime.Now
                });



            #endregion

            #region Blog

            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                Author = "Dr. Nabiha Abdulkareem",
                Title = "Migraines: Simple Steps to Head Off the Pain",
                ImagePath = "blog-2.jpg",
                Description = "Before moving to the steps to manage migraine pain, we need to first understand what migraine is. Migraine is a common neurological issue that typically manifests as an intense headache coupled with symptoms such as nausea, vomiting, or an increased sensitivity to light and sound. It’s essential to note that the specific symptoms can vary based on the type of migraine the patient has. This condition is caused due to a complex interplay of genetic factors. It is often triggered by certain biological and environmental influences. The triggers that cause for a migraine attack to occur may be unique to each individual and can comprise various stimuli, such as specific food components, odours, or hormonal fluctuations. An episode of the pain caused by a migraine is referred to as a ‘migraine attack’. It is an episode of intense pain, caused due to different triggers. A combination of medicine, along with behavioural measures and lifestyle changes, can be a highly effective way to deal with migraines and even prevent migraine attacks in the future.",
                CreateAt = DateTime.Now
            },
            new Blog
            {
                Id = 2,
                Author = "Dr. Benjamin Anderson",
                Title = "Common Sports Injuries and How to Avoid Them",
                ImagePath = "blog-1.jpg",
                Description = "Sports have always been important in encouraging people to be physically active, mentally healthy, and socially connected. Whether you’re a professional athlete or simply someone who enjoys an active lifestyle, sports injuries can be a significant setback. The term “sports injury” describes the many types of injuries that are often sustained when engaging in sports or exercising; however, they are not exclusive to athletes. Sports-related injuries tend to occur due to overuse, direct collisions, or the application of force that exceeds the body’s structural capacity. The good news is that many sports injuries can be prevented with the right precautions and strategies. Strains and sprains are among the most common sports injuries. A strain refers to the stretching or tearing of muscles or tendons, while a sprain involves ligament damage. These injuries can occur in various sports, from basketball to football, and even in everyday activities like lifting heavy objects. To prevent strains and sprains, it’s essential to maintain flexibility through regular stretching exercises.",
                CreateAt = DateTime.Now
            },
            new Blog
            {
                Id = 3,
                Author = "Dr. Lucas Turner",
                Title = "Rheumatoid Arthritis: Symptoms, Diagnosis, and Treatment",
                ImagePath = "blog-3.jpg",
                Description = "Rheumatoid Arthritis (RA) is a complex and debilitating autoimmune disease that affects millions of people worldwide. The main characteristic of rheumatoid arthritis is the body’s immune system accidentally attacking healthy cells, leading to inflammation (painful swelling) in the areas of the body affected. This chronic inflammatory condition can result in severe joint damage, pain, and decreased quality of life for those who suffer from it. Hand, wrist, and knee joints are often affected by RA. Chronic or long-lasting discomfort, instability (loss of balance), and deformity can all result from this tissue injury. In addition to these tissues, RA can harm other organs, including the heart, lungs, and eyes as well as other tissues all over the body. While there is no known cure for rheumatoid arthritis, early diagnosis and effective treatment can significantly improve the lives of affected individuals. Rheumatoid arthritis is a complex autoimmune disease that affects many aspects of a person’s life. Early diagnosis and appropriate treatment can significantly improve the quality of life for those living with this condition.",
                CreateAt = DateTime.Now
            },
            new Blog
            {
                Id = 4,
                Author = "Dr. Nicholas Hall",
                Title = "Dementia & Alzheimer’s – 10 Early Signs and Symptoms",
                ImagePath = "blog-4.jpg",
                Description = "Catching dementia early and promptly starting treatment can significantly slow its progression, helping preserve cognitive abilities longer. Witnessing a loved one’s mental decline is undoubtedly difficult, but the early and middle stages still present opportunities for better outcomes through patience and compassion. In this article, we’ll explore subtle signs of dementia to monitor and when it’s time to seek medical evaluation. An early diagnosis enables critical treatments to help your loved one retain more of the qualities that make them who they are. As dementia progresses, spatial orientation and directional sense often decline. Your once very independent loved one may have always navigated their own neighbourhood flawlessly. But now when you take them out, they become disoriented and fail to recognise familiar landmarks and street names. Even short walks from their home to the car leave them turned around and confused.",
                CreateAt = DateTime.Now
            },
            new Blog
            {
                Id = 5,
                Author = "Dr. Sophia Roberts",
                Title = "Raise Low Blood Pressure Naturally Through Diet",
                ImagePath = "blog-5.jpg",
                Description = "Low blood pressure, often known as hypotension, is defined as a blood pressure measurement less than 90/60 mm Hg. This medical condition affects a large number of individuals, especially as they get older. Low blood pressure can be triggered by a number of causes, including adverse reactions to medications and medical conditions such as diabetes. If there are no symptoms, low blood pressure is not worrisome. Most medical professionals will only identify low blood pressure as a cause for concern if a patient exhibits its symptoms, such as blurred vision, dizziness, and fainting. Low blood pressure can lead to a heart attack or stroke, both of which might be fatal or result in long-term harm to the brain and heart. If anyone experiences concerns about low blood pressure symptoms, they should consult their doctor. Likewise, medical professionals can assess the adverse effects of medications and make changes as necessary.",
                CreateAt = DateTime.Now
            },
            new Blog
            {
                Id = 6,
                Author = "Dr. Ava Lewis",
                Title = "How Joint Replacement Can Transform Your Daily Activities?",
                ImagePath = "blog-6.jpg",
                Description = "With the increase in old age, people experience joint injuries which are due to conditions like arthritis, fractures, and joint abnormalities. These conditions might cause hindrances in the quality of life of the patient. Thus, doctors suggest and perform joint replacement surgery. Metals, ceramics, or robust plastics can be used to make the artificial joint (prosthesis). The artificial joint behaves similarly to the native joint and has a comparable appearance. Any joint in the body can be replaced by a surgeon; however, hip replacement and knee replacement are the two most popular joint replacement procedures. Living with chronic pain can significantly influence a patient’s life negatively. Joint replacement surgery notably enhances the quality of life by reducing pain, aiding in proper sleep, and fostering a positive sense of well-being. The core muscles help support the back while standing and climbing stairs. They also prevent discomfort while lying down and reduce back pain. It is recommended to do core exercises to improve health and well-being.",
                CreateAt = DateTime.Now
            });

            #endregion

            #region Doctor

            modelBuilder.Entity<Doctor>().HasData(
            new Doctor
            {
                Id = 1,
                DepartmentId = 2,
                Name = "Dr. Nabiha Abdulkareem",
                Position = "Neurologist",
                ImagePath = "doctor-1.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 2,
                DepartmentId = 6,
                Name = "Dr. Benjamin Anderson",
                Position = "Dermatologist",
                ImagePath = "doctor-2.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 3,
                DepartmentId = 1,
                Name = "Dr. Emily Williams",
                Position = "Ophthalmologist",
                ImagePath = "doctor-3.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 4,
                DepartmentId = 1,
                Name = "Dr. Jonathan Taylor",
                Position = "Ophthalmologist",
                ImagePath = "doctor-4.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 5,
                DepartmentId = 3,
                Name = "Dr. Jackson Davis",
                Position = "Radiologist",
                ImagePath = "doctor-19.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 6,
                DepartmentId = 5,
                Name = "Dr. Sophia Roberts",
                Position = "Haematologist",
                ImagePath = "doctor-6.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 7,
                DepartmentId = 3,
                Name = "Dr. Samuel Wright",
                Position = "Radiologist",
                ImagePath = "doctor-7.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 8,
                DepartmentId = 1,
                Name = "Dr. Ethan Wilson",
                Position = "Ophthalmologist",
                ImagePath = "doctor-8.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 9,
                DepartmentId = 8,
                Name = "Dr. Caleb Baker",
                Position = "Anesthesiologist",
                ImagePath = "doctor-9.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 10,
                DepartmentId = 8,
                Name = "Dr. Wang Tao",
                Position = "Anesthesiologist",
                ImagePath = "doctor-10.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 11,
                DepartmentId = 6,
                Name = "Dr. Jackson Williams",
                Position = "Dentist",
                ImagePath = "doctor-11.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 12,
                DepartmentId = 2,
                Name = "Dr. Nicholas Hall",
                Position = "Neurologist",
                ImagePath = "doctor-12.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 13,
                DepartmentId = 7,
                Name = "Dr. Isabella Martinez",
                Position = "Orthopedic-Surgery",
                ImagePath = "doctor-13.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 14,
                DepartmentId = 2,
                Name = "Dr. Lucas Turner",
                Position = "Neurologist",
                ImagePath = "doctor-14.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 15,
                DepartmentId = 7,
                Name = "Dr. Victoria Brown",
                Position = "Orthopedic-Surgery",
                ImagePath = "doctor-15.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 16,
                DepartmentId = 9,
                Name = "Dr. Ava Lewis",
                Position = "Rheumatologist",
                ImagePath = "doctor-16.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 17,
                DepartmentId = 9,
                Name = "Dr. Benjamin Clark",
                Position = "Rheumatologist",
                ImagePath = "doctor-17.jpg",
                CreateAt = DateTime.Now
            },
            new Doctor
            {
                Id = 18,
                DepartmentId = 5,
                Name = "Dr. Chen Jie",
                Position = "Haematologist",
                ImagePath = "doctor-18.jpg",
                CreateAt = DateTime.Now
            });



            //Doctor bio



            modelBuilder.Entity<DoctorBio>().HasData(
            new DoctorBio
            {
                Id = 1,
                DoctorId = 1,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 2,
                DoctorId = 2,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 3,
                DoctorId = 3,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 4,
                DoctorId = 4,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 5,
                DoctorId = 5,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 6,
                DoctorId = 6,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 7,
                DoctorId = 7,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 8,
                DoctorId = 8,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 9,
                DoctorId = 9,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 10,
                DoctorId = 10,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 11,
                DoctorId = 11,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 12,
                DoctorId = 12,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 13,
                DoctorId = 13,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 14,
                DoctorId = 14,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 15,
                DoctorId = 15,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 16,
                DoctorId = 16,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 17,
                DoctorId = 17,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            },
            new DoctorBio
            {
                Id = 18,
                DoctorId = 18,
                Salary = 2500,
                Degree = "High degree",
                Experience = "Many years of experience",
                Faculty = "The Faculty of University",
                Mail = "someone@gmail.com",
                CallNumber = "(+465)464-654-65461",
                Summary = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.",
                CreateAt = DateTime.Now
            });


            #endregion

            #region Drug

            #region Product Category

            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Depressants",
                CreateAt = DateTime.Now
            },
            new Category
            {
                Id = 2,
                Name = "Stimulants",
                CreateAt = DateTime.Now
            },
            new Category
            {
                Id = 3,
                Name = "Inhalants",
                CreateAt = DateTime.Now
            },
            new Category
            {
                Id = 4,
                Name = "Hallucinogens",
                CreateAt = DateTime.Now
            },
            new Category
            {
                Id = 5,
                Name = "Prescription Drugs",
                CreateAt = DateTime.Now
            });

            #endregion

            #region Product

            modelBuilder.Entity<Drug>().HasData(
            new Drug
            {
                Id = 1,
                Name = "Therapexa",
                Price = 40.15,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 20,
                CategoryId = 1,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 2,
                Name = "Vitalox",
                Price = 50.45,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 25,
                CategoryId = 1,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 3,
                Name = "Nexacalm",
                Price = 50.35,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 55,
                CategoryId = 1,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 4,
                Name = "Zephyramine",
                Price = 30.35,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 15,
                CategoryId = 2,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 5,
                Name = "Healithium",
                Price = 20,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 25,
                CategoryId = 2,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 6,
                Name = "Neurolynx",
                Price = 20.85,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 25,
                CategoryId = 2,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 7,
                Name = "Revitazen",
                Price = 45,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 35,
                CategoryId = 3,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 8,
                Name = "Serenitol",
                Price = 45,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 10,
                CategoryId = 3,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 9,
                Name = "Medipulse",
                Price = 45.50,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 10,
                CategoryId = 3,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 10,
                Name = "Tranquilix",
                Price = 55.50,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 20,
                CategoryId = 4,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 11,
                Name = "Serenifly",
                Price = 32.50,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 15,
                CategoryId = 4,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 12,
                Name = "Paxilife",
                Price = 35,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 25,
                CategoryId = 4,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 13,
                Name = "NeuraZen",
                Price = 45.55,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 15,
                CategoryId = 5,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 14,
                Name = "ZeniCure",
                Price = 45.55,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 15,
                CategoryId = 5,
                CreateAt = DateTime.Now
            },
            new Drug
            {
                Id = 15,
                Name = "EquiTranquil",
                Price = 65.55,
                ShortDescription = "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.",
                LongDescription = "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.",
                InStock = 25,
                CategoryId = 5,
                CreateAt = DateTime.Now
            });




            #endregion

            #region Product Images

            #region Drug 1

            modelBuilder.Entity<DrugImage>().HasData(
            new DrugImage
            {
                Id = 1,
                ImagePath = "product-1.png",
                IsMain = true,
                IsHover = false,
                DrugId = 1,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 2,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 1,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 3,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 1,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 4,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 1,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 5,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 1,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 2

            new DrugImage
            {
                Id = 6,
                ImagePath = "product-2.png",
                IsMain = true,
                IsHover = false,
                DrugId = 2,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 7,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 2,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 8,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 2,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 9,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 2,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 10,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 2,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 3

            new DrugImage
            {
                Id = 11,
                ImagePath = "product-3.png",
                IsMain = true,
                IsHover = false,
                DrugId = 3,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 12,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 3,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 13,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 3,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 14,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 3,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 15,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 3,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 4

            new DrugImage
            {
                Id = 16,
                ImagePath = "product-4.png",
                IsMain = true,
                IsHover = false,
                DrugId = 4,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 17,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 4,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 18,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 4,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 19,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 4,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 20,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 4,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 5

            new DrugImage
            {
                Id = 21,
                ImagePath = "product-5.png",
                IsMain = true,
                IsHover = false,
                DrugId = 5,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 22,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 5,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 23,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 5,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 24,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 5,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 25,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 5,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 6

            new DrugImage
            {
                Id = 26,
                ImagePath = "product-6.png",
                IsMain = true,
                IsHover = false,
                DrugId = 6,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 27,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 6,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 28,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 6,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 29,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 6,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 30,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 6,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 7

            new DrugImage
            {
                Id = 31,
                ImagePath = "product-7.png",
                IsMain = true,
                IsHover = false,
                DrugId = 7,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 32,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 7,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 33,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 7,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 34,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 7,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 35,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 7,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 8

            new DrugImage
            {
                Id = 36,
                ImagePath = "product-8.png",
                IsMain = true,
                IsHover = false,
                DrugId = 8,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 37,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 8,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 38,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 8,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 39,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 8,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 40,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 8,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 9

            new DrugImage
            {
                Id = 41,
                ImagePath = "product-9.png",
                IsMain = true,
                IsHover = false,
                DrugId = 9,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 42,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 9,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 43,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 9,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 44,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 9,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 45,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 9,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 10

            new DrugImage
            {
                Id = 46,
                ImagePath = "product-10.png",
                IsMain = true,
                IsHover = false,
                DrugId = 10,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 47,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 10,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 48,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 10,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 49,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 10,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 50,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 10,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 11

            new DrugImage
            {
                Id = 51,
                ImagePath = "product-11.png",
                IsMain = true,
                IsHover = false,
                DrugId = 11,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 52,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 11,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 53,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 11,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 54,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 11,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 55,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 11,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 12

            new DrugImage
            {
                Id = 56,
                ImagePath = "product-12.png",
                IsMain = true,
                IsHover = false,
                DrugId = 12,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 57,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 12,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 58,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 12,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 59,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 12,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 60,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 12,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 13

            new DrugImage
            {
                Id = 61,
                ImagePath = "product-13.png",
                IsMain = true,
                IsHover = false,
                DrugId = 13,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 62,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 13,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 63,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 13,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 64,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 13,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 65,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 13,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 14

            new DrugImage
            {
                Id = 66,
                ImagePath = "product-14.png",
                IsMain = true,
                IsHover = false,
                DrugId = 14,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 67,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 14,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 68,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 14,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 69,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 14,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 70,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 14,
                CreateAt = DateTime.Now
            },

            #endregion

            #region Drug 15

            new DrugImage
            {
                Id = 71,
                ImagePath = "product-15.png",
                IsMain = true,
                IsHover = false,
                DrugId = 15,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 72,
                ImagePath = "product-left-side.png",
                IsMain = false,
                IsHover = false,
                DrugId = 15,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 73,
                ImagePath = "product-right-side.png",
                IsMain = false,
                IsHover = true,
                DrugId = 15,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 74,
                ImagePath = "product-box.png",
                IsMain = false,
                IsHover = false,
                DrugId = 15,
                CreateAt = DateTime.Now
            },
            new DrugImage
            {
                Id = 75,
                ImagePath = "product-pill.png",
                IsMain = false,
                IsHover = false,
                DrugId = 15,
                CreateAt = DateTime.Now
            });

            #endregion

            #endregion

            #region Shipping Information

            modelBuilder.Entity<ShippingInformation>().HasData(
            new ShippingInformation
            {
                Id = 1,
                Title = "Shipping",
                Description = "The item will be shipped from Azerbaijan. So it need 35-50 days to deliver. Our product is good with reasonable price and we believe you will worth it. So please wait for it patiently! Thanks.Any question please kindly to contact us and we promise to work hard to help you to solve the problem",
                CreateAt = DateTime.Now
            },
            new ShippingInformation
            {
                Id = 2,
                Title = "About return request",
                Description = "If you don't need the drug, you can contact us then we will help you to solve the problem, so please close the return request! Thanks.",
                CreateAt = DateTime.Now
            },
            new ShippingInformation
            {
                Id = 3,
                Title = "Guarantee",
                Description = "If it is the quality question, we will resend or refund to you; If you receive damaged or wrong drug, please contact us and attach some pictures about product, we will exchange a new correct drug to you after the confirmation.",
                CreateAt = DateTime.Now
            });

            #endregion

            #endregion

            #region Roles

            modelBuilder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Member",
                NormalizedName = "MEMBER"
            },
            new IdentityRole
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Admin",
                NormalizedName = "ADMIN"
            });

            #endregion

            #region Setting

            modelBuilder.Entity<Setting>().HasData(
                new Setting
                {
                    Id = 1,
                    Key = "Logo",
                    Vaule = "logo-lumina.png",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 2,
                    Key = "Tel",
                    Vaule = "+994709070717",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 3,
                    Key = "Email",
                    Vaule = "luminahealth@gmail.com",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 4,
                    Key = "Name",
                    Vaule = "Lumina",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 5,
                    Key = "Adress",
                    Vaule = "A street somewhere, City",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 6,
                    Key = "WorkingHours",
                    Vaule = "Monday to Friday - 9am to 6pm",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 7,
                    Key = "Facebook",
                    Vaule = "https://www.facebook.com/",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 8,
                    Key = "Twitter",
                    Vaule = "https://twitter.com/",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 9,
                    Key = "Instagram",
                    Vaule = "https://www.instagram.com/",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 10,
                    Key = "Linkedin",
                    Vaule = "https://www.linkedin.com/",
                    CreateAt = DateTime.Now
                },
                new Setting
                {
                    Id = 11,
                    Key = "DrawerLogo",
                    Vaule = "drawer-logo.png",
                    CreateAt = DateTime.Now
                });

            #endregion

            #region Subsicribe

            modelBuilder.Entity<SubscribeSection>().HasData(
                new SubscribeSection
                {
                    Id = 1,
                    Title = "Sign Up for Our Newsletter",
                    ShortDescription = "Get health tips from our experts, news about ground-breaking research, feel-good moments and ways to get involved with us delivered right to your inbox.",
                    LongDescription = "Get health tips from our experts, news about ground-breaking research, feel-good moments and ways to get involved with us delivered right to your inbox. Don't miss out on valuable insights – sign up now and have a dose of inspiration delivered right to your inbox!",
                    CreateAt = DateTime.Now
                });

            #endregion

            modelBuilder.Entity<Availability>().HasData(
            new Availability
            {
                Id = 1,
                Time = "09:00 - 10:00",
                DoctorId = 1,
            },
            new Availability
            {
                Id = 2,
                Time = "10:00 - 11:00",
                DoctorId = 1,
            },
            new Availability
            {
                Id = 3,
                Time = "11:00 - 12:00",
                DoctorId = 1,
            },

            new Availability
            {
                Id = 4,
                Time = "09:00 - 10:00",
                DoctorId = 2,
            },
            new Availability
            {
                Id = 5,
                Time = "10:00 - 11:00",
                DoctorId = 2,
            },
            new Availability
            {
                Id = 6,
                Time = "11:00 - 12:00",
                DoctorId = 2,
            });

        }
    }
}
