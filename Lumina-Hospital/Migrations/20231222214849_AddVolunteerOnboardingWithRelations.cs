using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddVolunteerOnboardingWithRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VolunteerOnboardings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerOnboardings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VolunteerOnboardingPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolunteerOnboardingId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VolunteerOnboardingPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VolunteerOnboardingPoints_VolunteerOnboardings_VolunteerOnboardingId",
                        column: x => x.VolunteerOnboardingId,
                        principalTable: "VolunteerOnboardings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.InsertData(
                table: "VolunteerOnboardings",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6582), null, false, "Diversity Is At Our Core", null },
                    { 2, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6583), null, false, "Interview", null },
                    { 3, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6584), null, false, "On-Boarding", null }
                });

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.InsertData(
                table: "VolunteerOnboardingPoints",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "Detail", "IsDelete", "UpdateAt", "VolunteerOnboardingId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6595), null, "Lumina Hospital is committed to creating and sustaining an inclusive workplace where employees and volunteers are valued and engaged, not in spite of, but because of, our differences – whether seen or unseen.", false, null, 1 },
                    { 2, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6596), null, "We believe that there is strength in diversity. Diversity enables the success of our mission; ensuring that we are a caring, open place to work and reflect the communities we serve.", false, null, 1 },
                    { 3, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6597), null, "Selected applicants will be notified of times for a phone interview. Phone interviews are generally about 20 minutes to confirm the information on your application and find out a little more about you and your interest in volunteering.", false, null, 2 },
                    { 4, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6598), null, "Applicants may then be brought in for an in-person interview with a Volunteer Services team member to determine placement in a volunteer role.", false, null, 2 },
                    { 5, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6599), null, "Prospective volunteers will be invited to a volunteer orientation once a volunteer placement has been confirmed.", false, null, 3 },
                    { 6, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6599), null, "Prior to orientation, prospective volunteers will need to have an in-person appointment with Luminas’s Occupational Health to review required immunizations and vaccinations. All volunteers must be fully vaccinated against COVID.", false, null, 3 },
                    { 7, new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6600), null, "After volunteer orientation and Occupational Health clearance, volunteers are then able to obtain their ID badge and begin volunteering.", false, null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VolunteerOnboardingPoints_VolunteerOnboardingId",
                table: "VolunteerOnboardingPoints",
                column: "VolunteerOnboardingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VolunteerOnboardingPoints");

            migrationBuilder.DropTable(
                name: "VolunteerOnboardings");

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

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8839));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 22, 21, 25, 46, 76, DateTimeKind.Local).AddTicks(8848));
        }
    }
}
