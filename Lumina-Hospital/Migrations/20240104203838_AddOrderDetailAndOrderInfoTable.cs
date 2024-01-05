using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddOrderDetailAndOrderInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e64c33a-4e50-47fd-ac73-123fbef48b3c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1ee9902-eefc-4e30-902a-858b16de1d9f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4a638c1-c927-4d84-b254-2ebf6e8f41d0");

            migrationBuilder.CreateTable(
                name: "OrderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderInfos_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductCount = table.Column<int>(type: "int", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    OrderInfoId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_OrderInfos_OrderInfoId",
                        column: x => x.OrderInfoId,
                        principalTable: "OrderInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c1bb570-299b-4227-9ab6-b0cb71814658", "f112c52a-0285-442f-871e-7d9fdbe93203", "Admin", "ADMIN" },
                    { "ed937d58-cf84-456f-8780-5421a25d2c27", "21405cfb-a31a-4fa8-84ff-791237fde965", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(334));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(159));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(412));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(466));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(754));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(756));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(757));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(759));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(642));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "SubscribeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(106));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 291, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(275));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 5, 0, 38, 37, 292, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderInfoId",
                table: "OrderDetails",
                column: "OrderInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderInfos_UserId",
                table: "OrderInfos",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "OrderInfos");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c1bb570-299b-4227-9ab6-b0cb71814658");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed937d58-cf84-456f-8780-5421a25d2c27");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e64c33a-4e50-47fd-ac73-123fbef48b3c", "b5022f15-b423-4e54-91ab-a6eacdc64438", "Operator", "OPERATOR" },
                    { "c1ee9902-eefc-4e30-902a-858b16de1d9f", "f1c5270f-5919-48ae-a29a-3c4df5a7cf63", "Admin", "ADMIN" },
                    { "f4a638c1-c927-4d84-b254-2ebf6e8f41d0", "cee454d5-99ae-4c87-8e7c-0dbb1aa42d00", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1171));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1391));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(917));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(920));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1347));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1192));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1194));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1195));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1198));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1204));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1207));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1208));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1218));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1519));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1571));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1584));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1585));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1588));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1589));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1592));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1593));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1596));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1597));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1611));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1613));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1415));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1418));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1419));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1422));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1423));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1424));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1426));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1074));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1918));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1920));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "SubscribeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(847));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(848));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(678));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1144));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1145));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1146));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1147));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1125));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1106));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 43, 29, 514, DateTimeKind.Local).AddTicks(1107));
        }
    }
}
