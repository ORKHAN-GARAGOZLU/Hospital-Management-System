using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddDoctoAppointmentRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4ee4ad5-08ea-4447-9cee-129cca9a3dde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b12061f2-201a-4d73-9caa-aeefd0066f7c");

            migrationBuilder.AddColumn<int>(
                name: "DoctorId",
                table: "Appointments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Doctors_DoctorId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5d21ff7-5534-4e47-9df3-b00788ba20a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c91f758c-94c9-483a-b324-82a06fab139d");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Appointments");

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
    }
}
