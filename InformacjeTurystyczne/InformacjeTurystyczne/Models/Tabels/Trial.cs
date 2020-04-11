using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Trial
    {
        [Key]
        public int IdTrial { get; set; } // K

        public string Colour { get; set; }
        public bool Open { get; set; }
        public string Feedback { get; set; }
        public float Length { get; set; }
        public int Difficulty { get; set; }
        public string Description { get; set; }

        public ICollection<RegionLocation> RegionLocation { get; set; }
        public ICollection<PermissionTrial> PermissionTrial { get; set; }
    }
}
