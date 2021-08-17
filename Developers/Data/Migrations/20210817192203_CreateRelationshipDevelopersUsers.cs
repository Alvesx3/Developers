using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateRelationshipDevelopersUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "Developers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Developers_userId",
                table: "Developers",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Users_userId",
                table: "Developers",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Users_userId",
                table: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_Developers_userId",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "Developers");
        }
    }
}
