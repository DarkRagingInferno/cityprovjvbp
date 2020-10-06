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
                    ProvinceCode = table.Column<string>(nullable: true),
                    ProvinceCode1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceCode1",
                        column: x => x.ProvinceCode1,
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
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode", "ProvinceCode1" },
                values: new object[,]
                {
                    { 1, "Vancouver", 1000000, "BC", null },
                    { 11, "Regina", 253000, "SK", null },
                    { 10, "Saskatoon", 253000, "SK", null },
                    { 9, "Toronto", 2000000, "ON", null },
                    { 8, "Windsor", 2000000, "ON", null },
                    { 7, "Ottawa", 2000000, "ON", null },
                    { 12, "Melford", 253000, "SK", null },
                    { 5, "Edmonton", 850000, "AB", null },
                    { 4, "Calgary", 850000, "AB", null },
                    { 3, "Burnaby", 60000, "BC", null },
                    { 2, "Surrey", 700000, "BC", null },
                    { 6, "Red Deer", 850000, "AB", null }
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
                name: "IX_Cities_ProvinceCode1",
                table: "Cities",
                column: "ProvinceCode1");

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
