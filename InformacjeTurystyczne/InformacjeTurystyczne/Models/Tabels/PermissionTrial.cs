using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class PermissionTrial
    {
        [Key]
        public int IdPermissionTrial { get; set; }

        [ForeignKey("Trial")]
        public int? IdTrial { get; set; }
        public Trial Trial { get; set; }

        // USER ???
    }
}
