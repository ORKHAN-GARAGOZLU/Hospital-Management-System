﻿// <auto-generated />
using System;
using Lumina_Hospital.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    [DbContext(typeof(LuminaHospitalDbContex))]
    [Migration("20231222141332_AddGalleryTable")]
    partial class AddGalleryTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Lumina_Hospital.Entities.AboutPage.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1780),
                            Description = "Welcome to Lumina Hospital, where expert care is always here for you. Our dedicated team provides personalized, compassionate care in a state-of-the-art facility. From routine check-ups to advanced procedures, we prioritize your well-being. With cutting-edge technology and a focus on innovation, we ensure accurate diagnoses and effective treatments. Compassion is at our core. Our skilled professionals build meaningful connections, fostering trust throughout your healthcare journey. We embrace innovation, staying ahead with the latest medical advancements. Specialized services across various disciplines cater to your unique health needs. At Lumina Hospital, your health is our mission. Experience the difference of expert care.",
                            ImagePath = "about-1.jpg",
                            IsDelete = false,
                            Title = "Expert care that's here for you"
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1782),
                            Description = "A beacon of excellence as a national leader in cutting-edge research. Our commitment to advancing medical knowledge sets us apart, driving innovation and improving patient outcomes. Our dedicated team of researchers, clinicians, and healthcare professionals collaborates on groundbreaking studies, pushing the boundaries of medical science. At the forefront of discovery, Lumina Hospital is proud to contribute to the latest advancements in healthcare. Our state-of-the-art research facilities, empower our experts to explore new frontiers in medicine. We actively engage in clinical trials, pioneering treatments that shape the future of healthcare. In addition to providing top-notch patient care. our institution is a hub for intellectual curiosity and scientific exploration.",
                            ImagePath = "about-2.jpg",
                            IsDelete = false,
                            Title = "A national leader in cutting-edge research"
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1783),
                            Description = "At Lumina Hospital, we are dedicated to transforming health care through innovation and a commitment to excellence. As a leading institution, we embrace a dynamic approach to healthcare that goes beyond traditional boundaries. Our multidisciplinary team of healthcare professionals is united in the pursuit of transforming the patient experience, focusing on personalized care and positive outcomes. Innovative technologies are at the core of our transformative journey. Lumina Hospital invests in state-of-the-art medical equipment and cutting-edge solutions to enhance diagnostic accuracy and treatment efficacy. From artificial intelligence applications to telemedicine advancements, we leverage the latest tools to provide accessible, efficient, and high-quality care.",
                            ImagePath = "about-3.jpg",
                            IsDelete = false,
                            Title = "Transforming health care"
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.AboutSection.AboutSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("TitleFirst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleTwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AboutSections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1659),
                            Description = "We are dedicated to delivering innovative care that bridges our expertise and your individual needs, so you can be your healthiest self.",
                            IsDelete = false,
                            TitleFirst = "We are rewriting healthcare, together",
                            TitleTwo = "Together, we’re making an impact and building a healthier, equitable, and thriving Lumina."
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.Departments.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1724),
                            Description = "Ophthalmology is a medical specialty dedicated to the health of the eyes. Ophthalmologists are highly trained physicians who diagnose and treat a wide range of eye conditions, from refractive errors like myopia and hyperopia to more complex issues such as glaucoma, cataracts, and retinal disorders. They use advanced diagnostic tools, including retinal imaging and visual field testing, and perform surgical procedures like LASIK for vision correction and cataract removal. Beyond addressing medical concerns, ophthalmologists also play a crucial role in enhancing the quality of life for individuals by preserving and improving their eyesight.",
                            ImagePath = "department-detail-Ophthalmology.jpg",
                            IsDelete = false,
                            Name = "Ophthalmology",
                            ShortDescription = "Eye health experts; diagnose and treat vision issues, perform eye surgeries for better ocular well-being."
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1726),
                            Description = "Neurology is the branch of medicine focused on the intricate network of the nervous system. Neurologists specialize in diagnosing and managing a diverse array of neurological disorders, encompassing conditions like epilepsy, multiple sclerosis, and Parkinson's disease. These specialists utilize advanced imaging technologies, such as magnetic resonance imaging (MRI) and electroencephalography (EEG), to study the brain's structure and function. Neurologists not only provide medical interventions but also work collaboratively with other healthcare professionals to enhance the overall well-being of patients dealing with complex neurological challenges.",
                            ImagePath = "department-detail-Neurology.jpg",
                            IsDelete = false,
                            Name = "Neurology",
                            ShortDescription = "Nervous system specialists; diagnose and treat epilepsy, strokes, and brain-related disorders."
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1728),
                            Description = "Radiology is a medical discipline integral to modern healthcare, utilizing various imaging techniques to visualize the internal structures of the body. Radiologists employ X-rays, computed tomography (CT) scans, magnetic resonance imaging (MRI), and other technologies to diagnose and monitor diseases. They play a critical role in guiding treatment decisions for conditions ranging from fractures to cancers. Radiology's continuous advancements contribute significantly to medical research, enabling a deeper understanding of anatomical structures and pathologies, ultimately leading to improved patient outcomes.",
                            ImagePath = "department-detail-Radiology.jpg",
                            IsDelete = false,
                            Name = "Radiology",
                            ShortDescription = "Imaging specialists; diagnose diseases using X-rays, CT scans, and MRIs, crucial for various medical fields."
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1732),
                            Description = "Dermatology, the study of skin, hair, and nails, encompasses a broad spectrum of medical and aesthetic concerns. Dermatologists diagnose and treat skin conditions such as acne, eczema, and psoriasis, as well as skin cancer. Additionally, they provide cosmetic dermatology services, including Botox injections and laser treatments. Dermatologists are at the forefront of skin cancer prevention, conducting regular screenings and promoting sun safety. Their expertise extends beyond medical interventions, emphasizing holistic skin health and personalized care.",
                            ImagePath = "department-detail-Dermatology.jpg",
                            IsDelete = false,
                            Name = "Dermatology",
                            ShortDescription = "Skin experts; treat infections, cancer, and provide cosmetic dermatology services."
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1734),
                            Description = "Haematology is the specialized field of medicine dedicated to the study and treatment of blood-related disorders. Hematologists investigate conditions such as anemia, leukemia, and clotting disorders. They employ diagnostic tools like blood tests and bone marrow examinations to determine the nature of blood disorders. Treatment modalities may include chemotherapy, blood transfusions, and stem cell transplants. Hematologists also contribute to research, advancing our understanding of blood diseases and developing innovative therapies to improve patient outcomes.",
                            ImagePath = "department-detail-Hematology.jpg",
                            IsDelete = false,
                            Name = "Haematology",
                            ShortDescription = "Blood disorder specialists; diagnose and treat anemia, leukemia, and clotting issues."
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1735),
                            Description = "Dentistry is a multifaceted medical specialty encompassing oral health and overall well-being. Dentists provide preventive care, including regular cleanings and oral examinations, to maintain optimal dental health. They diagnose and treat conditions such as cavities, gum disease, and oral infections. Dentistry also extends to restorative procedures like fillings, root canals, and extractions. Beyond clinical care, dentists emphasize patient education, promoting healthy oral hygiene practices to prevent dental issues and enhance overall quality of life.",
                            ImagePath = "department-detail-Dentistry.jpg",
                            IsDelete = false,
                            Name = "Dentistry",
                            ShortDescription = "Oral health care providers; offer preventive care, diagnose dental issues, perform surgeries."
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1737),
                            Description = "Orthopedic surgery specializes in the treatment of musculoskeletal conditions, addressing issues related to bones, joints, ligaments, and muscles. Orthopedic surgeons perform a range of procedures, including joint replacements, arthroscopic surgeries, and fracture repairs. These interventions aim to alleviate pain, restore function, and improve the overall quality of life for patients with orthopedic concerns. Orthopedic surgeons collaborate closely with rehabilitation professionals to ensure comprehensive care, emphasizing both surgical expertise and holistic patient recovery.",
                            ImagePath = "department-detail-Orthopedic-Surgery.jpg",
                            IsDelete = false,
                            Name = "Orthopedic Surgery",
                            ShortDescription = "Musculoskeletal surgeons; perform joint replacements, fracture repairs."
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1746),
                            Description = "Anesthesiology is a critical medical discipline responsible for ensuring patient comfort and safety during surgical and medical procedures. Anesthesiologists administer anesthesia, carefully monitoring vital signs and adjusting dosage to maintain an optimal balance between unconsciousness and physiological stability. Their expertise extends to pain management, pre-operative assessments, and post-operative care. Anesthesiologists play a pivotal role in surgical teams, contributing to the success of procedures and minimizing patient discomfort. Their commitment to precision and patient well-being is paramount in facilitating positive surgical outcomes.",
                            ImagePath = "department-detail-Anesthesiology.jpg",
                            IsDelete = false,
                            Name = "Anesthesiology",
                            ShortDescription = "Anesthesia specialists; ensure pain-free surgeries, monitor vital signs for safe procedures."
                        },
                        new
                        {
                            Id = 9,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1747),
                            Description = "Rheumatology focuses on the diagnosis and treatment of disorders affecting the joints, muscles, and connective tissues. Rheumatologists address conditions such as rheumatoid arthritis, lupus, and osteoarthritis. These specialists employ a comprehensive approach, utilizing medical history, physical examinations, and advanced imaging to formulate accurate diagnoses. Treatment plans may involve medication management, physical therapy, and lifestyle modifications. Rheumatologists also contribute to ongoing research, advancing our understanding of autoimmune and inflammatory conditions to optimize patient care and enhance long-term outcomes.",
                            ImagePath = "department-detail-Rheumatology.jpg",
                            IsDelete = false,
                            Name = "Rheumatology",
                            ShortDescription = "Joint and tissue disorder experts; diagnose and treat arthritis, autoimmune diseases."
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.DonateSection.DonateSection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DonateSections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1694),
                            Description = "Blood donation, a life-saving act transcending borders and cultures, share the gift of life.",
                            IsDelete = false,
                            Title = "Your gift holds great power donate today!"
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.Gallery.Gallery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Galleries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1904),
                            ImagePath = "gallery-1.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1906),
                            ImagePath = "gallery-2.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1907),
                            ImagePath = "gallery-3.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1908),
                            ImagePath = "gallery-4.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 5,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1909),
                            ImagePath = "gallery-5.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 6,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1910),
                            ImagePath = "gallery-6.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 7,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1911),
                            ImagePath = "gallery-7.jpg",
                            IsDelete = false
                        },
                        new
                        {
                            Id = 8,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1912),
                            ImagePath = "gallery-8.jpg",
                            IsDelete = false
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.Testimonial.PatientTestimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PatientTestimonials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Eleanor Foster expresses gratitude for the compassionate care and cutting-edge facilities at this healthcare leader, where a commitment to excellence defines every aspect of medical services.",
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1812),
                            ImagePath = "patient-testimonial-1.jpg",
                            IsDelete = false,
                            Name = "Eleanor Foster",
                            Position = "Patient"
                        },
                        new
                        {
                            Id = 2,
                            Content = "David Miller highly recommends this hospital for its top-notch medical services, emphasizing the institution's reputation for compassion and excellence in healthcare delivery.",
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1815),
                            ImagePath = "patient-testimonial-2.jpg",
                            IsDelete = false,
                            Name = "David Miller",
                            Position = "Patient"
                        },
                        new
                        {
                            Id = 3,
                            Content = "Sophie Bennett commends the hospital's exceptional care and expertise, highlighting a warm and welcoming patient environment that ensures a positive healthcare experience.",
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1822),
                            ImagePath = "patient-testimonial-3.jpg",
                            IsDelete = false,
                            Name = "Sophie Bennett",
                            Position = "Patient"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Jackson Chen shares appreciation for the efficient and friendly staff who provided unparalleled support, contributing to a positive and reassuring hospital experience.",
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1824),
                            ImagePath = "patient-testimonial-5.jpg",
                            IsDelete = false,
                            Name = "Jackson Chen",
                            Position = "Patient"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Olivia Ramirez praises the skillful professionals and welcoming atmosphere that define this patient-centered hospital, offering a healthcare setting that prioritizes individual needs and comfort.",
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1859),
                            ImagePath = "patient-testimonial-4.jpg",
                            IsDelete = false,
                            Name = "Olivia Ramirez",
                            Position = "Patient"
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.VideoSection.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("VideoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Videos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1367),
                            IsDelete = false,
                            VideoPath = "./assets/images/video/med.mp4"
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.VideoSection.VideoTitle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("VideoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VideoId");

                    b.ToTable("VideoTitles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1619),
                            IsDelete = false,
                            Title = "Your Trusted Destination",
                            VideoId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1621),
                            IsDelete = false,
                            Title = "Here for You and Your Health",
                            VideoId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1623),
                            IsDelete = false,
                            Title = "Good Living, Good Health",
                            VideoId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateAt = new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1624),
                            IsDelete = false,
                            Title = "We Care, Your Smile Matters",
                            VideoId = 1
                        });
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.VideoSection.VideoTitle", b =>
                {
                    b.HasOne("Lumina_Hospital.Entities.VideoSection.Video", "Video")
                        .WithMany("VideoTitles")
                        .HasForeignKey("VideoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Video");
                });

            modelBuilder.Entity("Lumina_Hospital.Entities.VideoSection.Video", b =>
                {
                    b.Navigation("VideoTitles");
                });
#pragma warning restore 612, 618
        }
    }
}
