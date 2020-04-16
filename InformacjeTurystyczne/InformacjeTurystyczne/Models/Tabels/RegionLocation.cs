using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class RegionLocation
    {
       // [Key]
       // public int IdRegionLocation { get; set; } // K

       // [ForeignKey("Trial")]
        public int? IdTrial { get; set; }
        public Trial Trial { get; set; }

      //  [ForeignKey("Region")]
        public int? IdRegion { get; set; }
        public Region Region { get; set; }
    }
}
