using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Category_CategoryIdCategory",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_CategoryIdCategory",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "CategoryIdCategory",
                table: "Message");

            migrationBuilder.CreateIndex(
                name: "IX_Message_IdCategory",
                table: "Message",
                column: "IdCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Category_IdCategory",
                table: "Message",
                column: "IdCategory",
                principalTable: "Category",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Category_IdCategory",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_IdCategory",
                table: "Message");

            migrationBuilder.AddColumn<int>(
                name: "CategoryIdCategory",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_CategoryIdCategory",
                table: "Message",
                column: "CategoryIdCategory");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Category_CategoryIdCategory",
                table: "Message",
                column: "CategoryIdCategory",
                principalTable: "Category",
                principalColumn: "IdCategory",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
