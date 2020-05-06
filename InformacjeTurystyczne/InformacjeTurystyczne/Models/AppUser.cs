using InformacjeTurystyczne.Models.Tabels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InformacjeTurystyczne.Models
{
    public class AppUser : IdentityUser
    {
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<PermissionParty> PermissionPartys { get; set; }
        public ICollection<PermissionRegion> PermissionRegions { get; set; }
        public ICollection<PermissionShelter> PermissionShelters { get; set; }
        public ICollection<PermissionTrial> PermissionTrials { get; set; }
    }
}
