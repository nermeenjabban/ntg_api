using Microsoft.EntityFrameworkCore.Migrations;

namespace ntg_api.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "courses",
                columns: new[] { "Id", "CourseName", "Price" },
                values: new object[,]
                {
                    { 1, "English", 20000 },
                    { 2, "French", 90000 },
                    { 3, "Business Administration", 90000 },
                    { 4, "ICDL", 70000 },
                    { 5, "Communication skills", 50000 }
                });

            migrationBuilder.InsertData(
                table: "teachers",
                columns: new[] { "Id", "TeacherName", "TeacherType" },
                values: new object[,]
                {
                    { 1, "Gary Cabrera", "male" },
                    { 2, "Stacy Logan", "male" },
                    { 3, "Priscilla Phelps", "male" },
                    { 4, "Aliza Vance", "female" },
                    { 5, "Averie Carter", "female" },
                    { 6, "Savannah Brooks", "female" },
                    { 7, "Belen Fox", "female" },
                    { 8, "Yadira Mcintyre", "female" },
                    { 9, "Grayson Stout", "female" }
                });

            migrationBuilder.InsertData(
                table: "courseTeachers",
                columns: new[] { "Id", "CourseId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 5, 2, 3 },
                    { 4, 2, 4 },
                    { 6, 3, 5 },
                    { 7, 3, 6 },
                    { 8, 4, 7 },
                    { 9, 4, 8 },
                    { 11, 5, 8 },
                    { 10, 5, 9 }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Address", "Age", "CourseTeacherId", "Name", "Phonenumber" },
                values: new object[] { 1, "Damascus", 23, 1, "Nermeen Jabban", "+9636987654" });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "Id", "Address", "Age", "CourseTeacherId", "Name", "Phonenumber" },
                values: new object[] { 2, "Damascus", 23, 1, "Nermeen Jabban", "+9636987654" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "courseTeachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "teachers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
