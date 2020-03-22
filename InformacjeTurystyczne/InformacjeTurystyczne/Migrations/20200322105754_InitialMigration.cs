using Microsoft.EntityFrameworkCore.Migrations;

namespace InformacjeTurystyczne.Migrations
{
    public partial class InitialMigration : Migration
    {
        // zawiera cały kod do stworzenia bazy danych (autoamtycznie się to robi komentami w konsoli
        // menadżera pakietów komendą add-migration NazwaMigracji
        // jak jest NazwaMigracji to chodzi to o to, że jak np dodajemy nową tabelę
        // to nazywamy to coś w stylu NewTableUzytkownicyMigration
        protected override void Up(MigrationBuilder migrationBuilder)
        {

        }

        // służy do usuwania tabeli powyżej
        // komenda update-databse w konsoli menadżera pakietów aktualizuje nam bazę danych do
        // najnowszej migracji
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
