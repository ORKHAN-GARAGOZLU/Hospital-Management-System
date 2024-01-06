using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddAvailabilityTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d21ff7-5534-4e47-9df3-b00788ba20a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c91f758c-94c9-483a-b324-82a06fab139d");

            migrationBuilder.AddColumn<string>(
                name: "AvailableTime",
                table: "Appointments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Availabilities_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5234));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5235));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5236));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "030545f2-8b6f-4dae-91fd-c98b52228f4e", "96dc4db2-389e-4a79-a31e-8e30c0bf719b", "Member", "MEMBER" },
                    { "3242c3ae-14b2-4644-b877-76a84a1816fa", "3a757b6b-9329-4c55-8147-56e37894627b", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DoctorId", "IsDelete", "Time", "UpdateAt" },
                values: new object[,]
                {
                    { 1, null, null, 1, false, "09:00 - 10:00", null },
                    { 2, null, null, 1, false, "10:00 - 11:00", null },
                    { 3, null, null, 1, false, "11:00 - 12:00", null },
                    { 4, null, null, 2, false, "09:00 - 10:00", null },
                    { 5, null, null, 2, false, "10:00 - 11:00", null },
                    { 6, null, null, 2, false, "11:00 - 12:00", null }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5481));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5630));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5170));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5172));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5177));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5178));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5589));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5591));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5598));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5602));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5605));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5606));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5608));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5609));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5515));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5524));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5531));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5710));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5711));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5715));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5719));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5724));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5727));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5739));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5744));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5755));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5764));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5767));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5768));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5769));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5770));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5776));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5778));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5780));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5781));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5783));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5784));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5787));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5792));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5793));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5351));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5303));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6160));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "SubscribeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5064));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5068));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(4651));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5441));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5443));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5446));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5412));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5385));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 20, 30, 45, 6, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_DoctorId",
                table: "Availabilities",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "030545f2-8b6f-4dae-91fd-c98b52228f4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3242c3ae-14b2-4644-b877-76a84a1816fa");

            migrationBuilder.DropColumn(
                name: "AvailableTime",
                table: "Appointments");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a5d21ff7-5534-4e47-9df3-b00788ba20a7", "d7a7522d-b6b3-4f85-91a1-b0dd3db90ea4", "Member", "MEMBER" },
                    { "c91f758c-94c9-483a-b324-82a06fab139d", "43774af4-6b4f-4953-a94a-56821524343a", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(538));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(594));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(764));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(765));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(768));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(769));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(771));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(772));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(780));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(782));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(784));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(786));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(321));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "SubscribeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 427, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(429));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 6, 13, 56, 43, 428, DateTimeKind.Local).AddTicks(352));
        }
    }
}
