using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace housing_location_backend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HousingLocations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Photo = table.Column<string>(type: "TEXT", nullable: false),
                    AvailableUnits = table.Column<int>(type: "INTEGER", nullable: false),
                    Wifi = table.Column<bool>(type: "INTEGER", nullable: false),
                    Laundry = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HousingLocations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "HousingLocations",
                columns: new[] { "Id", "AvailableUnits", "City", "Laundry", "Name", "Photo", "State", "Wifi" },
                values: new object[,]
                {
                    { 1, 4, "Chicago", true, "Acme Fresh Start Housing", "https://angular.dev/assets/images/tutorials/common/bernard-hermant-CLKGGwIBTaY-unsplash.jpg", "IL", true },
                    { 2, 0, "Santa Monica", true, "A113 Transitional Housing", "https://angular.dev/assets/images/tutorials/common/brandon-griggs-wR11KBaB86U-unsplash.jpg", "CA", false },
                    { 3, 1, "Juneau", false, "Warm Beds Housing Support", "https://angular.dev/assets/images/tutorials/common/i-do-nothing-but-love-lAyXdl1-Wmc-unsplash.jpg", "AK", false },
                    { 4, 1, "Chicago", false, "Homesteady Housing", "https://angular.dev/assets/images/tutorials/common/ian-macdonald-W8z6aiwfi1E-unsplash.jpg", "IL", true },
                    { 5, 1, "Gary", false, "Happy Homes Group", "https://angular.dev/assets/images/tutorials/common/krzysztof-hepner-978RAXoXnH4-unsplash.jpg", "IN", true },
                    { 6, 2, "Oakland", true, "Hopeful Apartment Group", "https://angular.dev/assets/images/tutorials/common/r-architecture-JvQ0Q5IkeMM-unsplash.jpg", "CA", true },
                    { 7, 5, "Oakland", true, "Seriously Safe Towns", "https://angular.dev/assets/images/tutorials/common/phil-hearing-IYfp2Ixe9nM-unsplash.jpg", "CA", true },
                    { 8, 2, "Oakland", true, "Hopeful Housing Solutions", "https://angular.dev/assets/images/tutorials/common/r-architecture-GGupkreKwxA-unsplash.jpg", "CA", true },
                    { 9, 10, "Oakland", false, "Seriously Safe Towns", "https://angular.dev/assets/images/tutorials/common/saru-robert-9rP3mxf8qWI-unsplash.jpg", "CA", false },
                    { 10, 6, "Portland", true, "Capital Safe Towns", "https://angular.dev/assets/images/tutorials/common/webaliser-_TPTXZd9mOo-unsplash.jpg", "OR", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HousingLocations");
        }
    }
}
