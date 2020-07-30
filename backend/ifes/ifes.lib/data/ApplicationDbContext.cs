using ifes.lib.domain.Catalogs;
using ifes.lib.domain.Planes;
using ifes.lib.domain.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ifes.lib.data {
    public class ApplicationDbContext : IdentityDbContext {

        
        // Catalog stuf
        public DbSet<MultiMedia> MultiMedia { get; set; }
        public DbSet<Beverage> Beverage { get; set; }
        public DbSet<Catalog> Catalog{ get; set; }
        public DbSet<CatalogItem> CatalogItem { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Video> Video { get; set; }
        
        //plane stuff
        public DbSet<Airport> Airport { get; set; }
        public DbSet<FlightInfo> FlightInfo { get; set; }
        public DbSet<Plane> Plane { get; set; }
        public DbSet<Seat> Seat { get; set; }
        
        //users
        public  DbSet<CabinCrew> CabinCrew { get; set; }
        public  DbSet<Passenger> Passenger { get; set; }

    }
}