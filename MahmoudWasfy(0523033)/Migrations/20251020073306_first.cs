using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MahmoudWasfy_0523033_.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpierneceYears = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coaches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "competitions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_competitions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coachid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_teams_coaches_Coachid",
                        column: x => x.Coachid,
                        principalTable: "coaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionTeam",
                columns: table => new
                {
                    TeamsId = table.Column<int>(type: "int", nullable: false),
                    competitionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionTeam", x => new { x.TeamsId, x.competitionsId });
                    table.ForeignKey(
                        name: "FK_CompetitionTeam_competitions_competitionsId",
                        column: x => x.competitionsId,
                        principalTable: "competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompetitionTeam_teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_players_teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "coaches",
                columns: new[] { "Id", "ExpierneceYears", "Name", "Specialization" },
                values: new object[] { 1, 3, "mostafa", "Vollyball" });

            migrationBuilder.InsertData(
                table: "competitions",
                columns: new[] { "Id", "Date", "Location", "Title" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7elwan", "idk" });

            migrationBuilder.InsertData(
                table: "teams",
                columns: new[] { "Id", "Coachid", "Name", "city" },
                values: new object[] { 1, 1, "el ahly", "Cairo" });

            migrationBuilder.InsertData(
                table: "players",
                columns: new[] { "Id", "Age", "FullName", "Position", "TeamId" },
                values: new object[] { 1, 18, "Wasfy", "Striker", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionTeam_competitionsId",
                table: "CompetitionTeam",
                column: "competitionsId");

            migrationBuilder.CreateIndex(
                name: "IX_players_TeamId",
                table: "players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_teams_Coachid",
                table: "teams",
                column: "Coachid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_teams_Name",
                table: "teams",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompetitionTeam");

            migrationBuilder.DropTable(
                name: "players");

            migrationBuilder.DropTable(
                name: "competitions");

            migrationBuilder.DropTable(
                name: "teams");

            migrationBuilder.DropTable(
                name: "coaches");
        }
    }
}
