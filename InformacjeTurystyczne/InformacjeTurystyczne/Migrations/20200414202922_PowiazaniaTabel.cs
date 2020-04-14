using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class PowiazaniaTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionRegion_Region_RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionShelter_Shelter_ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionTrial_Trial_TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Region_RegionIdRegion",
                table: "RegionLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Trial_TrialIdTrial",
                table: "RegionLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Shelter_Region_RegionIdRegion",
                table: "Shelter");

            migrationBuilder.DropIndex(
                name: "IX_Shelter_RegionIdRegion",
                table: "Shelter");

            migrationBuilder.DropIndex(
                name: "IX_RegionLocation_RegionIdRegion",
                table: "RegionLocation");

            migrationBuilder.DropIndex(
                name: "IX_RegionLocation_TrialIdTrial",
                table: "RegionLocation");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropColumn(
                name: "RegionIdRegion",
                table: "Shelter");

            migrationBuilder.DropColumn(
                name: "RegionIdRegion",
                table: "RegionLocation");

            migrationBuilder.DropColumn(
                name: "TrialIdTrial",
                table: "RegionLocation");

            migrationBuilder.DropColumn(
                name: "TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropColumn(
                name: "ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropColumn(
                name: "RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropColumn(
                name: "EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "PermissionTrial",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "PermissionShelter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "PermissionRegion",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUser",
                table: "PermissionEntertainment",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shelter_IdRegion",
                table: "Shelter",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_RegionLocation_IdRegion",
                table: "RegionLocation",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_RegionLocation_IdTrial",
                table: "RegionLocation",
                column: "IdTrial");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionTrial_IdTrial",
                table: "PermissionTrial",
                column: "IdTrial");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionTrial_IdUser",
                table: "PermissionTrial",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionShelter_IdShelter",
                table: "PermissionShelter",
                column: "IdShelter");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionShelter_IdUser",
                table: "PermissionShelter",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRegion_IdRegion",
                table: "PermissionRegion",
                column: "IdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRegion_IdUser",
                table: "PermissionRegion",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_IdEntertainment",
                table: "PermissionEntertainment",
                column: "IdEntertainment");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_IdUser",
                table: "PermissionEntertainment",
                column: "IdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_IdEntertainment",
                table: "PermissionEntertainment",
                column: "IdEntertainment",
                principalTable: "Entertainment",
                principalColumn: "IdEntertainment",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_IdUser",
                table: "PermissionEntertainment",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_Region_IdRegion",
                table: "PermissionRegion",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_AspNetUsers_IdUser",
                table: "PermissionRegion",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_Shelter_IdShelter",
                table: "PermissionShelter",
                column: "IdShelter",
                principalTable: "Shelter",
                principalColumn: "IdShelter",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_AspNetUsers_IdUser",
                table: "PermissionShelter",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_Trial_IdTrial",
                table: "PermissionTrial",
                column: "IdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_AspNetUsers_IdUser",
                table: "PermissionTrial",
                column: "IdUser",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegionLocation_Region_IdRegion",
                table: "RegionLocation",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegionLocation_Trial_IdTrial",
                table: "RegionLocation",
                column: "IdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shelter_Region_IdRegion",
                table: "Shelter",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_IdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_IdUser",
                table: "PermissionEntertainment");

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

            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Region_IdRegion",
                table: "RegionLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Trial_IdTrial",
                table: "RegionLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_Shelter_Region_IdRegion",
                table: "Shelter");

            migrationBuilder.DropIndex(
                name: "IX_Shelter_IdRegion",
                table: "Shelter");

            migrationBuilder.DropIndex(
                name: "IX_RegionLocation_IdRegion",
                table: "RegionLocation");

            migrationBuilder.DropIndex(
                name: "IX_RegionLocation_IdTrial",
                table: "RegionLocation");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_IdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_IdUser",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_IdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_IdUser",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_IdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_IdUser",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_IdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_IdUser",
                table: "PermissionEntertainment");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "PermissionTrial");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "PermissionShelter");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "PermissionRegion");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "PermissionEntertainment");

            migrationBuilder.AddColumn<int>(
                name: "RegionIdRegion",
                table: "Shelter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionIdRegion",
                table: "RegionLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrialIdTrial",
                table: "RegionLocation",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrialIdTrial",
                table: "PermissionTrial",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShelterIdShelter",
                table: "PermissionShelter",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionIdRegion",
                table: "PermissionRegion",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Shelter_RegionIdRegion",
                table: "Shelter",
                column: "RegionIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_RegionLocation_RegionIdRegion",
                table: "RegionLocation",
                column: "RegionIdRegion");

            migrationBuilder.CreateIndex(
                name: "IX_RegionLocation_TrialIdTrial",
                table: "RegionLocation",
                column: "TrialIdTrial");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionTrial_TrialIdTrial",
                table: "PermissionTrial",
                column: "TrialIdTrial");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionShelter_ShelterIdShelter",
                table: "PermissionShelter",
                column: "ShelterIdShelter");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionRegion_RegionIdRegion",
                table: "PermissionRegion",
                column: "RegionIdRegion");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionRegion_Region_RegionIdRegion",
                table: "PermissionRegion",
                column: "RegionIdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionShelter_Shelter_ShelterIdShelter",
                table: "PermissionShelter",
                column: "ShelterIdShelter",
                principalTable: "Shelter",
                principalColumn: "IdShelter",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionTrial_Trial_TrialIdTrial",
                table: "PermissionTrial",
                column: "TrialIdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegionLocation_Region_RegionIdRegion",
                table: "RegionLocation",
                column: "RegionIdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegionLocation_Trial_TrialIdTrial",
                table: "RegionLocation",
                column: "TrialIdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shelter_Region_RegionIdRegion",
                table: "Shelter",
                column: "RegionIdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
