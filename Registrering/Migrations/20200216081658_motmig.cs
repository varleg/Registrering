using Microsoft.EntityFrameworkCore.Migrations;

namespace Registrering.Migrations
{
    public partial class motmig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Committee = table.Column<string>(nullable: true),
                    CommitteeName = table.Column<string>(nullable: true),
                    AddDate = table.Column<string>(nullable: true),
                    AreaRegion = table.Column<string>(nullable: true),
                    ParentName = table.Column<string>(nullable: true),
                    F6 = table.Column<string>(nullable: true),
                    F7 = table.Column<string>(nullable: true),
                    F8 = table.Column<string>(nullable: true),
                    F9 = table.Column<string>(nullable: true),
                    F10 = table.Column<string>(nullable: true),
                    F11 = table.Column<string>(nullable: true),
                    F12 = table.Column<string>(nullable: true),
                    F13 = table.Column<string>(nullable: true),
                    F14 = table.Column<string>(nullable: true),
                    F15 = table.Column<string>(nullable: true),
                    F16 = table.Column<string>(nullable: true),
                    F17 = table.Column<string>(nullable: true),
                    F18 = table.Column<string>(nullable: true),
                    Room = table.Column<string>(nullable: true),
                    Closed = table.Column<string>(nullable: true),
                    WheelChr = table.Column<string>(nullable: true),
                    Day = table.Column<string>(nullable: true),
                    Time = table.Column<double>(nullable: false),
                    Language1 = table.Column<string>(nullable: true),
                    F25 = table.Column<string>(nullable: true),
                    F26 = table.Column<string>(nullable: true),
                    F27 = table.Column<string>(nullable: true),
                    Place = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    LocBorough = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<double>(nullable: false),
                    Country = table.Column<string>(nullable: true),
                    Directions = table.Column<string>(nullable: true),
                    F36 = table.Column<string>(nullable: true),
                    Format1 = table.Column<string>(nullable: true),
                    Format2 = table.Column<string>(nullable: true),
                    Format3 = table.Column<string>(nullable: true),
                    Format4 = table.Column<string>(nullable: true),
                    Format5 = table.Column<string>(nullable: true),
                    Delete = table.Column<string>(nullable: true),
                    LastChanged = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true),
                    latitude = table.Column<string>(nullable: true),
                    ContactGP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moter", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moter");
        }
    }
}
