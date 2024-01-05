using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddVideoAndVideoTitleTableWithRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Videos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoTitles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VideoTitles_Videos_VideoId",
                        column: x => x.VideoId,
                        principalTable: "Videos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Videos",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "UpdateAt", "VideoPath" },
                values: new object[] { 1, new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(511), null, false, null, "~/assets/images/video/med.mp4" });

            migrationBuilder.InsertData(
                table: "VideoTitles",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "Title", "UpdateAt", "VideoId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(743), null, false, "Your Trusted Destination", null, 1 },
                    { 2, new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(745), null, false, "Here for You and Your Health", null, 1 },
                    { 3, new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(746), null, false, "Good Living, Good Health", null, 1 },
                    { 4, new DateTime(2023, 12, 19, 14, 47, 59, 185, DateTimeKind.Local).AddTicks(748), null, false, "We Care, Your Smile Matters", null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VideoTitles_VideoId",
                table: "VideoTitles",
                column: "VideoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VideoTitles");

            migrationBuilder.DropTable(
                name: "Videos");
        }
    }
}
