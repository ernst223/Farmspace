using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmboekAPI.Migrations
{
    public partial class MediaMultipleLinks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CatagoryId",
                table: "Media");

            migrationBuilder.CreateTable(
                name: "MediaCatagories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaId = table.Column<int>(nullable: false),
                    CatagoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaCatagories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MediaProductLinks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MediaId = table.Column<int>(nullable: false),
                    EntryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaProductLinks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MediaCatagories");

            migrationBuilder.DropTable(
                name: "MediaProductLinks");

            migrationBuilder.AddColumn<int>(
                name: "CatagoryId",
                table: "Media",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
