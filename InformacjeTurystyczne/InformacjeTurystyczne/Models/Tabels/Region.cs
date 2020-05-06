﻿using System;
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

        [Display(Name = "Nazwa regionu")]
        public string Name { get; set; }

        public ICollection<Message> Message { get; set; }
        public ICollection<Party> Party { get; set; }
        public ICollection<RegionLocation> RegionLocation { get; set; }
        public ICollection<Shelter> Shelter { get; set; }
        public ICollection<PermissionRegion> PermissionRegion {get; set;}
        public ICollection<Subscription> Subscription { get; set; }
        public ICollection<Attraction> Attraction { get; set; }
    }
}
