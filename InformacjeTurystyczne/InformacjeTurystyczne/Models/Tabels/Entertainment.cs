using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Entertainment
    {
        [Key]
        public int IdEntertainment { get; set; } // K

        public string Name { get; set; }
        public string PlaceDescription { get; set; }
        public string Description { get; set; }
        public bool UpToDate { get; set; }

        [ForeignKey("Region")]
        public int? IdRegion { get; set; }
        public Region Region { get; set; }

        public ICollection<PermissionEntertainment> PermissionEntertainment { get; set; }
    }
}
