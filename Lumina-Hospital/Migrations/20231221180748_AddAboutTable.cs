using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddAboutTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.InsertData(
                table: "Abouts",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "Description", "ImagePath", "IsDelete", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1686), null, "Welcome to Lumina Hospital, where expert care is always here for you. Our dedicated team provides personalized, compassionate care in a state-of-the-art facility. From routine check-ups to advanced procedures, we prioritize your well-being. With cutting-edge technology and a focus on innovation, we ensure accurate diagnoses and effective treatments. Compassion is at our core. Our skilled professionals build meaningful connections, fostering trust throughout your healthcare journey. We embrace innovation, staying ahead with the latest medical advancements. Specialized services across various disciplines cater to your unique health needs. At Lumina Hospital, your health is our mission. Experience the difference of expert care.", "about-1.jpg", false, "Expert care that's here for you", null },
                    { 2, new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1688), null, "A beacon of excellence as a national leader in cutting-edge research. Our commitment to advancing medical knowledge sets us apart, driving innovation and improving patient outcomes. Our dedicated team of researchers, clinicians, and healthcare professionals collaborates on groundbreaking studies, pushing the boundaries of medical science. At the forefront of discovery, Lumina Hospital is proud to contribute to the latest advancements in healthcare. Our state-of-the-art research facilities, empower our experts to explore new frontiers in medicine. We actively engage in clinical trials, pioneering treatments that shape the future of healthcare. In addition to providing top-notch patient care. our institution is a hub for intellectual curiosity and scientific exploration.", "about-2.jpg", false, "A national leader in cutting-edge research", null },
                    { 3, new DateTime(2023, 12, 21, 22, 7, 48, 468, DateTimeKind.Local).AddTicks(1691), null, "At Lumina Hospital, we are dedicated to transforming health care through innovation and a commitment to excellence. As a leading institution, we embrace a dynamic approach to healthcare that goes beyond traditional boundaries. Our multidisciplinary team of healthcare professionals is united in the pursuit of transforming the patient experience, focusing on personalized care and positive outcomes. Innovative technologies are at the core of our transformative journey. Lumina Hospital invests in state-of-the-art medical equipment and cutting-edge solutions to enhance diagnostic accuracy and treatment efficacy. From artificial intelligence applications to telemedicine advancements, we leverage the latest tools to provide accessible, efficient, and high-quality care.", "about-3.jpg", false, "Transforming health care", null }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(227));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 21, 12, 0, 13, 870, DateTimeKind.Local).AddTicks(284));

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
    }
}
