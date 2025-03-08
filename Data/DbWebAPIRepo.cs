using housing_location_backend.Models;
using Microsoft.EntityFrameworkCore;

namespace housing_location_backend.Data
{
    public class DbWebAPIRepo : IWebAPIRepo
    {
        private readonly WebAPIDbContext _DbContext;

        public DbWebAPIRepo(WebAPIDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        public IEnumerable<HousingLocation> GetAllHousingLocations()
        {
            return _DbContext.HousingLocations;
        }

        public HousingLocation? GetHousingLocationById(int id)
        {
            return _DbContext.HousingLocations.FirstOrDefault(h => h.Id == id);
        }
    }
}