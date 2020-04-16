using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class RegionLocationTabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Region_IdRegion",
                table: "RegionLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Trial_IdTrial",
                table: "RegionLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegionLocation",
                table: "RegionLocation");

            migrationBuilder.DropIndex(
                name: "IX_RegionLocation_IdRegion",
                table: "RegionLocation");

            migrationBuilder.DropColumn(
                name: "IdRegionLocation",
                table: "RegionLocation");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Trial",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdTrial",
                table: "RegionLocation",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IdRegion",
                table: "RegionLocation",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegionLocation",
                table: "RegionLocation",
                columns: new[] { "IdRegion", "IdTrial" });

            migrationBuilder.AddForeignKey(
                name: "FK_RegionLocation_Region_IdRegion",
                table: "RegionLocation",
                column: "IdRegion",
                principalTable: "Region",
                principalColumn: "IdRegion",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegionLocation_Trial_IdTrial",
                table: "RegionLocation",
                column: "IdTrial",
                principalTable: "Trial",
                principalColumn: "IdTrial",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Region_IdRegion",
                table: "RegionLocation");

            migrationBuilder.DropForeignKey(
                name: "FK_RegionLocation_Trial_IdTrial",
                table: "RegionLocation");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegionLocation",
                table: "RegionLocation");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Trial");

            migrationBuilder.AlterColumn<int>(
                name: "IdTrial",
                table: "RegionLocation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "IdRegion",
                table: "RegionLocation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdRegionLocation",
                table: "RegionLocation",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegionLocation",
                table: "RegionLocation",
                column: "IdRegionLocation");

            migrationBuilder.CreateIndex(
                name: "IX_RegionLocation_IdRegion",
                table: "RegionLocation",
                column: "IdRegion");

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
        }
    }
}
