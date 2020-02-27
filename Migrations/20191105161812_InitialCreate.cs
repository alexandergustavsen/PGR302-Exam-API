using Microsoft.EntityFrameworkCore.Migrations;

namespace InventorySystemAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    Platform = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    AgeRestriction = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
