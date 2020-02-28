using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class ImageStringChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/img/meditate.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/img/yoga.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "/img/zipline.jpg");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "/img/lizard.jpg");
        }
    }
}
