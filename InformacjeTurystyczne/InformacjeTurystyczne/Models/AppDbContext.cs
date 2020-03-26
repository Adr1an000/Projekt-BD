using InformacjeTurystyczne.Models.Tabels;
using Microsoft.EntityFrameworkCore; // DbContext

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace InformacjeTurystyczne.Models
{
    /*
     * Obsługa EF (Entity Framework) Core
     * Klasa stanowi Context Bazy danych
     * Pośrednik między kodem a rzeczywistą bazą danych (agent ruchu)
     * Musi dziedziczyć po DbContext
     * 
     * Misi być instancja DbContextOption, bo nie zadziała (przesłaniamy metodę configuration, lub przekazujemy przez argument konstruktora)
     */
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            // ustalamy które typy będą określone w rzeczywistej bazie danych
            // każdy typ jaki będzie określony w bazie danych jako tabela określamy jako DbSet
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Entertainment> Entertainments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PermissionEntertainment> PermissionEntertainments { get; set; }
        public DbSet<RegionLocation> RegionLocations { get; set; }
        public DbSet<Trial> Trials { get; set; }

        // DbSet<Model np Schronisko> Schroniska {get; set;}
        // EF Core jest świadomy istnienia modelu Schronisko i utworzy odpowiednią tabelę
        // pozniej oczywiście tworzymy model Schronisko (przechowuje stuff typu int id, string cośtam itp)
        // Następnie tworzymy Repozytorium SchroniskoRepository, które dziedziczy po interfejsie ISchroniskoRepository
        // Interfejs ISchroniskoRepository np może mieć metody public Schrnisko PobierzSchroniskoId(int schroniskoId) lub public IEnumerable<Schronisko> PobierzWszystkieSchroniska() itp (takie zapytania gotowce)
        // w SchroniskoRepository musimy mieć dostęp do AppDbContext
        /*
         * private readonly AppDbContext _appDbContext;
         * 
         * ten appDbContext uzyskujemy poprzez "wstrzykiwanie zależności" konstruktora
         * 
         * public SchroniskoRepository(AppDbContext appDbContext)
         * {
         *  _appContext = appContext;
         * }
         * 
         * później implementujemy interfejs
         * np dla wszystkich schronisk // Schroniska to kolekcja utworzona wcześniej
         * return _appDbContext.Schroniska; // za kulisamu sprawdza różne rzeczy automatycznie
         * 
         * np dla danego id
         * return _appDbContext.Schrniska.FirstOrDefault(s=> s.Id = schroniskId);
         */

    }
}
