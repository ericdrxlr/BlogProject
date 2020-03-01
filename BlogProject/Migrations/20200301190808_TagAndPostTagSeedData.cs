using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogProject.Migrations
{
    public partial class TagAndPostTagSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<int>(nullable: false),
                    PostId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "BlogId", "Body", "PublishDate", "Title" },
                values: new object[,]
                {
                    { 4, "Ben", 1, "All my life, I had been terrified of flying. The concept of getting into a plane and traveling at high speeds for multiple hours made me feel sick to my stomach. But last night, I had a dream that I floated up into the clouds above the city. The buildings and roads looked beautiful from above. It was initially gut-wrenching, but the sensation of floating has convinced me that I need to see what the world looks like from the window of an airplane. I have a flight booked to New York City tomorrow.", "2/29/2020", "Flying" },
                    { 5, "Ben", 2, "I found a great resource online explaining exactly what meditation is and how it can help you in your everyday lives. You can check it out at this link here: https://mindworks.org/blog/meditation-definition/", "2/29/2020", "What Is Meditation?" },
                    { 6, "Josh", 3, "I spent a half hour in the afternoon doing yoga in the zen room with some friends. It was hard at first because I'm horribly out of shape, but at the end of the session I felt refreshed and happy. I highly recommend getting into yoga if you haven't already.", "3/1/2020", "My experience with yoga at We Can Code IT" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "relaxing" },
                    { 2, "subconscious" },
                    { 3, "mindful" },
                    { 4, "zen" }
                });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "Id", "PostId", "TagId" },
                values: new object[,]
                {
                    { 1, 2, 1 },
                    { 2, 5, 1 },
                    { 3, 1, 2 },
                    { 4, 4, 2 },
                    { 5, 5, 3 },
                    { 6, 6, 3 },
                    { 7, 2, 4 },
                    { 8, 3, 4 },
                    { 9, 6, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_PostId",
                table: "PostTags",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagId",
                table: "PostTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
