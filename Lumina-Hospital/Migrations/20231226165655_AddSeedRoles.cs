using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddSeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2220));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "32178ff2-800a-4907-9d92-0bdd71941959", "14f8ce8d-3f71-4309-a22a-5ad72f6368fe", "Member", "MEMBER" },
                    { "8e9d2cd2-655b-4008-9cb9-f9700e3b7077", "c1d38d07-a6de-41f9-9ab8-33774a3d5ef5", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2301));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2552));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2568));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2577));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2581));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2725));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2734));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2788));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2617));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2362));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2367));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2345));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 20, 56, 54, 744, DateTimeKind.Local).AddTicks(2393));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32178ff2-800a-4907-9d92-0bdd71941959");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e9d2cd2-655b-4008-9cb9-f9700e3b7077");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7325));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7328));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8293));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8567));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7264));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7267));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7276));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7278));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7283));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8507));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8353));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8355));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8362));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8366));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8372));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8692));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8759));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8763));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8767));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8775));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8804));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8806));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8867));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8880));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8882));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7513));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7515));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7518));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7373));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(9048));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8244));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 26, 18, 7, 32, 323, DateTimeKind.Local).AddTicks(8138));
        }
    }
}
