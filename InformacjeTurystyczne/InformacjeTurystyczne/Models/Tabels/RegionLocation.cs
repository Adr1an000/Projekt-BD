using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class RegionLocation
    {
        public int Id { get; set; } // K

        public int ID_Trial { get; set; } // FK
        public int ID_Region { get; set; } // FK
    }
}
