using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class CreateRelationshipDevelopersContacts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "contactId",
                table: "Developers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Developers_contactId",
                table: "Developers",
                column: "contactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Developers_Contacts_contactId",
                table: "Developers",
                column: "contactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Developers_Contacts_contactId",
                table: "Developers");

            migrationBuilder.DropIndex(
                name: "IX_Developers_contactId",
                table: "Developers");

            migrationBuilder.DropColumn(
                name: "contactId",
                table: "Developers");
        }
    }
}
