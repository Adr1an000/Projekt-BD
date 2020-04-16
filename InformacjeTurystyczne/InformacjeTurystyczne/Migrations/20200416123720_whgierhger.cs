using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class whgierhger : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropColumn(
                name: "EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_IdEntertainment",
                table: "PermissionEntertainment",
                column: "IdEntertainment",
                principalTable: "Entertainment",
                principalColumn: "IdEntertainment",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_IdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.AddColumn<int>(
                name: "EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                column: "EntertainmentIdEntertainment");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                column: "EntertainmentIdEntertainment",
                principalTable: "Entertainment",
                principalColumn: "IdEntertainment",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
