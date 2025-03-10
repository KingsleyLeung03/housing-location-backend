using Microsoft.EntityFrameworkCore;
using housing_location_backend.Models;

namespace housing_location_backend.Data
{
    public class WebAPIDbContext(DbContextOptions<WebAPIDbContext> options) : DbContext(options)
    {
        public DbSet<HousingLocation> HousingLocations => Set<HousingLocation>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HousingLocation>()
            .HasData(
                new HousingLocation { Id = 1, Name = "Acme Fresh Start Housing", City = "Chicago", State = "IL", Photo = "https://angular.dev/assets/images/tutorials/common/bernard-hermant-CLKGGwIBTaY-unsplash.jpg", AvailableUnits = 4, Wifi = true, Laundry = true },
                new HousingLocation { Id = 2, Name = "A113 Transitional Housing", City = "Santa Monica", State = "CA", Photo = "https://angular.dev/assets/images/tutorials/common/brandon-griggs-wR11KBaB86U-unsplash.jpg", AvailableUnits = 0, Wifi = false, Laundry = true },
                new HousingLocation { Id = 3, Name = "Warm Beds Housing Support", City = "Juneau", State = "AK", Photo = "https://angular.dev/assets/images/tutorials/common/i-do-nothing-but-love-lAyXdl1-Wmc-unsplash.jpg", AvailableUnits = 1, Wifi = false, Laundry = false },
                new HousingLocation { Id = 4, Name = "Homesteady Housing", City = "Chicago", State = "IL", Photo = "https://angular.dev/assets/images/tutorials/common/ian-macdonald-W8z6aiwfi1E-unsplash.jpg", AvailableUnits = 1, Wifi = true, Laundry = false },
                new HousingLocation { Id = 5, Name = "Happy Homes Group", City = "Gary", State = "IN", Photo = "https://angular.dev/assets/images/tutorials/common/krzysztof-hepner-978RAXoXnH4-unsplash.jpg", AvailableUnits = 1, Wifi = true, Laundry = false },
                new HousingLocation { Id = 6, Name = "Hopeful Apartment Group", City = "Oakland", State = "CA", Photo = "https://angular.dev/assets/images/tutorials/common/r-architecture-JvQ0Q5IkeMM-unsplash.jpg", AvailableUnits = 2, Wifi = true, Laundry = true },
                new HousingLocation { Id = 7, Name = "Seriously Safe Towns", City = "Oakland", State = "CA", Photo = "https://angular.dev/assets/images/tutorials/common/phil-hearing-IYfp2Ixe9nM-unsplash.jpg", AvailableUnits = 5, Wifi = true, Laundry = true },
                new HousingLocation { Id = 8, Name = "Hopeful Housing Solutions", City = "Oakland", State = "CA", Photo = "https://angular.dev/assets/images/tutorials/common/r-architecture-GGupkreKwxA-unsplash.jpg", AvailableUnits = 2, Wifi = true, Laundry = true },
                new HousingLocation { Id = 9, Name = "Seriously Safe Towns", City = "Oakland", State = "CA", Photo = "https://angular.dev/assets/images/tutorials/common/saru-robert-9rP3mxf8qWI-unsplash.jpg", AvailableUnits = 10, Wifi = false, Laundry = false },
                new HousingLocation { Id = 10, Name = "Capital Safe Towns", City = "Portland", State = "OR", Photo = "https://angular.dev/assets/images/tutorials/common/webaliser-_TPTXZd9mOo-unsplash.jpg", AvailableUnits = 6, Wifi = true, Laundry = true }
            );
        }
    }
}
