using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddDepartmentsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "Description", "ImagePath", "IsDelete", "Name", "ShortDescription", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(269), null, "Ophthalmology is a medical specialty dedicated to the health of the eyes. Ophthalmologists are highly trained physicians who diagnose and treat a wide range of eye conditions, from refractive errors like myopia and hyperopia to more complex issues such as glaucoma, cataracts, and retinal disorders. They use advanced diagnostic tools, including retinal imaging and visual field testing, and perform surgical procedures like LASIK for vision correction and cataract removal. Beyond addressing medical concerns, ophthalmologists also play a crucial role in enhancing the quality of life for individuals by preserving and improving their eyesight.", "department-detail-Ophthalmology.jpg", false, "Ophthalmology", "Eye health experts; diagnose and treat vision issues, perform eye surgeries for better ocular well-being.", null },
                    { 2, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(271), null, "Neurology is the branch of medicine focused on the intricate network of the nervous system. Neurologists specialize in diagnosing and managing a diverse array of neurological disorders, encompassing conditions like epilepsy, multiple sclerosis, and Parkinson's disease. These specialists utilize advanced imaging technologies, such as magnetic resonance imaging (MRI) and electroencephalography (EEG), to study the brain's structure and function. Neurologists not only provide medical interventions but also work collaboratively with other healthcare professionals to enhance the overall well-being of patients dealing with complex neurological challenges.", "department-detail-Neurology.jpg", false, "Neurology", "Nervous system specialists; diagnose and treat epilepsy, strokes, and brain-related disorders.", null },
                    { 3, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(273), null, "Radiology is a medical discipline integral to modern healthcare, utilizing various imaging techniques to visualize the internal structures of the body. Radiologists employ X-rays, computed tomography (CT) scans, magnetic resonance imaging (MRI), and other technologies to diagnose and monitor diseases. They play a critical role in guiding treatment decisions for conditions ranging from fractures to cancers. Radiology's continuous advancements contribute significantly to medical research, enabling a deeper understanding of anatomical structures and pathologies, ultimately leading to improved patient outcomes.", "department-detail-Radiology.jpg", false, "Radiology", "Imaging specialists; diagnose diseases using X-rays, CT scans, and MRIs, crucial for various medical fields.", null },
                    { 4, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(275), null, "Dermatology, the study of skin, hair, and nails, encompasses a broad spectrum of medical and aesthetic concerns. Dermatologists diagnose and treat skin conditions such as acne, eczema, and psoriasis, as well as skin cancer. Additionally, they provide cosmetic dermatology services, including Botox injections and laser treatments. Dermatologists are at the forefront of skin cancer prevention, conducting regular screenings and promoting sun safety. Their expertise extends beyond medical interventions, emphasizing holistic skin health and personalized care.", "department-detail-Dermatology.jpg", false, "Dermatology", "Skin experts; treat infections, cancer, and provide cosmetic dermatology services.", null },
                    { 5, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(276), null, "Haematology is the specialized field of medicine dedicated to the study and treatment of blood-related disorders. Hematologists investigate conditions such as anemia, leukemia, and clotting disorders. They employ diagnostic tools like blood tests and bone marrow examinations to determine the nature of blood disorders. Treatment modalities may include chemotherapy, blood transfusions, and stem cell transplants. Hematologists also contribute to research, advancing our understanding of blood diseases and developing innovative therapies to improve patient outcomes.", "department-detail-Hematology.jpg", false, "Haematology", "Blood disorder specialists; diagnose and treat anemia, leukemia, and clotting issues.", null },
                    { 6, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(278), null, "Dentistry is a multifaceted medical specialty encompassing oral health and overall well-being. Dentists provide preventive care, including regular cleanings and oral examinations, to maintain optimal dental health. They diagnose and treat conditions such as cavities, gum disease, and oral infections. Dentistry also extends to restorative procedures like fillings, root canals, and extractions. Beyond clinical care, dentists emphasize patient education, promoting healthy oral hygiene practices to prevent dental issues and enhance overall quality of life.", "department-detail-Dentistry.jpg", false, "Dentistry", "Oral health care providers; offer preventive care, diagnose dental issues, perform surgeries.", null },
                    { 7, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(281), null, "Orthopedic surgery specializes in the treatment of musculoskeletal conditions, addressing issues related to bones, joints, ligaments, and muscles. Orthopedic surgeons perform a range of procedures, including joint replacements, arthroscopic surgeries, and fracture repairs. These interventions aim to alleviate pain, restore function, and improve the overall quality of life for patients with orthopedic concerns. Orthopedic surgeons collaborate closely with rehabilitation professionals to ensure comprehensive care, emphasizing both surgical expertise and holistic patient recovery.", "department-detail-Orthopedic-Surgery.jpg", false, "Orthopedic Surgery", "Musculoskeletal surgeons; perform joint replacements, fracture repairs.", null },
                    { 8, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(282), null, "Anesthesiology is a critical medical discipline responsible for ensuring patient comfort and safety during surgical and medical procedures. Anesthesiologists administer anesthesia, carefully monitoring vital signs and adjusting dosage to maintain an optimal balance between unconsciousness and physiological stability. Their expertise extends to pain management, pre-operative assessments, and post-operative care. Anesthesiologists play a pivotal role in surgical teams, contributing to the success of procedures and minimizing patient discomfort. Their commitment to precision and patient well-being is paramount in facilitating positive surgical outcomes.", "department-detail-Anesthesiology.jpg", false, "Anesthesiology", "Anesthesia specialists; ensure pain-free surgeries, monitor vital signs for safe procedures.", null },
                    { 9, new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(284), null, "Rheumatology focuses on the diagnosis and treatment of disorders affecting the joints, muscles, and connective tissues. Rheumatologists address conditions such as rheumatoid arthritis, lupus, and osteoarthritis. These specialists employ a comprehensive approach, utilizing medical history, physical examinations, and advanced imaging to formulate accurate diagnoses. Treatment plans may involve medication management, physical therapy, and lifestyle modifications. Rheumatologists also contribute to ongoing research, advancing our understanding of autoimmune and inflammatory conditions to optimize patient care and enhance long-term outcomes.", "department-detail-Rheumatology.jpg", false, "Rheumatology", "Joint and tissue disorder experts; diagnose and treat arthritis, autoimmune diseases.", null }
                });

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(20));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 17, 3, 48, 813, DateTimeKind.Local).AddTicks(1572));
        }
    }
}
