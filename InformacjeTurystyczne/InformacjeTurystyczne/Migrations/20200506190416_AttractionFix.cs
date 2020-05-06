using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class AttractionFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttractionType",
                table: "Attraction",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttractionType",
                table: "Attraction");
        }
    }
}
