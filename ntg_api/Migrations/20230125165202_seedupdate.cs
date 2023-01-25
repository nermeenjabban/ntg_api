using Microsoft.EntityFrameworkCore.Migrations;

namespace ntg_api.Migrations
{
    public partial class seedupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseTeacherId", "Name", "Phonenumber" },
                values: new object[] { 2, "Ahmad Ali", "+963458722" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CourseTeacherId", "Name", "Phonenumber" },
                values: new object[] { 1, "Nermeen Jabban", "+9636987654" });
        }
    }
}
