using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrering.Migrations
{
    public partial class addHomegroupToAttendee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<decimal>(
                name: "longitude",
                table: "Moter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "latitude",
                table: "Moter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Zip",
                table: "Moter",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Time",
                table: "Moter",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");


            migrationBuilder.AddColumn<int>(
                name: "homeGroupId",
                table: "Attendees",
                nullable: true);

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
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Moter_homeGroupId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_homeGroupId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "homeGroupId",
                table: "Attendees");

            migrationBuilder.AlterColumn<string>(
                name: "longitude",
                table: "Moter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<string>(
                name: "latitude",
                table: "Moter",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "Zip",
                table: "Moter",
                type: "float",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<double>(
                name: "Time",
                table: "Moter",
                type: "float",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

        }
    }
}
