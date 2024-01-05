using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddBlogCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(376));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "485f2630-f4c4-44f1-89d1-2d3d346c2047", "98e06a33-2da1-4fbb-9ca0-d2e7ad5dc7b0", "Member", "MEMBER" },
                    { "a26a79d5-133a-44b7-a5f3-0bbca7a7e10c", "bba9bae0-c90c-46f8-a213-880fc49bb428", "Admin", "ADMIN" },
                    { "ddeb5afe-c0c4-4519-9e9a-138d634c93b6", "09ff0e12-9e6d-4046-a602-990ccb25cec5", "Operator", "OPERATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(684));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(342));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(347));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(653));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(658));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(792));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(805));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(830));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 70,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 71,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 72,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 73,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 74,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "DrugImages",
                keyColumn: "Id",
                keyValue: 75,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(717));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(721));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(724));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(391));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "ShippingInformations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(283));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(470));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 30, 4, 16, 11, 567, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogId",
                table: "BlogComments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_UserId",
                table: "BlogComments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "485f2630-f4c4-44f1-89d1-2d3d346c2047");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a26a79d5-133a-44b7-a5f3-0bbca7a7e10c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ddeb5afe-c0c4-4519-9e9a-138d634c93b6");

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
    }
}
