using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class carModelv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "cars",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "e2ab69d9-2032-431b-b82b-bd66e5643b4d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "2a48fe79-835d-49a6-b816-d0fd3c0512a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd7374cf-0808-4151-8f9a-ab4ca80f96d1", "AQAAAAEAACcQAAAAEPc+6OPXtoNaoQaaSGROehJrzyWA7UKbgZUY/1vrvJnLScJhlpzlO/DgD824QErN+Q==", "04f15619-c967-4cac-90bc-2caa9b58f82c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d313ec76-03b4-4702-94ed-f01e8612f8d0", "AQAAAAEAACcQAAAAEGPtAB3G3qJbrt1iktujvuLXeyoeu6FF8esAzG1A9J5Z/kzAYzXGNuVwISKphWcqIQ==", "dcce6f59-da7d-42c4-9976-c6a63bba746a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8ee6c45-9439-414f-a87a-048464c0d06b", "AQAAAAEAACcQAAAAEP8+k+wIFP3t6+Qw8DA1T5p3gA//4uMOlZiv8qMBAq6RDhpE8r44HM6DgxaWpZRHCg==", "64cd658c-d672-4616-95ed-965bb589a020" });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Model",
                value: "M850i");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Model",
                value: "A3");

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Model",
                value: "C5");

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Przyjemny samochód");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Model",
                table: "cars");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "360c7518-36a9-40f7-8ee7-a1bc489c15fb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "f7640d16-4474-46fa-834b-8bcef9570c8b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a437b19-34b6-4f7b-a2eb-52cb5661bf5b", "AQAAAAEAACcQAAAAEChrzaLd0PBvn8uaQB/dm4UQbpZmBUSAVEnP97LMn/z7xdNqi2ueFWePQMM9VTh+Mw==", "a35d9a19-0724-42c3-8384-095bea85d803" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "634b9f59-54ef-4c20-b5a9-93ffa10ed777", "AQAAAAEAACcQAAAAEFUkvK9a0qe/sDJXkAptReVirRLBeX84S8Ombqk3E6pmDVsPOA7y7/OlSOANIk6yLw==", "7e2b8b8e-490c-4989-9710-3bd73507fd83" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe665c09-1d2d-4cfb-ade1-2f68efa79445", "AQAAAAEAACcQAAAAEDwHPnG/OHh0bEpzU6OIUWQ9jaQm8FSZaVxqewky2P9uIYvXsDTVHiGy/m26wSTGfg==", "6a40d104-2137-4e9e-9487-2dea55cc677a" });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Przyjemnyd samochód");
        }
    }
}
