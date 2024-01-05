using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lumina_Hospital.Migrations
{
    public partial class AddBlogTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "CreateAt", "DeleteAt", "Description", "ImagePath", "IsDelete", "Title", "UpdateAt" },
                values: new object[,]
                {
                    { 1, "Dr. Nabiha Abdulkareem", new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8404), null, "Before moving to the steps to manage migraine pain, we need to first understand what migraine is. Migraine is a common neurological issue that typically manifests as an intense headache coupled with symptoms such as nausea, vomiting, or an increased sensitivity to light and sound. It’s essential to note that the specific symptoms can vary based on the type of migraine the patient has. This condition is caused due to a complex interplay of genetic factors. It is often triggered by certain biological and environmental influences. The triggers that cause for a migraine attack to occur may be unique to each individual and can comprise various stimuli, such as specific food components, odours, or hormonal fluctuations. An episode of the pain caused by a migraine is referred to as a ‘migraine attack’. It is an episode of intense pain, caused due to different triggers. A combination of medicine, along with behavioural measures and lifestyle changes, can be a highly effective way to deal with migraines and even prevent migraine attacks in the future.", "blog-2.jpg", false, "Migraines: Simple Steps to Head Off the Pain", null },
                    { 2, "Dr. Benjamin Anderson", new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8405), null, "Sports have always been important in encouraging people to be physically active, mentally healthy, and socially connected. Whether you’re a professional athlete or simply someone who enjoys an active lifestyle, sports injuries can be a significant setback. The term “sports injury” describes the many types of injuries that are often sustained when engaging in sports or exercising; however, they are not exclusive to athletes. Sports-related injuries tend to occur due to overuse, direct collisions, or the application of force that exceeds the body’s structural capacity. The good news is that many sports injuries can be prevented with the right precautions and strategies. Strains and sprains are among the most common sports injuries. A strain refers to the stretching or tearing of muscles or tendons, while a sprain involves ligament damage. These injuries can occur in various sports, from basketball to football, and even in everyday activities like lifting heavy objects. To prevent strains and sprains, it’s essential to maintain flexibility through regular stretching exercises.", "blog-1.jpg", false, "Common Sports Injuries and How to Avoid Them", null },
                    { 3, "Dr. Lucas Turner", new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8406), null, "Rheumatoid Arthritis (RA) is a complex and debilitating autoimmune disease that affects millions of people worldwide. The main characteristic of rheumatoid arthritis is the body’s immune system accidentally attacking healthy cells, leading to inflammation (painful swelling) in the areas of the body affected. This chronic inflammatory condition can result in severe joint damage, pain, and decreased quality of life for those who suffer from it. Hand, wrist, and knee joints are often affected by RA. Chronic or long-lasting discomfort, instability (loss of balance), and deformity can all result from this tissue injury. In addition to these tissues, RA can harm other organs, including the heart, lungs, and eyes as well as other tissues all over the body. While there is no known cure for rheumatoid arthritis, early diagnosis and effective treatment can significantly improve the lives of affected individuals. Rheumatoid arthritis is a complex autoimmune disease that affects many aspects of a person’s life. Early diagnosis and appropriate treatment can significantly improve the quality of life for those living with this condition.", "blog-3.jpg", false, "Rheumatoid Arthritis: Symptoms, Diagnosis, and Treatment", null },
                    { 4, "Dr. Nicholas Hall", new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8407), null, "Catching dementia early and promptly starting treatment can significantly slow its progression, helping preserve cognitive abilities longer. Witnessing a loved one’s mental decline is undoubtedly difficult, but the early and middle stages still present opportunities for better outcomes through patience and compassion. In this article, we’ll explore subtle signs of dementia to monitor and when it’s time to seek medical evaluation. An early diagnosis enables critical treatments to help your loved one retain more of the qualities that make them who they are. As dementia progresses, spatial orientation and directional sense often decline. Your once very independent loved one may have always navigated their own neighbourhood flawlessly. But now when you take them out, they become disoriented and fail to recognise familiar landmarks and street names. Even short walks from their home to the car leave them turned around and confused.", "blog-4.jpg", false, "Dementia & Alzheimer’s – 10 Early Signs and Symptoms", null },
                    { 5, "Dr. Sophia Roberts", new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8408), null, "Low blood pressure, often known as hypotension, is defined as a blood pressure measurement less than 90/60 mm Hg. This medical condition affects a large number of individuals, especially as they get older. Low blood pressure can be triggered by a number of causes, including adverse reactions to medications and medical conditions such as diabetes. If there are no symptoms, low blood pressure is not worrisome. Most medical professionals will only identify low blood pressure as a cause for concern if a patient exhibits its symptoms, such as blurred vision, dizziness, and fainting. Low blood pressure can lead to a heart attack or stroke, both of which might be fatal or result in long-term harm to the brain and heart. If anyone experiences concerns about low blood pressure symptoms, they should consult their doctor. Likewise, medical professionals can assess the adverse effects of medications and make changes as necessary.", "blog-5.jpg", false, "Raise Low Blood Pressure Naturally Through Diet", null },
                    { 6, "Dr. Ava Lewis", new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8408), null, "With the increase in old age, people experience joint injuries which are due to conditions like arthritis, fractures, and joint abnormalities. These conditions might cause hindrances in the quality of life of the patient. Thus, doctors suggest and perform joint replacement surgery. Metals, ceramics, or robust plastics can be used to make the artificial joint (prosthesis). The artificial joint behaves similarly to the native joint and has a comparable appearance. Any joint in the body can be replaced by a surgeon; however, hip replacement and knee replacement are the two most popular joint replacement procedures. Living with chronic pain can significantly influence a patient’s life negatively. Joint replacement surgery notably enhances the quality of life by reducing pain, aiding in proper sleep, and fostering a positive sense of well-being. The core muscles help support the back while standing and climbing stairs. They also prevent discomfort while lying down and reduce back pain. It is recommended to do core exercises to improve health and well-being.", "blog-6.jpg", false, "How Joint Replacement Can Transform Your Daily Activities?", null }
                });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8328));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8330));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8314));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8391));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8393));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 18, 13, 14, 434, DateTimeKind.Local).AddTicks(8360));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.UpdateData(
                table: "AboutSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Abouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6469));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6447));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "DonateSections",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6505));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6507));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6508));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "Galleries",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6510));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6484));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6485));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "PatientTestimonials",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "VideoTitles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Videos",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6598));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardingPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6583));

            migrationBuilder.UpdateData(
                table: "VolunteerOnboardings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6526));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6529));

            migrationBuilder.UpdateData(
                table: "Volunteers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateAt",
                value: new DateTime(2023, 12, 23, 1, 48, 48, 713, DateTimeKind.Local).AddTicks(6530));
        }
    }
}
