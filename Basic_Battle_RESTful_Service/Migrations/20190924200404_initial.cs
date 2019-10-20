using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Basic_Battle_RESTful_Service.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WhichPlayer = table.Column<int>(nullable: false),
                    RedID = table.Column<int>(nullable: false),
                    BlueID = table.Column<int>(nullable: false),
                    WinnerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GamePlayerInfo",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PlayerID = table.Column<int>(nullable: false),
                    GameID = table.Column<int>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    Armour = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlayerInfo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MatchLog",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<int>(nullable: false),
                    GameID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchLog", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SelectedCharacter = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    HealthRate = table.Column<int>(nullable: false),
                    ArmorRate = table.Column<int>(nullable: false),
                    Damage = table.Column<int>(nullable: false),
                    SpecialAttackName = table.Column<string>(nullable: true),
                    SpecialAttackDamage = table.Column<int>(nullable: false),
                    SpecialAttackName1 = table.Column<string>(nullable: true),
                    SpecialAttackDamage1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");

            migrationBuilder.DropTable(
                name: "GamePlayerInfo");

            migrationBuilder.DropTable(
                name: "MatchLog");

            migrationBuilder.DropTable(
                name: "Player");
        }
    }
}
