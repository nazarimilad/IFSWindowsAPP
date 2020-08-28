using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ifes.lib.data {
    public class ApplicationDbContext : IdentityDbContext {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
         
        }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
         

            builder.Entity<IdentityUser>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedEmail).HasMaxLength(85));
            builder.Entity<IdentityUser>(entity => entity.Property(m => m.NormalizedUserName).HasMaxLength(85));

            builder.Entity<IdentityRole>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityRole>(entity => entity.Property(m => m.NormalizedName).HasMaxLength(85));

            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.ProviderKey).HasMaxLength(85));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));

            builder.Entity<IdentityUserRole<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));

            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.LoginProvider).HasMaxLength(85));
            builder.Entity<IdentityUserToken<string>>(entity => entity.Property(m => m.Name).HasMaxLength(85));

            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.Property(m => m.UserId).HasMaxLength(85));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.Id).HasMaxLength(85));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.Property(m => m.RoleId).HasMaxLength(85));



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.EnableSensitiveDataLogging();
        }


        // Catalog stuf
        public DbSet<MultiMedia> MultiMedia { get; set; }
        public DbSet<Beverage> Beverage { get; set; }
        public DbSet<Catalog> Catalog{ get; set; }
        public DbSet<CatalogItem> CatalogItem { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Video> Video { get; set; }
        public DbSet<Audio> Audio { get; set; }

        //plane stuff
        public DbSet<Airport> Airport { get; set; }
        public DbSet<FlightInfo> FlightInfo { get; set; }
        public DbSet<Plane> Plane { get; set; }
        public DbSet<Seat> Seat { get; set; }

        //users
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public  DbSet<CabinCrew> CabinCrew { get; set; }
        public  DbSet<Passenger> Passenger { get; set; }

    }
}