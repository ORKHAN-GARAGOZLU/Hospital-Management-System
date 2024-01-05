using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddSubsicribeSectionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "513659ba-43e6-44de-b0a7-2333153677f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "90f90eac-018a-4ae2-96be-ade4cccb940c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3fe34f2-324f-487b-a810-2fe68304a3ff");

            migrationBuilder.CreateTable(
                name: "SubscribeSections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribeSections", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "17d997e8-06c6-4cb2-8fe5-bd3ffb913cef", "52b017b4-acbf-42d8-bfea-9845f7dab087", "Admin", "ADMIN" },
                    { "2d9b5335-c8e1-452d-852c-bdae3206aa86", "587ac257-e46f-4cc3-b32d-e8f9388b94f0", "Member", "MEMBER" },
                    { "b7040bb8-0a4c-4145-ab5f-222e6042408c", "bc8c119e-0020-454e-8f42-900416de9a56", "Operator", "OPERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1162));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1389));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(979));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1355));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1298));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1302));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1304));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1308));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1316));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(906));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1505));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1507));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1509));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1511));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1514));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1517));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1523));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1527));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1528));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1530));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2384));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1411));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1412));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1466));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1468));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1474));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1481));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1060));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1032));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3152));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3153));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3155), "https://www.facebook.com/" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3155), "https://twitter.com/" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3156), "https://www.instagram.com/" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3157), "https://www.linkedin.com/" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.InsertData(
                table: "SubscribeSections",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "LongDescription", "ShortDescription", "Title", "UpdateAt" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(3189), null, false, "Get health tips from our experts, news about ground-breaking research, feel-good moments and ways to get involved with us delivered right to your inbox. Don't miss out on valuable insights – sign up now and have a dose of inspiration delivered right to your inbox!", "Get health tips from our experts, news about ground-breaking research, feel-good moments and ways to get involved with us delivered right to your inbox.", "Sign Up for Our Newsletter", null });

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(872));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1137));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1138));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1140));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1121));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1122));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1087));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 15, 41, 2, 825, DateTimeKind.Local).AddTicks(1097));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubscribeSections");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17d997e8-06c6-4cb2-8fe5-bd3ffb913cef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d9b5335-c8e1-452d-852c-bdae3206aa86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7040bb8-0a4c-4145-ab5f-222e6042408c");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4409));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "513659ba-43e6-44de-b0a7-2333153677f9", "94939eab-3736-4430-bd1a-d026816e3844", "Operator", "OPERATOR" },
                    { "90f90eac-018a-4ae2-96be-ade4cccb940c", "0e6466f7-4e72-406f-9ebf-d97e8637171e", "Member", "MEMBER" },
                    { "f3fe34f2-324f-487b-a810-2fe68304a3ff", "fffbf875-abe0-4db0-a109-e1d47a2798eb", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4926));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4366));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4367));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4368));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4371));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4806));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4842));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4859));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4861));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4723));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4756));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4761));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4765));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5094));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5095));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5099));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5121));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5137));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5138));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5161));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5162));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5165));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5167));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5175));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5271));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5275));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5279));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5280));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5282));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5285));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5287));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5290));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5011));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5015));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5017));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5019));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4437));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5678), "" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5679), "" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5681), "" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreateAt", "Vaule" },
                values: new object[] { new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5682), "" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5357));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5359));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4580));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4581));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4544));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4545));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4546));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4514));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4516));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4518));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(4522));
        }
    }
}
