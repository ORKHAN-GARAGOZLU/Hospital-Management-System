using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddDonatersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32178ff2-800a-4907-9d92-0bdd71941959");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e9d2cd2-655b-4008-9cb9-f9700e3b7077");

            migrationBuilder.CreateTable(
                name: "Donates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastDonateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donates", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4242));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4310));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "974bcae7-3936-4672-8944-8af0ce50eed6", "e30099ef-6e61-4781-a450-0f3315e5a239", "Member", "MEMBER" },
                    { "adce1266-1eb1-4add-a877-e4c078227ef7", "e63602da-ec00-4368-8df3-aed71ee7aecc", "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4464));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4280));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4281));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4284));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4287));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4288));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4562));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4566));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4568));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4489));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4494));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4497));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4499));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4500));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4503));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4656));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4657));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4659));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4689));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4698));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4701));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4705));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4707));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4721));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4722));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4724));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4731));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4733));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4735));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4737));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4741));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4743));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4746));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4754));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4633));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4636));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4637));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4382));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4325));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4328));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4810));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4811));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4438));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4440));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4443));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4429));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4403));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4404));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 27, 17, 29, 4, 115, DateTimeKind.Local).AddTicks(4406));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donates");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "974bcae7-3936-4672-8944-8af0ce50eed6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "adce1266-1eb1-4add-a877-e4c078227ef7");

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
    }
}
