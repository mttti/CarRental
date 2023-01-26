using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class Carv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    ImgSrc = table.Column<string>(type: "TEXT", nullable: false),
                    PriceListId = table.Column<int>(type: "INTEGER", nullable: true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Mileage = table.Column<int>(type: "INTEGER", nullable: false),
                    IsBroken = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cars_priceLists_PriceListId",
                        column: x => x.PriceListId,
                        principalTable: "priceLists",
                        principalColumn: "PriceListId");
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Color", "Description", "ImgSrc", "IsBroken", "Mileage", "PriceListId" },
                values: new object[,]
                {
                    { 1, "Czarny", "Czarne bmw. Szybsze niż wiatr.", "bmw.png", false, 100, null },
                    { 2, "Czerwony", "Czerwone audi. Brak dachu zwiększa przyspieszenie.", "audi.png", false, 40, null },
                    { 3, "Biały", "Biały Citroen. Duże gabarty pozwolą na komfortowe podróże dla całej rodziny.", "citroen.png", false, 200, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cars_PriceListId",
                table: "cars",
                column: "PriceListId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
