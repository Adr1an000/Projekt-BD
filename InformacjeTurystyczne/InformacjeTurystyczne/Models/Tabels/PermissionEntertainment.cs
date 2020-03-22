using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class PermissionEntertainment
    {
        public int Id { get; set; } // K

        public int ID_Entertainment { get; set; } // FK
        public int ID_User { get; set; } // FK
    }
}
