using housing_location_backend.Models;

namespace housing_location_backend.Data
{
    public interface IWebAPIRepo
    {
        IEnumerable<HousingLocation> GetAllHousingLocations();
        HousingLocation? GetHousingLocationById(int id);
        // void CreateHousingLocation(HousingLocation housingLocation);
        // void UpdateHousingLocation(HousingLocation housingLocation);
        // void DeleteHousingLocation(HousingLocation housingLocation);
    }
}