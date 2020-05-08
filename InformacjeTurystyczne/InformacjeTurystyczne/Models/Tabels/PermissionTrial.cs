using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class PermissionTrail
    {
        //[Key]
        //public int IdPermissionTrail { get; set; }

        //[ForeignKey("Trail")]
        public int? IdTrail { get; set; }
        public Trail Trail { get; set; }

        // USER ???
        public string IdUser { get; set; }
        public AppUser User { get; set; }
    }
}
