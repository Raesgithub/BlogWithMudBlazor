using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppSamsar.Migrations
{
    /// <inheritdoc />
    public partial class n3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Article_AppUsers_AppUserUsername",
                table: "Article");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Article",
                table: "Article");

            migrationBuilder.RenameTable(
                name: "Article",
                newName: "Articles");

            migrationBuilder.RenameIndex(
                name: "IX_Article_AppUserUsername",
                table: "Articles",
                newName: "IX_Articles_AppUserUsername");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Articles",
                table: "Articles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_AppUsers_AppUserUsername",
                table: "Articles",
                column: "AppUserUsername",
                principalTable: "AppUsers",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_AppUsers_AppUserUsername",
                table: "Articles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Articles",
                table: "Articles");

            migrationBuilder.RenameTable(
                name: "Articles",
                newName: "Article");

            migrationBuilder.RenameIndex(
                name: "IX_Articles_AppUserUsername",
                table: "Article",
                newName: "IX_Article_AppUserUsername");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Article",
                table: "Article",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Article_AppUsers_AppUserUsername",
                table: "Article",
                column: "AppUserUsername",
                principalTable: "AppUsers",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
