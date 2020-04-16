using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class gifejrgiojego : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_IdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_IdUser",
                table: "PermissionTrial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_IdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_IdUser",
                table: "PermissionShelter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_IdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_IdUser",
                table: "PermissionRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_IdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_IdUser",
                table: "PermissionEntertainment");

            migrationBuilder.DropColumn(
                name: "IdPermissionTrial",
                table: "PermissionTrial");

            migrationBuilder.DropColumn(
                name: "IdPermissionShelter",
                table: "PermissionShelter");

            migrationBuilder.DropColumn(
                name: "IdPermissionRegion",
                table: "PermissionRegion");

            migrationBuilder.DropColumn(
                name: "IdPermissionEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionTrial",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdTrial",
                table: "PermissionTrial",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TrialIdTrial",
                table: "PermissionTrial",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionTrial",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionShelter",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdShelter",
                table: "PermissionShelter",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShelterIdShelter",
                table: "PermissionShelter",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionShelter",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionRegion",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdRegion",
                table: "PermissionRegion",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegionIdRegion",
                table: "PermissionRegion",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionRegion",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionEntertainment",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdEntertainment",
                table: "PermissionEntertainment",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PermissionEntertainment",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionTrial",
                table: "PermissionTrial",
                columns: new[] { "IdTrial", "IdUser" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionShelter",
                table: "PermissionShelter",
                columns: new[] { "IdShelter", "IdUser" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionRegion",
                table: "PermissionRegion",
                columns: new[] { "IdRegion", "IdUser" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionEntertainment",
                table: "PermissionEntertainment",
                columns: new[] { "IdEntertainment", "IdUser" });

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

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                column: "EntertainmentIdEntertainment");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionEntertainment_UserId",
                table: "PermissionEntertainment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment",
                column: "EntertainmentIdEntertainment",
                principalTable: "Entertainment",
                principalColumn: "IdEntertainment",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_UserId",
                table: "PermissionEntertainment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_Entertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropForeignKey(
                name: "FK_PermissionEntertainment_AspNetUsers_UserId",
                table: "PermissionEntertainment");

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

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_TrialIdTrial",
                table: "PermissionTrial");

            migrationBuilder.DropIndex(
                name: "IX_PermissionTrial_UserId",
                table: "PermissionTrial");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_ShelterIdShelter",
                table: "PermissionShelter");

            migrationBuilder.DropIndex(
                name: "IX_PermissionShelter_UserId",
                table: "PermissionShelter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_RegionIdRegion",
                table: "PermissionRegion");

            migrationBuilder.DropIndex(
                name: "IX_PermissionRegion_UserId",
                table: "PermissionRegion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PermissionEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropIndex(
                name: "IX_PermissionEntertainment_UserId",
                table: "PermissionEntertainment");

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

            migrationBuilder.DropColumn(
                name: "EntertainmentIdEntertainment",
                table: "PermissionEntertainment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PermissionEntertainment");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionTrial",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "IdTrial",
                table: "PermissionTrial",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdPermissionTrial",
                table: "PermissionTrial",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionShelter",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "IdShelter",
                table: "PermissionShelter",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdPermissionShelter",
                table: "PermissionShelter",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionRegion",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "IdRegion",
                table: "PermissionRegion",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdPermissionRegion",
                table: "PermissionRegion",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "IdUser",
                table: "PermissionEntertainment",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "IdEntertainment",
                table: "PermissionEntertainment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdPermissionEntertainment",
                table: "PermissionEntertainment",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionTrial",
                table: "PermissionTrial",
                column: "IdPermissionTrial");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionShelter",
                table: "PermissionShelter",
                column: "IdPermissionShelter");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionRegion",
                table: "PermissionRegion",
                column: "IdPermissionRegion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PermissionEntertainment",
                table: "PermissionEntertainment",
                column: "IdPermissionEntertainment");

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
        }
    }
}
