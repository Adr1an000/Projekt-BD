using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using InformacjeTurystyczne.Models.Tabels;

namespace InformacjeTurystyczne.Models
{
    public class AllTabels
    {
        public List<Category> Categories { get; set; }
        public List<Entertainment> Entertainments { get; set; }
        public List<Message> Messages { get; set; }
        public List<PermissionEntertainment> PermissionEntertainments { get; set; }
        public List<PermissionRegion> PermissionRegions { get; set; }
        public List<PermissionShelter> PermissionShelters { get; set; }
        public List<PermissionTrial> PermissionTrials { get; set; }
        public List<Region> Regions { get; set; }
        public List<RegionLocation> RegionLocations { get; set; }
        public List<Shelter> Shelters { get; set; }
        public List<Subscription> Subscriptions { get; set; }
        public List<Trial> Trials { get; set; }
    }
}
