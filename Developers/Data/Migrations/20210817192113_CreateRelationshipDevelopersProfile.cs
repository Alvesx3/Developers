using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateRelationshipDevelopersProfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "profileId",
                table: "Developers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Developers_profileId",
                table: "Developers",
                column: "profileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Profiles_profileId",
                table: "Developers",
                column: "profileId",
                principalTable: "Profiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Profiles_profileId",
                table: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_Developers_profileId",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "profileId",
                table: "Developers");
        }
    }
}
