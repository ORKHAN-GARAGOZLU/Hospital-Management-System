using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddAppointmentWithRelations : Migration
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
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Day = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConfirm = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DoctorId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4778));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4849));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4851));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9ed3bad-2b39-4df3-9ff9-7091c215ce85", "e886a546-03b7-44bf-835a-d8c5786491d7", "Member", "MEMBER" },
                    { "b3b46f3f-d128-4b0e-813a-dea4a2e718e3", "e0e5760f-ac9e-4acb-a9d5-8b63552f47b0", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DoctorId", "IsDelete", "Time", "UpdateAt" },
                values: new object[,]
                {
                    { 1, null, null, 1, false, "09:00 - 10:00", null },
                    { 2, null, null, 1, false, "10:00 - 11:00", null },
                    { 3, null, null, 1, false, "11:00 - 12:00", null },
                    { 4, null, null, 1, false, "12:00 - 13:00", null },
                    { 5, null, null, 1, false, "13:00 - 14:00", null },
                    { 6, null, null, 1, false, "14:00 - 15:00", null },
                    { 7, null, null, 1, false, "15:00 - 16:00", null },
                    { 8, null, null, 1, false, "16:00 - 17:00", null },
                    { 9, null, null, 1, false, "17:00 - 18:00", null },
                    { 10, null, null, 2, false, "09:00 - 10:00", null },
                    { 11, null, null, 2, false, "10:00 - 11:00", null },
                    { 12, null, null, 2, false, "11:00 - 12:00", null },
                    { 13, null, null, 2, false, "12:00 - 13:00", null },
                    { 14, null, null, 2, false, "13:00 - 14:00", null },
                    { 15, null, null, 2, false, "14:00 - 15:00", null },
                    { 16, null, null, 2, false, "15:00 - 16:00", null },
                    { 17, null, null, 2, false, "16:00 - 17:00", null },
                    { 18, null, null, 2, false, "17:00 - 18:00", null },
                    { 19, null, null, 3, false, "09:00 - 10:00", null },
                    { 20, null, null, 3, false, "10:00 - 11:00", null },
                    { 21, null, null, 3, false, "11:00 - 12:00", null },
                    { 22, null, null, 3, false, "12:00 - 13:00", null },
                    { 23, null, null, 3, false, "13:00 - 14:00", null },
                    { 24, null, null, 3, false, "14:00 - 15:00", null },
                    { 25, null, null, 3, false, "15:00 - 16:00", null },
                    { 26, null, null, 3, false, "16:00 - 17:00", null },
                    { 27, null, null, 3, false, "17:00 - 18:00", null },
                    { 28, null, null, 4, false, "09:00 - 10:00", null },
                    { 29, null, null, 4, false, "10:00 - 11:00", null },
                    { 30, null, null, 4, false, "11:00 - 12:00", null },
                    { 31, null, null, 4, false, "12:00 - 13:00", null },
                    { 32, null, null, 4, false, "13:00 - 14:00", null },
                    { 33, null, null, 4, false, "14:00 - 15:00", null },
                    { 34, null, null, 4, false, "15:00 - 16:00", null },
                    { 35, null, null, 4, false, "16:00 - 17:00", null },
                    { 36, null, null, 4, false, "17:00 - 18:00", null }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DoctorId", "IsDelete", "Time", "UpdateAt" },
                values: new object[,]
                {
                    { 37, null, null, 5, false, "09:00 - 10:00", null },
                    { 38, null, null, 5, false, "10:00 - 11:00", null },
                    { 39, null, null, 5, false, "11:00 - 12:00", null },
                    { 40, null, null, 5, false, "12:00 - 13:00", null },
                    { 41, null, null, 5, false, "13:00 - 14:00", null },
                    { 42, null, null, 5, false, "14:00 - 15:00", null },
                    { 43, null, null, 5, false, "15:00 - 16:00", null },
                    { 44, null, null, 5, false, "16:00 - 17:00", null },
                    { 45, null, null, 5, false, "17:00 - 18:00", null },
                    { 46, null, null, 6, false, "09:00 - 10:00", null },
                    { 47, null, null, 6, false, "10:00 - 11:00", null },
                    { 48, null, null, 6, false, "11:00 - 12:00", null },
                    { 49, null, null, 6, false, "12:00 - 13:00", null },
                    { 50, null, null, 6, false, "13:00 - 14:00", null },
                    { 51, null, null, 6, false, "14:00 - 15:00", null },
                    { 52, null, null, 6, false, "15:00 - 16:00", null },
                    { 53, null, null, 6, false, "16:00 - 17:00", null },
                    { 54, null, null, 6, false, "17:00 - 18:00", null },
                    { 55, null, null, 7, false, "09:00 - 10:00", null },
                    { 56, null, null, 7, false, "10:00 - 11:00", null },
                    { 57, null, null, 7, false, "11:00 - 12:00", null },
                    { 58, null, null, 7, false, "12:00 - 13:00", null },
                    { 59, null, null, 8, false, "13:00 - 14:00", null },
                    { 60, null, null, 8, false, "14:00 - 15:00", null },
                    { 61, null, null, 8, false, "15:00 - 16:00", null },
                    { 62, null, null, 8, false, "16:00 - 17:00", null },
                    { 63, null, null, 8, false, "17:00 - 18:00", null },
                    { 64, null, null, 9, false, "09:00 - 10:00", null },
                    { 65, null, null, 9, false, "10:00 - 11:00", null },
                    { 66, null, null, 9, false, "11:00 - 12:00", null },
                    { 67, null, null, 9, false, "12:00 - 13:00", null },
                    { 68, null, null, 10, false, "13:00 - 14:00", null },
                    { 69, null, null, 10, false, "14:00 - 15:00", null },
                    { 70, null, null, 10, false, "15:00 - 16:00", null },
                    { 71, null, null, 10, false, "16:00 - 17:00", null },
                    { 72, null, null, 10, false, "17:00 - 18:00", null },
                    { 73, null, null, 11, false, "09:00 - 10:00", null },
                    { 74, null, null, 11, false, "10:00 - 11:00", null },
                    { 75, null, null, 11, false, "11:00 - 12:00", null },
                    { 76, null, null, 11, false, "12:00 - 13:00", null },
                    { 77, null, null, 12, false, "13:00 - 14:00", null },
                    { 78, null, null, 12, false, "14:00 - 15:00", null }
                });

            migrationBuilder.InsertData(
                table: "Availabilities",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DoctorId", "IsDelete", "Time", "UpdateAt" },
                values: new object[,]
                {
                    { 79, null, null, 12, false, "15:00 - 16:00", null },
                    { 80, null, null, 13, false, "16:00 - 17:00", null },
                    { 81, null, null, 13, false, "17:00 - 18:00", null },
                    { 82, null, null, 14, false, "09:00 - 10:00", null },
                    { 83, null, null, 14, false, "10:00 - 11:00", null },
                    { 84, null, null, 15, false, "11:00 - 12:00", null },
                    { 85, null, null, 15, false, "12:00 - 13:00", null },
                    { 86, null, null, 15, false, "13:00 - 14:00", null },
                    { 87, null, null, 16, false, "14:00 - 15:00", null },
                    { 88, null, null, 16, false, "15:00 - 16:00", null },
                    { 89, null, null, 17, false, "10:00 - 11:00", null },
                    { 90, null, null, 17, false, "11:00 - 12:00", null },
                    { 91, null, null, 18, false, "09:00 - 10:00", null },
                    { 92, null, null, 18, false, "10:00 - 11:00", null },
                    { 93, null, null, 18, false, "11:00 - 12:00", null },
                    { 94, null, null, 18, false, "12:00 - 13:00", null }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5182));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5183));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4825));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4826));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4827));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4830));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5108));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5115));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5118));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5154));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5158));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4803));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5246));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5247));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5255));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5257));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5261));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5263));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5265));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5268));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5314));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5315));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5316));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5322));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5324));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5325));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5327));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5330));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5331));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5340));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5343));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5344));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5345));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5347));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5348));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5353));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5205));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5207));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5209));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5210));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5215));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4911));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4912));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4879));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4882));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5534));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5535));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5549));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "SubscribeSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4582));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5026));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4933));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4934));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2024, 1, 7, 15, 27, 40, 657, DateTimeKind.Local).AddTicks(4936));

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Availabilities_DoctorId",
                table: "Availabilities",
                column: "DoctorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9ed3bad-2b39-4df3-9ff9-7091c215ce85");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3b46f3f-d128-4b0e-813a-dea4a2e718e3");

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
