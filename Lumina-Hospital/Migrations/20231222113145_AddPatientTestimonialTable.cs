using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddPatientTestimonialTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientTestimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientTestimonials", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7385));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7488));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7503));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.InsertData(
                table: "PatientTestimonials",
                columns: new[] { "Id", "Content", "CreateAt", "DeleteAt", "ImagePath", "IsDelete", "Name", "Position", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Eleanor Foster expresses gratitude for the compassionate care and cutting-edge facilities at this healthcare leader, where a commitment to excellence defines every aspect of medical services.", new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7622), null, "patient-testimonial-1.jpg", false, "Eleanor Foster", "Patient", null },
                    { 2, "David Miller highly recommends this hospital for its top-notch medical services, emphasizing the institution's reputation for compassion and excellence in healthcare delivery.", new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7727), null, "patient-testimonial-2.jpg", false, "David Miller", "Patient", null },
                    { 3, "Sophie Bennett commends the hospital's exceptional care and expertise, highlighting a warm and welcoming patient environment that ensures a positive healthcare experience.", new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7734), null, "patient-testimonial-3.jpg", false, "Sophie Bennett", "Patient", null },
                    { 4, "Jackson Chen shares appreciation for the efficient and friendly staff who provided unparalleled support, contributing to a positive and reassuring hospital experience.", new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7736), null, "patient-testimonial-5.jpg", false, "Jackson Chen", "Patient", null },
                    { 5, "Olivia Ramirez praises the skillful professionals and welcoming atmosphere that define this patient-centered hospital, offering a healthcare setting that prioritizes individual needs and comfort.", new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7739), null, "patient-testimonial-4.jpg", false, "Olivia Ramirez", "Patient", null }
                });

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7333));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(6972));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientTestimonials");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1645));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1647));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1650));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1654));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1233));
        }
    }
}
