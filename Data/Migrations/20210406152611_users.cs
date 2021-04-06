using Microsoft.EntityFrameworkCore.Migrations;

namespace TetsJokesApp.Data.Migrations
{
    public partial class users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Joke",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Joke_UserID",
                table: "Joke",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Joke_AspNetUsers_UserID",
                table: "Joke",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Joke_AspNetUsers_UserID",
                table: "Joke");

            migrationBuilder.DropIndex(
                name: "IX_Joke_UserID",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Joke");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");
        }
    }
}
