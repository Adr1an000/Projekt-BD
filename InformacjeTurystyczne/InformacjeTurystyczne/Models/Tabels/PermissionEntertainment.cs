using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class PermissionEntertainment
    {
        [Key]
        public int IdPermissionEntertainment { get; set; } // K

        //[ForeignKey("Entertainment")]
        public int? IdEntertainment { get; set; }
        public Entertainment Entertainment { get; set; }

        // USER ???
        public string IdUser { get; set; }
        public AppUser User { get; set; }
    }
}
