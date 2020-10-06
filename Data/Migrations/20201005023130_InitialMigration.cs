using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsPlus.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(nullable: false),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamName = table.Column<string>(maxLength: 30, nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamName);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false),
                    Province = table.Column<string>(nullable: true),
                    ProvinceCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    TeamName = table.Column<string>(nullable: false),
                    TeamName1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamName1",
                        column: x => x.TeamName1,
                        principalTable: "Team",
                        principalColumn: "TeamName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Vancouver", 1000000, "British Columbia", null },
                    { 2, "Surrey", 500000, "British Columbia", null },
                    { 3, "Calgary", 850000, "Alberta", null },
                    { 4, "Ottawa", 2000000, "Ontario", null },
                    { 5, "Saskatoon", 253000, "Sasktchewan", null }
                });

            migrationBuilder.InsertData(
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName", "TeamName1" },
                values: new object[,]
                {
                    { 3, "John", "Rooster", "Right Wing", "Flames", null },
                    { 4, "Bob", "Plumber", "Defense", "Oilers", null },
                    { 1, "Sven", "Baertschi", "Forward", "Canucks", null },
                    { 2, "Hendrik", "Sedin", "Left Wing", "Canucks", null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "BC", "British Columbia" },
                    { "ON", "Ontario" },
                    { "SK", "Saskatchewan" },
                    { "AB", "Alberta" }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamName", "City", "Country" },
                values: new object[,]
                {
                    { "Flames", "Calgary", "Canada" },
                    { "Canucks", "Vancouver", "Canada" },
                    { "Oilers", "Edmonton", "Canada" },
                    { "Leafs", "Toronto", "Canada" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamName1",
                table: "Player",
                column: "TeamName1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
