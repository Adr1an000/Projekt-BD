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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Entertainment>().ToTable("Entertainment");
            modelBuilder.Entity<Message>().ToTable("Message");
            modelBuilder.Entity<PermissionEntertainment>().ToTable("PermissionEntertainment");
            modelBuilder.Entity<PermissionRegion>().ToTable("PermissionRegion");
            modelBuilder.Entity<PermissionShelter>().ToTable("PermissionShelter");
            modelBuilder.Entity<PermissionTrial>().ToTable("PermissionTrial");
            modelBuilder.Entity<Region>().ToTable("Region");
            modelBuilder.Entity<Shelter>().ToTable("Shelter");
            modelBuilder.Entity<Subscription>().ToTable("Subscription");
            modelBuilder.Entity<RegionLocation>().ToTable("RegionLocation");
            modelBuilder.Entity<Trial>().ToTable("Trial");

            modelBuilder.Entity<Entertainment>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.Entertainment)
                .HasForeignKey(s => s.IdRegion);

            modelBuilder.Entity<Category>()
                .HasMany<Message>(bc => bc.Messages)
                .WithOne(c=>c.Category)
                .HasForeignKey(s => s.IdCategory);
        }
    }
}
