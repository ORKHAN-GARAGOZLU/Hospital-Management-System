using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddDrugTableWithRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drugs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InStock = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drugs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Drugs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Drugs",
                columns: new[] { "Id", "CategoryId", "CreateAt", "DeleteAt", "InStock", "IsDelete", "LongDescription", "Name", "Price", "ShortDescription", "UpdateAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2813), null, 20, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Therapexa", 40.149999999999999, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 2, 1, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2816), null, 25, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Vitalox", 50.450000000000003, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 3, 1, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2816), null, 55, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Nexacalm", 50.350000000000001, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 4, 2, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2817), null, 15, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Zephyramine", 30.350000000000001, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 5, 2, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2818), null, 25, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Healithium", 20.0, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 6, 2, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2819), null, 25, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Neurolynx", 20.850000000000001, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 7, 3, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2820), null, 35, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Revitazen", 45.0, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 8, 3, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2821), null, 10, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Serenitol", 45.0, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 9, 3, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2822), null, 10, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Medipulse", 45.5, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 10, 4, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2823), null, 20, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Tranquilix", 55.5, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 11, 4, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2824), null, 15, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Serenifly", 32.5, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 12, 4, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2825), null, 25, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "Paxilife", 35.0, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 13, 5, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2826), null, 15, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "NeuraZen", 45.549999999999997, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 14, 5, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2827), null, 15, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "ZeniCure", 45.549999999999997, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null },
                    { 15, 5, new DateTime(2023, 12, 25, 13, 41, 42, 333, DateTimeKind.Local).AddTicks(2828), null, 25, false, "Discover a breakthrough in healthcare with our cutting-edge medication. Crafted through extensive research and development, this innovative solution is designed to address a spectrum of health concerns. From alleviating discomfort to promoting overall wellness, our medication stands at the forefront of pharmaceutical advancement. What sets our product apart is its meticulously curated formula, drawing on the latest scientific insights. We prioritize not only symptom relief but also tackle the underlying causes of ailments. This holistic approach ensures a comprehensive impact on your health, fostering sustained well-being. We understand the importance of trust when it comes to your health. That's why our medication is manufactured with the highest quality standards, adhering to rigorous protocols. Each ingredient is carefully selected, and the production process is closely monitored to guarantee safety and efficacy. Take the first step toward a healthier, more vibrant life by integrating our medication into your wellness routine. Whether you're managing chronic conditions or seeking preventive care, our product is versatile and adaptable to your unique needs. It's time to reclaim control over your health and embrace a brighter, healthier future. Join the countless individuals who have experienced the positive effects of our medication. Empower yourself with a solution that goes beyond symptom suppression, offering a pathway to lasting vitality. Invest in your well-being today, because your health is worth it.", "EquiTranquil", 65.549999999999997, "Relieve symptoms with our advanced medication. Scientifically formulated for effective results, it targets the root cause. Trust in our commitment to your well-being. Take control and experience the relief you deserve. Your health, our priority.", null }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Drugs_CategoryId",
                table: "Drugs",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Drugs");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8711));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8771));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8918));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8920));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8968));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8969));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8974));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8978));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.UpdateData(
                table: "DoctorBios",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8798));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8801));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8785));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8892));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8895));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8896));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 25, 12, 12, 18, 477, DateTimeKind.Local).AddTicks(8829));
        }
    }
}
