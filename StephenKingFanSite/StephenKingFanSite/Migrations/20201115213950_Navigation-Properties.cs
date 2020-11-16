using Microsoft.EntityFrameworkCore.Migrations;

namespace StephenKingFanSite.Migrations
{
    public partial class NavigationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Genre_GenresID",
                table: "Movie");

            migrationBuilder.DropForeignKey(
                name: "FK_Novel_Genre_GenresID",
                table: "Novel");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Forum_ForumID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Movie_MovieID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Novel_NovelID",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Score_ScoreID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ForumID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_MovieID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_NovelID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ScoreID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Novel_GenresID",
                table: "Novel");

            migrationBuilder.DropIndex(
                name: "IX_Movie_GenresID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ForumID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "NovelID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ScoreID",
                table: "User");

            migrationBuilder.DropColumn(
                name: "GenresID",
                table: "Novel");

            migrationBuilder.DropColumn(
                name: "GenresID",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Novel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ForumUser",
                columns: table => new
                {
                    ForumsID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumUser", x => new { x.ForumsID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_ForumUser_Forum_ForumsID",
                        column: x => x.ForumsID,
                        principalTable: "Forum",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ForumUser_User_UsersID",
                        column: x => x.UsersID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreMovie",
                columns: table => new
                {
                    GenresID = table.Column<int>(type: "int", nullable: false),
                    MoviesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreMovie", x => new { x.GenresID, x.MoviesID });
                    table.ForeignKey(
                        name: "FK_GenreMovie_Genre_GenresID",
                        column: x => x.GenresID,
                        principalTable: "Genre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreMovie_Movie_MoviesID",
                        column: x => x.MoviesID,
                        principalTable: "Movie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreNovel",
                columns: table => new
                {
                    GenresID = table.Column<int>(type: "int", nullable: false),
                    NovelsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreNovel", x => new { x.GenresID, x.NovelsID });
                    table.ForeignKey(
                        name: "FK_GenreNovel_Genre_GenresID",
                        column: x => x.GenresID,
                        principalTable: "Genre",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreNovel_Novel_NovelsID",
                        column: x => x.NovelsID,
                        principalTable: "Novel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieUser",
                columns: table => new
                {
                    MoviesID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieUser", x => new { x.MoviesID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_MovieUser_Movie_MoviesID",
                        column: x => x.MoviesID,
                        principalTable: "Movie",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieUser_User_UsersID",
                        column: x => x.UsersID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NovelUser",
                columns: table => new
                {
                    NovelsID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NovelUser", x => new { x.NovelsID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_NovelUser_Novel_NovelsID",
                        column: x => x.NovelsID,
                        principalTable: "Novel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NovelUser_User_UsersID",
                        column: x => x.UsersID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScoreUser",
                columns: table => new
                {
                    ScoresID = table.Column<int>(type: "int", nullable: false),
                    UsersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScoreUser", x => new { x.ScoresID, x.UsersID });
                    table.ForeignKey(
                        name: "FK_ScoreUser_Score_ScoresID",
                        column: x => x.ScoresID,
                        principalTable: "Score",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScoreUser_User_UsersID",
                        column: x => x.UsersID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumUser_UsersID",
                table: "ForumUser",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_GenreMovie_MoviesID",
                table: "GenreMovie",
                column: "MoviesID");

            migrationBuilder.CreateIndex(
                name: "IX_GenreNovel_NovelsID",
                table: "GenreNovel",
                column: "NovelsID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieUser_UsersID",
                table: "MovieUser",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_NovelUser_UsersID",
                table: "NovelUser",
                column: "UsersID");

            migrationBuilder.CreateIndex(
                name: "IX_ScoreUser_UsersID",
                table: "ScoreUser",
                column: "UsersID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ForumUser");

            migrationBuilder.DropTable(
                name: "GenreMovie");

            migrationBuilder.DropTable(
                name: "GenreNovel");

            migrationBuilder.DropTable(
                name: "MovieUser");

            migrationBuilder.DropTable(
                name: "NovelUser");

            migrationBuilder.DropTable(
                name: "ScoreUser");

            migrationBuilder.AddColumn<int>(
                name: "ForumID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NovelID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreID",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Novel",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GenresID",
                table: "Novel",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "GenresID",
                table: "Movie",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Topic",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Forum",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_User_ForumID",
                table: "User",
                column: "ForumID");

            migrationBuilder.CreateIndex(
                name: "IX_User_MovieID",
                table: "User",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_User_NovelID",
                table: "User",
                column: "NovelID");

            migrationBuilder.CreateIndex(
                name: "IX_User_ScoreID",
                table: "User",
                column: "ScoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Novel_GenresID",
                table: "Novel",
                column: "GenresID");

            migrationBuilder.CreateIndex(
                name: "IX_Movie_GenresID",
                table: "Movie",
                column: "GenresID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Genre_GenresID",
                table: "Movie",
                column: "GenresID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Novel_Genre_GenresID",
                table: "Novel",
                column: "GenresID",
                principalTable: "Genre",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Forum_ForumID",
                table: "User",
                column: "ForumID",
                principalTable: "Forum",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Movie_MovieID",
                table: "User",
                column: "MovieID",
                principalTable: "Movie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Novel_NovelID",
                table: "User",
                column: "NovelID",
                principalTable: "Novel",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Score_ScoreID",
                table: "User",
                column: "ScoreID",
                principalTable: "Score",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
