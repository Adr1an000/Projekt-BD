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
        public override DbSet<AppUser> Users { get; set; }

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
            modelBuilder.Entity<AppUser>().ToTable("AspNetUsers");

            modelBuilder.Entity<Entertainment>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.Entertainment)
                .HasForeignKey(s => s.IdRegion);

            modelBuilder.Entity<Category>()
                .HasMany<Message>(bc => bc.Messages)
                .WithOne(c=>c.Category)
                .HasForeignKey(s => s.IdCategory);

            modelBuilder.Entity<Message>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.Message)
                .HasForeignKey(s => s.IdRegion);

            modelBuilder.Entity<Message>()
                .HasOne<Category>(bc => bc.Category)
                .WithMany(c => c.Messages)
                .HasForeignKey(s => s.IdCategory);

            /*
            modelBuilder.Entity<PermissionEntertainment>()
                .HasOne<Entertainment>(bc => bc.Entertainment)
                .WithMany(c => c.PermissionEntertainment)
                .HasForeignKey(s => s.IdEntertainment);

            modelBuilder.Entity<PermissionEntertainment>()
                .HasOne<AppUser>(bc => bc.User)
                .WithMany(c => c.PermissionEntertainments)
                .HasForeignKey(s => s.IdUser);

            modelBuilder.Entity<PermissionRegion>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.PermissionRegion)
                .HasForeignKey(c => c.IdRegion);

            modelBuilder.Entity<PermissionRegion>()
                .HasOne<AppUser>(bc => bc.User)
                .WithMany(c => c.PermissionRegions)
                .HasForeignKey(s => s.IdUser);

            modelBuilder.Entity<PermissionShelter>()
                .HasOne<Shelter>(bc => bc.Shelter)
                .WithMany(c => c.PermissionShelters)
                .HasForeignKey(s => s.IdShelter);

            modelBuilder.Entity<PermissionShelter>()
                .HasOne<AppUser>(bc => bc.User)
                .WithMany(c => c.PermissionShelters)
                .HasForeignKey(s => s.IdUser);

            
            modelBuilder.Entity<PermissionTrial>()
                .HasOne<Trial>(bc => bc.Trial)
                .WithMany(c => c.PermissionTrial)
                .HasForeignKey(s => s.IdTrial);

            modelBuilder.Entity<PermissionTrial>()
                .HasOne<AppUser>(bc => bc.User)
                .WithMany(c => c.PermissionTrials)
                .HasForeignKey(s => s.IdUser);
                */

            modelBuilder.Entity<PermissionEntertainment>()
                .HasKey(c => new { c.IdEntertainment, c.IdUser });

            modelBuilder.Entity<PermissionRegion>()
                .HasKey(c => new { c.IdRegion, c.IdUser });

            modelBuilder.Entity<PermissionShelter>()
                .HasKey(c => new { c.IdShelter, c.IdUser });

            modelBuilder.Entity<PermissionTrial>()
                .HasKey(c => new { c.IdTrial, c.IdUser });

            modelBuilder.Entity<RegionLocation>()
                .HasKey(c => new { c.IdRegion, c.IdTrial });

            //REGION??? chyba pozostałe funkcje WithMany() to załatwią (?)

            modelBuilder.Entity<RegionLocation>()
                .HasOne<Trial>(bc => bc.Trial)
                .WithMany(c => c.RegionLocation)
                .HasForeignKey(s => s.IdTrial);

            modelBuilder.Entity<RegionLocation>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.RegionLocation)
                .HasForeignKey(s => s.IdRegion);

            modelBuilder.Entity<Shelter>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.Shelter)
                .HasForeignKey(s => s.IdRegion);

            modelBuilder.Entity<Subscription>()
                .HasOne<Region>(bc => bc.Region)
                .WithMany(c => c.Subscription)
                .HasForeignKey(s => s.IdRegion);

            modelBuilder.Entity<Subscription>()
                .HasOne<AppUser>(bc => bc.User)
                .WithMany(c => c.Subscriptions)
                .HasForeignKey(s => s.IdUser);

            // TRIAL ??? chyba też załatwiony przez funkcje WithMany w pozostałych wywołaniach

            modelBuilder.Entity<AppUser>()
                .HasMany(i => i.PermissionEntertainments)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.IdUser);

            modelBuilder.Entity<AppUser>()
                .HasMany(i => i.PermissionRegions)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.IdUser);

            modelBuilder.Entity<AppUser>()
                .HasMany(i => i.PermissionTrials)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.IdUser);

            modelBuilder.Entity<AppUser>()
                .HasMany(i => i.PermissionShelters)
                .WithOne(i => i.User)
                .HasForeignKey(i => i.IdUser);

            modelBuilder.Entity<Region>()
                .HasMany(i => i.RegionLocation)
                .WithOne(i => i.Region)
                .HasForeignKey(i => i.IdRegion);


        }
    }
}
