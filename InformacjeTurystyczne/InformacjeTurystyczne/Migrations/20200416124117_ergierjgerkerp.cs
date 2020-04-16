using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class ergierjgerkerp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_UserId",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_UserId",
                table: "PermissionEntertainment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PermissionEntertainment");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_IdUser",
                table: "PermissionEntertainment",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_IdUser",
                table: "PermissionEntertainment",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_IdUser",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_IdUser",
                table: "PermissionEntertainment");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionEntertainment",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_UserId",
                table: "PermissionEntertainment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_UserId",
                table: "PermissionEntertainment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
