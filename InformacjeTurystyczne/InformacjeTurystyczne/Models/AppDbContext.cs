using InformacjeTurystyczne.Models.Tabels;
using Microsoft.EntityFrameworkCore; // DbContext

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace InformacjeTurystyczne.Models
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Entertainment> Entertainments { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PermissionEntertainment> PermissionEntertainments { get; set; }
        public DbSet<PermissionRegion> PermissionRegions { get; set; }
        public DbSet<PermissionShelter> PermissionShelters { get; set; }
        public DbSet<PermissionTrial> PermissionTrials { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Shelter> Shelters { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<RegionLocation> RegionLocations { get; set; }
        public DbSet<Trial> Trials { get; set; }
    }
}
