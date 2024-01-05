using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddDrugImageTableAndRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DrugImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    IsHover = table.Column<bool>(type: "bit", nullable: false),
                    DrugId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrugImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DrugImages_Drugs_DrugId",
                        column: x => x.DrugId,
                        principalTable: "Drugs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6334));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6336));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6514));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6303));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6619));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6623));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6627));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6637));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6641));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6646));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6647));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6649));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6650));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6543));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6586));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.InsertData(
                table: "DrugImages",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DrugId", "ImagePath", "IsDelete", "IsHover", "IsMain", "UpdateAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6759), null, 1, "product-1.png", false, false, true, null },
                    { 2, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6760), null, 1, "product-left-side.png", false, true, false, null },
                    { 3, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6761), null, 1, "product-right-side.png", false, false, false, null },
                    { 4, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6762), null, 1, "product-box.png", false, false, false, null },
                    { 5, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6764), null, 1, "product-pill.png", false, false, false, null },
                    { 6, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6765), null, 2, "product-2.png", false, false, true, null },
                    { 7, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6766), null, 2, "product-left-side.png", false, true, false, null },
                    { 8, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6767), null, 2, "product-right-side.png", false, false, false, null },
                    { 9, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6768), null, 2, "product-box.png", false, false, false, null },
                    { 10, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6769), null, 2, "product-pill.png", false, false, false, null },
                    { 11, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6770), null, 3, "product-3.png", false, false, true, null },
                    { 12, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6771), null, 3, "product-left-side.png", false, true, false, null },
                    { 13, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6772), null, 3, "product-right-side.png", false, false, false, null },
                    { 14, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6773), null, 3, "product-box.png", false, false, false, null },
                    { 15, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6775), null, 3, "product-pill.png", false, false, false, null },
                    { 16, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6776), null, 4, "product-4.png", false, false, true, null },
                    { 17, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6778), null, 4, "product-left-side.png", false, true, false, null },
                    { 18, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6779), null, 4, "product-right-side.png", false, false, false, null },
                    { 19, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6780), null, 4, "product-box.png", false, false, false, null },
                    { 20, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6781), null, 4, "product-pill.png", false, false, false, null },
                    { 21, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6782), null, 5, "product-5.png", false, false, true, null },
                    { 22, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6783), null, 5, "product-left-side.png", false, true, false, null },
                    { 23, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6789), null, 5, "product-right-side.png", false, false, false, null }
                });

            migrationBuilder.InsertData(
                table: "DrugImages",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DrugId", "ImagePath", "IsDelete", "IsHover", "IsMain", "UpdateAt" },
                values: new object[,]
                {
                    { 24, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6790), null, 5, "product-box.png", false, false, false, null },
                    { 25, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6791), null, 5, "product-pill.png", false, false, false, null },
                    { 26, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6792), null, 6, "product-6.png", false, false, true, null },
                    { 27, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6793), null, 6, "product-left-side.png", false, true, false, null },
                    { 28, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6794), null, 6, "product-right-side.png", false, false, false, null },
                    { 29, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6795), null, 6, "product-box.png", false, false, false, null },
                    { 30, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6797), null, 6, "product-pill.png", false, false, false, null },
                    { 31, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6798), null, 7, "product-7.png", false, false, true, null },
                    { 32, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6800), null, 7, "product-left-side.png", false, true, false, null },
                    { 33, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6802), null, 7, "product-right-side.png", false, false, false, null },
                    { 34, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6803), null, 7, "product-box.png", false, false, false, null },
                    { 35, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6804), null, 7, "product-pill.png", false, false, false, null },
                    { 36, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6805), null, 8, "product-8.png", false, false, true, null },
                    { 37, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6806), null, 8, "product-left-side.png", false, false, false, null },
                    { 38, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6807), null, 8, "product-right-side.png", false, true, false, null },
                    { 39, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6808), null, 8, "product-box.png", false, false, false, null },
                    { 40, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6809), null, 8, "product-pill.png", false, false, false, null },
                    { 41, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6810), null, 9, "product-9.png", false, false, true, null },
                    { 42, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6811), null, 9, "product-left-side.png", false, false, false, null },
                    { 43, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6812), null, 9, "product-right-side.png", false, true, false, null },
                    { 44, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6813), null, 9, "product-box.png", false, false, false, null },
                    { 45, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6814), null, 9, "product-pill.png", false, false, false, null },
                    { 46, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6815), null, 10, "product-10.png", false, false, true, null },
                    { 47, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6819), null, 10, "product-left-side.png", false, false, false, null },
                    { 48, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6820), null, 10, "product-right-side.png", false, true, false, null },
                    { 49, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6821), null, 10, "product-box.png", false, false, false, null },
                    { 50, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6822), null, 10, "product-pill.png", false, false, false, null },
                    { 51, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6823), null, 11, "product-11.png", false, false, true, null },
                    { 52, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6824), null, 11, "product-left-side.png", false, false, false, null },
                    { 53, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6825), null, 11, "product-right-side.png", false, true, false, null },
                    { 54, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6826), null, 11, "product-box.png", false, false, false, null },
                    { 55, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6827), null, 11, "product-pill.png", false, false, false, null },
                    { 56, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6828), null, 12, "product-12.png", false, false, true, null },
                    { 57, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6829), null, 12, "product-left-side.png", false, false, false, null },
                    { 58, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6830), null, 12, "product-right-side.png", false, true, false, null },
                    { 59, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6831), null, 12, "product-box.png", false, false, false, null },
                    { 60, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6832), null, 12, "product-pill.png", false, false, false, null },
                    { 61, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6833), null, 13, "product-13.png", false, false, true, null },
                    { 62, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6834), null, 13, "product-left-side.png", false, false, false, null },
                    { 63, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6837), null, 13, "product-right-side.png", false, true, false, null },
                    { 64, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6838), null, 13, "product-box.png", false, false, false, null },
                    { 65, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6839), null, 13, "product-pill.png", false, false, false, null }
                });

            migrationBuilder.InsertData(
                table: "DrugImages",
                columns: new[] { "Id", "CreateAt", "DeleteAt", "DrugId", "ImagePath", "IsDelete", "IsHover", "IsMain", "UpdateAt" },
                values: new object[,]
                {
                    { 66, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6842), null, 14, "product-14.png", false, false, true, null },
                    { 67, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6843), null, 14, "product-left-side.png", false, false, false, null },
                    { 68, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6844), null, 14, "product-right-side.png", false, true, false, null },
                    { 69, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6884), null, 14, "product-box.png", false, false, false, null },
                    { 70, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6885), null, 14, "product-pill.png", false, false, false, null },
                    { 71, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6886), null, 15, "product-15.png", false, false, true, null },
                    { 72, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6887), null, 15, "product-left-side.png", false, false, false, null },
                    { 73, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6888), null, 15, "product-right-side.png", false, true, false, null },
                    { 74, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6889), null, 15, "product-box.png", false, false, false, null },
                    { 75, new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6890), null, 15, "product-pill.png", false, false, false, null }
                });

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6690));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6696));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6735));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6738));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6395));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6364));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(5917));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6477));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6481));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6482));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 14, 21, 17, 120, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.CreateIndex(
                name: "IX_DrugImages_DrugId",
                table: "DrugImages",
                column: "DrugId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrugImages");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2800));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2690));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2824));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2826));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Drugs",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2606));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2607));
        }
    }
}
