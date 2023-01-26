using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class orderv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Rating = table.Column<int>(type: "INTEGER", nullable: true),
                    DamageDescription = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "a791bdd3-5c84-4127-8a5e-30ea00053e74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "bbd772be-bdb4-45da-ad02-295b10ab994d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d98b35ac-f908-47b5-9724-f242407ea6ce", "AQAAAAEAACcQAAAAEIDpAraos4uykIDiLTlD40nCu8pLw49ZymKur3iGCmoASDTXcFYi8jsZiongzrOcaA==", "1851eaf2-6c1e-4ad3-9d32-0c10b809d092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3fea800-cd83-433f-8e2f-3ffcea6dbed7", "AQAAAAEAACcQAAAAEK6HHVYMhXVENy8E+et5p18It3aG2HyDEVJAs/ItPn2CJpZy3yXGoGgDmZB6Rq9DMA==", "842232c1-9f31-4921-8798-ee34966a0ee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "588ae5ee-6b93-47d6-b3f3-a6e57790a836", "AQAAAAEAACcQAAAAEL0BznlE0gFKLn0xrYBpv+t1IZH6silp2tROCLVxDqYLe12NdI1d0u6kQWUMCOZwfg==", "ecfd2def-d4bf-4175-be20-0248c1d21aba" });

            migrationBuilder.InsertData(
                table: "orders",
                columns: new[] { "Id", "CarId", "DamageDescription", "EndDate", "Price", "Rating", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1600m, null, new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4d55acc-2778-48ed-bd6e-7d454db01b09" },
                    { 2, 3, null, new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1600m, null, new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "a4d55acc-2778-48ed-bd6e-7d454db01b09" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "1bd02e36-f7dc-44af-bd05-75aa4029053c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "f0f3869a-596f-4de3-9eda-bde968b60996");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eaa4fd5d-a14d-4ac0-8a28-648f496e272e", "AQAAAAEAACcQAAAAEIpC/0kGzV/ptB43nuFzAb7sfPEY5EQF43pKv1klaoNiwK3tdWZjGL2WL1etZHziIQ==", "4061cba7-7b11-47d9-a72c-1910749d3c57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64a4ccc2-d4e4-428b-b9c3-4b52825f9679", "AQAAAAEAACcQAAAAEMOKreahMCwyQDK91AclIGQwf8Tj6MxmwnYHa2f7AD0xGSHZHjCIHOw6lGF0JSKwGA==", "f36b9ad1-0eb7-4fab-a1db-389420999c66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8caaa3b-d892-451a-89ac-19ac989ddcc8", "AQAAAAEAACcQAAAAEH7GDPs26vFmWHExGJxy9j254k9JPGss2b2+OFgGhdJWiHDy6YDKAojJ5yn5j7tRcw==", "9c20ebc3-9a1e-4cd0-ba32-57a0ea54dbdb" });
        }
    }
}
