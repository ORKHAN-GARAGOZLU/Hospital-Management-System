using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddGalleryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "ImagePath", "IsDelete", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1904), null, "gallery-1.jpg", false, null },
                    { 2, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1906), null, "gallery-2.jpg", false, null },
                    { 3, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1907), null, "gallery-3.jpg", false, null },
                    { 4, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1908), null, "gallery-4.jpg", false, null },
                    { 5, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1909), null, "gallery-5.jpg", false, null },
                    { 6, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1910), null, "gallery-6.jpg", false, null },
                    { 7, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1911), null, "gallery-7.jpg", false, null },
                    { 8, new DateTime(2023, 12, 22, 18, 13, 31, 907, DateTimeKind.Local).AddTicks(1912), null, "gallery-8.jpg", false, null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Galleries");

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

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 15, 31, 45, 179, DateTimeKind.Local).AddTicks(7739));

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
    }
}
