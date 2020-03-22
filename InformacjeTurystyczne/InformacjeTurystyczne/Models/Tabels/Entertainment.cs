using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Entertainment
    {
        public int Id { get; set; } // K

        public string Name { get; set; }
        public string PlaceDescription { get; set; }
        public string Description { get; set; }
        public bool UpToDate { get; set; }

        public int ID_Region { get; set; } // FK
    }
}
