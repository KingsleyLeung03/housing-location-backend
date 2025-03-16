using housing_location_backend.Data;
using housing_location_backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace housing_location_backend.Controllers
{
    [Route("locations")]
    [ApiController]
    public class HousingLocationController(IWebAPIRepo serviceRepo) : ControllerBase
    {
        private readonly IWebAPIRepo _serviceRepo = serviceRepo;

        [HttpGet]
        public ActionResult<IEnumerable<HousingLocation>> GetAllHousingLocations()
        {
            var housingLocations = _serviceRepo.GetAllHousingLocations();
            return Ok(housingLocations);
        }

        [HttpGet("{id}")]
        public ActionResult<HousingLocation> GetHousingLocationById(int id)
        {
            var housingLocation = _serviceRepo.GetHousingLocationById(id + 1);
            if (housingLocation == null)
            {
                return NotFound();
            }
            return Ok(housingLocation);
        }
    }
}