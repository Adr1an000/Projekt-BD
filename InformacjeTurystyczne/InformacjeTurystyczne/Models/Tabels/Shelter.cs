using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Shelter
    {
        [Key]
        public int IdShelter { get; set; }

        public string Name { get; set; }
        public int MaxPlaces { get; set; }
        public int Places { get; set; }
        public bool IsOpen { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }

       // [ForeignKey("Region")]
        public int IdRegion { get; set; }
        [Display(Name = "Region")]
        public Region Region { get; set; }

        public ICollection<PermissionShelter> PermissionShelters { get; set; }
    }
}
