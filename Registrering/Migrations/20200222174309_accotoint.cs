using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrering.Migrations
{
    public partial class accotoint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees");

            migrationBuilder.AlterColumn<int>(
                name: "homeGroupId",
                table: "Attendees",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Accomodation",
                table: "Attendees",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees",
                column: "homeGroupId",
                principalTable: "Moter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees");

            migrationBuilder.AlterColumn<int>(
                name: "homeGroupId",
                table: "Attendees",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<bool>(
                name: "Accomodation",
                table: "Attendees",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees",
                column: "homeGroupId",
                principalTable: "Moter",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
