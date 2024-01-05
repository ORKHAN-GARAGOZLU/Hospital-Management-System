using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddOperatorRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43d43c9c-7278-4752-988f-3d61e34ba23c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60b18762-0d62-4546-b56b-1eac5d980658");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(65));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fdb8bf3-5f4c-48de-a3f3-f0b38d497367", "2bc7cb40-e884-4846-8ed7-b349efcdef51", "Admin", "ADMIN" },
                    { "9bd3844c-77ad-4081-bf52-8d10d15c9da2", "e25e7b25-a863-4075-b051-ab86de4f0528", "Member", "MEMBER" },
                    { "c5badeab-b7ad-4cd5-bde6-091457819762", "70c3ebe0-9e2e-441d-9290-e84d215987dd", "Operator", "OPERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(207));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(213));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(315));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(331));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(273));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(281));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(462));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(86));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(89));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(90));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(91));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 255, DateTimeKind.Local).AddTicks(9765));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(186));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(189));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 29, 2, 9, 6, 256, DateTimeKind.Local).AddTicks(152));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fdb8bf3-5f4c-48de-a3f3-f0b38d497367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bd3844c-77ad-4081-bf52-8d10d15c9da2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5badeab-b7ad-4cd5-bde6-091457819762");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2373));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43d43c9c-7278-4752-988f-3d61e34ba23c", "50241388-ad4a-4c68-9efc-4ad74bc76fbb", "Admin", "ADMIN" },
                    { "60b18762-0d62-4546-b56b-1eac5d980658", "792b29c0-d489-4240-83f1-c8016c1a2c3a", "Member", "MEMBER" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2338));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2342));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2602));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2839));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2842));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2845));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2850));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2851));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2853));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2854));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2859));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2869));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2891));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2895));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2896));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2898));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2900));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2915));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2918));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2766));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 28, 13, 46, 34, 315, DateTimeKind.Local).AddTicks(2496));
        }
    }
}
