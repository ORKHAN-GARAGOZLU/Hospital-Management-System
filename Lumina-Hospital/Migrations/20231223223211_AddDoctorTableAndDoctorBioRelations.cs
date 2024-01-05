using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddDoctorTableAndDoctorBioRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorBios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Faculty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CallNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<double>(type: "float", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorBios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoctorBios_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6386));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DepartmentId", "ImagePath", "IsDelete", "Name", "Position", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6453), null, 2, "doctor-1.jpg", false, "Dr. Nabiha Abdulkareem", "Neurologist", null },
                    { 2, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6455), null, 6, "doctor-2.jpg", false, "Dr. Benjamin Anderson", "Dermatologist", null },
                    { 3, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6457), null, 1, "doctor-3.jpg", false, "Dr. Emily Williams", "Ophthalmologist", null },
                    { 4, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6458), null, 1, "doctor-4.jpg", false, "Dr. Jonathan Taylor", "Ophthalmologist", null },
                    { 5, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6460), null, 3, "doctor-19.jpg", false, "Dr. Jackson Davis", "Radiologist", null },
                    { 6, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6461), null, 5, "doctor-6.jpg", false, "Dr. Sophia Roberts", "Haematologist", null },
                    { 7, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6462), null, 3, "doctor-7.jpg", false, "Dr. Samuel Wright", "Radiologist", null },
                    { 8, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6463), null, 1, "doctor-8.jpg", false, "Dr. Ethan Wilson", "Ophthalmologist", null },
                    { 9, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6464), null, 8, "doctor-9.jpg", false, "Dr. Caleb Baker", "Anesthesiologist", null },
                    { 10, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6465), null, 8, "doctor-10.jpg", false, "Dr. Wang Tao", "Anesthesiologist", null },
                    { 11, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6466), null, 6, "doctor-11.jpg", false, "Dr. Jackson Williams", "Dentist", null },
                    { 12, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6468), null, 2, "doctor-12.jpg", false, "Dr. Nicholas Hall", "Neurologist", null },
                    { 13, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6469), null, 7, "doctor-13.jpg", false, "Dr. Isabella Martinez", "Orthopedic-Surgery", null },
                    { 14, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6470), null, 2, "doctor-14.jpg", false, "Dr. Lucas Turner", "Neurologist", null },
                    { 15, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6471), null, 7, "doctor-15.jpg", false, "Dr. Victoria Brown", "Orthopedic-Surgery", null },
                    { 16, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6472), null, 9, "doctor-16.jpg", false, "Dr. Ava Lewis", "Rheumatologist", null },
                    { 17, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6473), null, 9, "doctor-17.jpg", false, "Dr. Benjamin Clark", "Rheumatologist", null },
                    { 18, new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6474), null, 5, "doctor-18.jpg", false, "Dr. Chen Jie", "Haematologist", null }
                });

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6260));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(5915));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.InsertData(
                table: "DoctorBios",
                columns: new[] { "Id", "CallNumber", "CreateAt", "Degree", "DeleteAt", "DoctorId", "Experience", "Faculty", "IsDelete", "Mail", "Salary", "Summary", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6500), "High degree", null, 1, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 2, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6502), "High degree", null, 2, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 3, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6503), "High degree", null, 3, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 4, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6505), "High degree", null, 4, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 5, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6507), "High degree", null, 5, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 6, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6508), "High degree", null, 6, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 7, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6510), "High degree", null, 7, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 8, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6511), "High degree", null, 8, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 9, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6513), "High degree", null, 9, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 10, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6514), "High degree", null, 10, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 11, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6516), "High degree", null, 11, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 12, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6517), "High degree", null, 12, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 13, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6519), "High degree", null, 13, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 14, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6521), "High degree", null, 14, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 15, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6522), "High degree", null, 15, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 16, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6524), "High degree", null, 16, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 17, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6525), "High degree", null, 17, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null },
                    { 18, "(+465)464-654-65461", new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6527), "High degree", null, 18, "Many years of experience", "The Faculty of University", false, "someone@gmail.com", 2500.0, "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Asperiores sint dolor ut provident, dolorum totam animi aperiam. Recusandae, modi reprehenderit quam omnis earum enim, ipsam explicabo iusto soluta alias accusamus. Iusto, esse placeat. Dignissimos non, nemo, architecto, iste maiores officiis eaque cumque possimus beatae libero unde quaerat fugiat totam neque tempore veniam placeat consectetur delectus explicabo quas perferendis odit. Consequatur nesciunt, voluptas autem fuga vero accusamus debitis vitae doloribus veniam, harum commodi eligendi delectus libero nam id aut aliquam. Eos perspiciatis fugit officia natus dolorum vitae eius cumque quibusdam, dolor maiores aspernatur deserunt ipsam molestiae iusto autem adipisci provident. Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum nesciunt illum nobis, recusandae consequuntur minima beatae, culpa voluptate sint quae eos vero minus doloribus est veritatis exercitationem sunt? Delectus, id deserunt tempore fuga saepe libero doloremque ab, explicabo praesentium asperiores magni odio fugit voluptatibus enim debitis voluptatem, nesciunt culpa officiis.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorBios_DoctorId",
                table: "DoctorBios",
                column: "DoctorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartmentId",
                table: "Doctors",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorBios");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8360));
        }
    }
}
