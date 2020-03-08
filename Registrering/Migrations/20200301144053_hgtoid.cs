using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrering.Migrations
{
    public partial class hgtoid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_homeGroupId",
                table: "Attendees");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Attendees_homeGroupId",
                table: "Attendees",
                column: "homeGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees",
                column: "homeGroupId",
                principalTable: "Moter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
