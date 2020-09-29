using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsPlus.Data.Migrations
{
    public partial class myfirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Player",
                columns: new[] { "PlayerId", "FirstName", "LastName", "Position", "TeamName", "TeamName1" },
                values: new object[,]
                {
                    { 1, "Sven", "Baertschi", "Forward", "Canucks", null },
                    { 2, "Hendrik", "Sedin", "Left Wing", "Canucks", null },
                    { 3, "John", "Rooster", "Right Wing", "Flames", null },
                    { 4, "Bob", "Plumber", "Defense", "Oilers", null }
                });

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "TeamName", "City", "Country" },
                values: new object[,]
                {
                    { "Canucks", "Vancouver", "Canada" },
                    { "Oilers", "Edmonton", "Canada" },
                    { "Flames", "Calgary", "Canada" },
                    { "Leafs", "Toronto", "Canada" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamName1",
                table: "Player",
                column: "TeamName1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");
        }
    }
}
