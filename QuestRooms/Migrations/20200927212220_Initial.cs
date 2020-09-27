using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestRooms.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    QuestId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Duration = table.Column<int>(nullable: false),
                    MinPlayersCount = table.Column<int>(nullable: false),
                    MaxPlayersCount = table.Column<int>(nullable: false),
                    MinAgeOfPlayers = table.Column<int>(nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    PhoneNumbers = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Company = table.Column<string>(nullable: false),
                    Rating = table.Column<double>(nullable: false),
                    FearRating = table.Column<int>(nullable: false),
                    Difficulty = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: false),
                    Galerry = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.QuestId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
