using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models.Tabels
{
    public class Region
    {
        [Key]
        public int IdRegion { get; set; }

        public string Name { get; set; }

        public ICollection<Message> Message { get; set; }
        public ICollection<Entertainment> Entertainment { get; set; }
        public ICollection<RegionLocation> RegionLocation { get; set; }
        public ICollection<Shelter> Shelter { get; set; }
        public ICollection<PermissionRegion> PermissionRegion {get; set;}
        public ICollection<Subscription> Subscription { get; set; }
    }
}
