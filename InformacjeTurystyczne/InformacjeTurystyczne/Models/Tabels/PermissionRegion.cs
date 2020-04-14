using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class PermissionRegion
    {
        [Key]
        public int IdPermissionRegion { get; set; }

        //[ForeignKey("Region")]
        public int? IdRegion { get; set; }
        public Region Region { get; set; }

        // USER ???
    }
}
