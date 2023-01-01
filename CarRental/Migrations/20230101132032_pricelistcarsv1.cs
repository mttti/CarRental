using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class pricelistcarsv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_priceLists_PriceListId",
                table: "cars");

            migrationBuilder.DropIndex(
                name: "IX_cars_PriceListId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "PriceListId",
                table: "cars");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "cars",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.CreateTable(
                name: "PriceListCars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "INTEGER", nullable: false),
                    PriceListId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceListCars", x => new { x.PriceListId, x.CarID });
                    table.ForeignKey(
                        name: "FK_PriceListCars_cars_CarID",
                        column: x => x.CarID,
                        principalTable: "cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PriceListCars_priceLists_PriceListId",
                        column: x => x.PriceListId,
                        principalTable: "priceLists",
                        principalColumn: "PriceListId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PriceListCars",
                columns: new[] { "CarID", "PriceListId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PriceListCars_CarID",
                table: "PriceListCars",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_priceLists_Id",
                table: "cars",
                column: "Id",
                principalTable: "priceLists",
                principalColumn: "PriceListId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_priceLists_Id",
                table: "cars");

            migrationBuilder.DropTable(
                name: "PriceListCars");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "cars",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "PriceListId",
                table: "cars",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "PriceListId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "PriceListId",
                value: null);

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "PriceListId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_cars_PriceListId",
                table: "cars",
                column: "PriceListId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_priceLists_PriceListId",
                table: "cars",
                column: "PriceListId",
                principalTable: "priceLists",
                principalColumn: "PriceListId");
        }
    }
}
