using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class PermissionShelter
    {
        //[Key]
        //public int IdPermissionShelter { get; set; }

        //[ForeignKey("Shelter")]
        public int? IdShelter { get; set; }
        public Shelter Shelter { get; set; }

        // USER ???
        public string IdUser { get; set; }
        public AppUser User { get; set; }
    }
}
