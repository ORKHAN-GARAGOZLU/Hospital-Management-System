using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20786d89-4bfe-47d3-acc2-d4a697e309bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "538a7d7a-75eb-4798-abac-89ff4e8e034a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aebcd0a5-6e38-454e-abc1-379772275347");

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vaule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "Key", "UpdateAt", "Vaule" },
                values: new object[] { 1, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5668), null, false, "Logo", null, "logo-lumina.png" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "IsDelete", "Key", "UpdateAt", "Vaule" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5670), null, false, "Tel", null, "+994709070717" },
                    { 3, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5672), null, false, "Email", null, "luminahealth@gmail.com" },
                    { 4, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5673), null, false, "Name", null, "Lumina" },
                    { 5, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5675), null, false, "Adress", null, "A street somewhere, City" },
                    { 6, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5676), null, false, "WorkingHours", null, "Monday to Friday - 9am to 6pm" },
                    { 7, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5678), null, false, "Facebook", null, "" },
                    { 8, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5679), null, false, "Twitter", null, "" },
                    { 9, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5681), null, false, "Instagram", null, "" },
                    { 10, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5682), null, false, "Linkedin", null, "" },
                    { 11, new DateTime(2023, 12, 31, 12, 25, 27, 279, DateTimeKind.Local).AddTicks(5683), null, false, "DrawerLogo", null, "drawer-logo.png" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

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

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "20786d89-4bfe-47d3-acc2-d4a697e309bd", "0c5323f3-e1a2-4261-9d47-b04b439a3172", "Member", "MEMBER" },
                    { "538a7d7a-75eb-4798-abac-89ff4e8e034a", "80916433-a15a-496f-a7a9-a725c7816c4b", "Admin", "ADMIN" },
                    { "aebcd0a5-6e38-454e-abc1-379772275347", "8234a437-c034-42c9-8d90-4421d4fd3c83", "Operator", "OPERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5971));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5972));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5975));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5976));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6118));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6128));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6076));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6080));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6082));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6086));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6089));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6090));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6322));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6326));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6329));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6331));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6335));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6341));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6358));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6407));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6409));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6245));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5853));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5854));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5819));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5821));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5822));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5823));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5825));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5615));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5938));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5939));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5942));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5911));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5914));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5887));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 13, 26, 25, 671, DateTimeKind.Local).AddTicks(5890));
        }
    }
}
