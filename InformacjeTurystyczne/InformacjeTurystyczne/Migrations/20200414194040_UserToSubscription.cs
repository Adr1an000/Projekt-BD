using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class UserToSubscription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "Subscription",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subscription_IdUser",
                table: "Subscription",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscription_AspNetUsers_IdUser",
                table: "Subscription",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscription_AspNetUsers_IdUser",
                table: "Subscription");

            migrationBuilder.DropIndex(
                name: "IX_Subscription_IdUser",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Subscription");
        }
    }
}
