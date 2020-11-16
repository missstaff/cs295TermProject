using Microsoft.EntityFrameworkCore.Migrations;

namespace StephenKingFanSite.Migrations
{
    public partial class Rating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Novel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Movie",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_ForumID",
                table: "User",
                column: "ForumID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Forum_ForumID",
                table: "User",
                column: "ForumID",
                principalTable: "Forum",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Forum_ForumID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ForumID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ForumID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Novel");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Movie");
        }
    }
}
