using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models
{
    // wypełnia bazę danych danymi początkowymi
    public static class DbInitializer
    {
        // Metoda Seed służy do inicjowania bazy danych danymi jeśli nie będzie miała żadnych danych
        public static void Seed(AppDbContext context)
        {
            /*
             * if(!context.Schroniska.Any)
             * {
             *  context.AddRange(
             *  new Schronisko {Opis = "Bla bla", jakies inne pola}, // BEZ ID!!!
             *  new Schronisko { Opis = "opis"}
             *  );
             * }
             */

            // zapisujemy zmiany
            context.SaveChanges();
        }
    }
}
