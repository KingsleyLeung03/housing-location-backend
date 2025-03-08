namespace housing_location_backend.Models
{
    public class HousingLocation
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string City { get; set; }
        public required string State { get; set; }
        public required string Photo { get; set; }
        public int AvailableUnits { get; set; }
        public bool Wifi { get; set; }
        public bool Laundry { get; set; }
    }
}
