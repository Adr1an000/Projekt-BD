using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class help : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRegion_Region_RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRegion_AspNetUsers_UserId",
                table: "PermissionRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionShelter_Shelter_ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionShelter_AspNetUsers_UserId",
                table: "PermissionShelter");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionTrial_Trial_TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionTrial_AspNetUsers_UserId",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_UserId",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_UserId",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_UserId",
                table: "PermissionRegion");

            migrationBuilder.DropColumn(
                name: "TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PermissionTrial");

            migrationBuilder.DropColumn(
                name: "ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PermissionShelter");

            migrationBuilder.DropColumn(
                name: "RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PermissionRegion");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionTrial_IdUser",
                table: "PermissionTrial",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionShelter_IdUser",
                table: "PermissionShelter",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRegion_IdUser",
                table: "PermissionRegion",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_Region_IdRegion",
                table: "PermissionRegion",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_AspNetUsers_IdUser",
                table: "PermissionRegion",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_Shelter_IdShelter",
                table: "PermissionShelter",
                column: "IdShelter",
                principalTable: "Shelter",
                principalColumn: "IdShelter",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_AspNetUsers_IdUser",
                table: "PermissionShelter",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_Trial_IdTrial",
                table: "PermissionTrial",
                column: "IdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_AspNetUsers_IdUser",
                table: "PermissionTrial",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRegion_Region_IdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRegion_AspNetUsers_IdUser",
                table: "PermissionRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionShelter_Shelter_IdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionShelter_AspNetUsers_IdUser",
                table: "PermissionShelter");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionTrial_Trial_IdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionTrial_AspNetUsers_IdUser",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_IdUser",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_IdUser",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_IdUser",
                table: "PermissionRegion");

            migrationBuilder.AddColumn<int>(
                name: "TrialIdTrial",
                table: "PermissionTrial",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionTrial",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShelterIdShelter",
                table: "PermissionShelter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionShelter",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionIdRegion",
                table: "PermissionRegion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionRegion",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissionTrial_TrialIdTrial",
                table: "PermissionTrial",
                column: "TrialIdTrial");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionTrial_UserId",
                table: "PermissionTrial",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionShelter_ShelterIdShelter",
                table: "PermissionShelter",
                column: "ShelterIdShelter");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionShelter_UserId",
                table: "PermissionShelter",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRegion_RegionIdRegion",
                table: "PermissionRegion",
                column: "RegionIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRegion_UserId",
                table: "PermissionRegion",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_Region_RegionIdRegion",
                table: "PermissionRegion",
                column: "RegionIdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_AspNetUsers_UserId",
                table: "PermissionRegion",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_Shelter_ShelterIdShelter",
                table: "PermissionShelter",
                column: "ShelterIdShelter",
                principalTable: "Shelter",
                principalColumn: "IdShelter",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_AspNetUsers_UserId",
                table: "PermissionShelter",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_Trial_TrialIdTrial",
                table: "PermissionTrial",
                column: "TrialIdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_AspNetUsers_UserId",
                table: "PermissionTrial",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
