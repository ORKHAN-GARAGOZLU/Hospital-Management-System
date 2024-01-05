using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddVolunteersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Volunteers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Testimonial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Volunteers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.InsertData(
                table: "Volunteers",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "ImagePath", "IsDelete", "Name", "Position", "Testimonial", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8839), null, "volunteer-1.jpg", false, "JASMINE THOMPSON", "Volunteer", "Hospital is a remarkable hospital that provides excellent medical care and service. The hospital is very clean, modern, and comfortable. The staff are very kind, attentive, and caring. The doctors are very skilled, knowledgeable, and reliable. They made me feel comfortable and confident and gave me the best treatment possible. I am very thankful to Lumina Hospital and I would gladly go back to them if I need to.", null },
                    { 2, new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8841), null, "volunteer-2.jpg", false, "GRACE MARTINEZ", "Volunteer", "I had a great experience at Lumina Hospital. The staff were friendly, professional, and attentive. The facilities were clean, modern, and comfortable. The doctors were knowledgeable, caring, and skilled. I received the best treatment possible and I am very satisfied with the outcome. I would highly recommend Lumina Hospital to anyone who needs medical care.", null },
                    { 3, new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8843), null, "volunteer-3.jpg", false, "HENRY EVANS", "Volunteer", "Lumina Hospital is the best hospital I have ever been to. The quality of care is outstanding, the prices are reasonable, and the service is excellent. The hospital has a wide range of specialties and equipment, and the doctors are experts in their fields. I felt safe, respected, and well-informed throughout my stay. I am very grateful to Lumina Hospital for saving my life.", null },
                    { 4, new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8845), null, "volunteer-4.jpg", false, "ISAAC TAYLOR", "Volunteer", "Lumina Hospital is a wonderful hospital that offers high-quality medical care and service. The hospital is very spacious, bright, and cozy. The staff are very courteous, polite, and cheerful. The doctors are very qualified, dedicated, and respectful. They listened to my concerns and gave me the best advice and treatment. I am very impressed by Lumina Hospital and I would highly praise them to anyone.", null },
                    { 5, new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8846), null, "volunteer-5.jpg", false, "HANNAH REED", "Volunteer", "The hospital is very neat, elegant, and relaxing. The staff are very warm, friendly, and supportive. The doctors are very professional, competent, and honest. They treated me with dignity and respect and gave me the best care possible. I am very pleased with Lumina Hospital and I would strongly recommend them to anyone.", null },
                    { 6, new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8848), null, "volunteer-6.jpg", false, "SEBASTIAN ROSS", "Volunteer", "I can’t thank Lumina Hospital enough for the amazing care they provided to me and my family. The hospital is very clean, organized, and efficient. The staff are very friendly, helpful, and compassionate. The doctors are very experienced, confident, and trustworthy. They explained everything clearly and answered all my questions. I am very happy with the results and I would definitely choose Lumina Hospital again.", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Volunteers");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1780));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1746));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1812));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1367));
        }
    }
}
