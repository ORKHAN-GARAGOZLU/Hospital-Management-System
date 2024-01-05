using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddProductCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "Name", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9024), null, false, "Depressants", null },
                    { 2, new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9025), null, false, "Stimulants", null },
                    { 3, new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9026), null, false, "Inhalants", null },
                    { 4, new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9026), null, false, "Hallucinogens", null },
                    { 5, new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9027), null, false, "Prescription Drugs", null }
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "VideoPath" },
                values: new object[] { new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8581), "med.mp4" });

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8829));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

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

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6500));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6503));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(6474));

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
                columns: new[] { "CreateAt", "VideoPath" },
                values: new object[] { new DateTime(2023, 12, 24, 2, 32, 10, 954, DateTimeKind.Local).AddTicks(5915), "./assets/images/video/med.mp4" });

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
        }
    }
}
