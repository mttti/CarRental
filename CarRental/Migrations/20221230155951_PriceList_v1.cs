using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class PriceListv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "priceLists",
                columns: table => new
                {
                    PriceListId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    BasePrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    CarType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_priceLists", x => x.PriceListId);
                });

            migrationBuilder.InsertData(
                table: "priceLists",
                columns: new[] { "PriceListId", "BasePrice", "CarType", "Price" },
                values: new object[,]
                {
                    { 1, 800m, "Kabriolet", 400m },
                    { 2, 200m, "Kompakt", 100m },
                    { 3, 500m, "SUV", 250m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "priceLists");
        }
    }
}
