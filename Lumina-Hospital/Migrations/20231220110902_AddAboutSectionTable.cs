using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddAboutSectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TitleTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSections", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AboutSections",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "Description", "IsDelete", "TitleFirst", "TitleTwo", "UpdateAt" },
                values: new object[] { 1, new DateTime(2023, 12, 20, 15, 9, 2, 42, DateTimeKind.Local).AddTicks(9956), null, "We are dedicated to delivering innovative care that bridges our expertise and your individual needs, so you can be your healthiest self.", false, "We are rewriting healthcare, together", "Together, we’re making an impact and building a healthier, equitable, and thriving Lumina.", null });

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 15, 9, 2, 42, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 15, 9, 2, 42, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 15, 9, 2, 42, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 20, 15, 9, 2, 42, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "VideoPath" },
                values: new object[] { new DateTime(2023, 12, 20, 15, 9, 2, 42, DateTimeKind.Local).AddTicks(9813), "./assets/images/video/med.mp4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutSections");

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateAt", "VideoPath" },
                values: new object[] { new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(511), "~/assets/images/video/med.mp4" });
        }
    }
}
