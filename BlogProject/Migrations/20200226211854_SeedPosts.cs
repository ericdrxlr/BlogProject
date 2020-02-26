using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class SeedPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublishDate",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BlogId", "Body", "PublishDate", "Title" },
                values: new object[] { 1, "Josh", 1, "There was a duck. It was weird.", "0", "That one time with the duck" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BlogId", "Body", "PublishDate", "Title" },
                values: new object[] { 2, "Johnny", 2, "The best ziplining experience in the USA", "12/20/2020", "Ziplining in Hawaii" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BlogId", "Body", "PublishDate", "Title" },
                values: new object[] { 3, "Juniper", 3, "Foxes are not domesticated pets. Adopt at your own risk.", "2/4/2018", "Please don't adopt a fox" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "PublishDate",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
