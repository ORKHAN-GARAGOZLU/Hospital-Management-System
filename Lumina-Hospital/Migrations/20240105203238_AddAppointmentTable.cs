using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddAppointmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c1bb570-299b-4227-9ab6-b0cb71814658");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed937d58-cf84-456f-8780-5421a25d2c27");

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8106));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a4ee4ad5-08ea-4447-9cee-129cca9a3dde", "035445c8-5c9a-4542-b272-539700507c9b", "Admin", "ADMIN" },
                    { "b12061f2-201a-4d73-9caa-aeefd0066f7c", "c2bd1272-44df-49ff-a2b9-a08e739b26f8", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8154));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8469));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8388));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8395));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8594));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8598));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8642));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8522));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8265));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8268));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8269));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8247));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "SubscribeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8337));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8339));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8321));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8322));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8294));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 0, 32, 37, 818, DateTimeKind.Local).AddTicks(8295));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4ee4ad5-08ea-4447-9cee-129cca9a3dde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b12061f2-201a-4d73-9caa-aeefd0066f7c");

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
        }
    }
}
