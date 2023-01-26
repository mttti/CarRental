using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "a14661db-7bd9-4b57-96cf-bdcdaa7e355f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "71fc163b-250a-44ba-bfe2-833da8835f84");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99",
                column: "ConcurrencyStamp",
                value: "d9de1df6-07c4-4748-a6c2-c2aa526b04cf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "LastName", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aabdddcf-a57c-49e0-b23a-0746139f9b39", "Nowojorski", "Jonasz", "AQAAAAEAACcQAAAAEFZwrMSJL3ssZLcC2H5Q3MmvQAXXD1qyXjxRFaNtFrzKAXi1LRNqFZOIj1dhYvKjgw==", "c72a4f9c-541e-465e-97c5-8fef0930154a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be6d377-b3cd-4143-ad9d-c15d020a2d83", "AQAAAAEAACcQAAAAEGPejkgAq9uqdodCjw61ZFevWwxTyUpCvsS5Nr+xwkA9t+KF/cr4mwAM/A4L/WKIgA==", "bdb75318-8f99-4820-b580-3bb365a6cbe3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c6ed26c-fda1-4939-b8fc-0dcc61493844", "AQAAAAEAACcQAAAAECIrRRBR9FMDjrvTLifxHTa8T97Te34i015nGlKkIUaBQ7FB91leJMUb6KOHJW2S3w==", "f43b5130-1fde-479b-8de1-55f91e5466bc" });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "9f1a581a-c16e-4891-964e-c0e5054a151a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "6be36eb1-d114-46de-a474-ab24c48f0bbc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99",
                column: "ConcurrencyStamp",
                value: "0ef639ae-bc2f-40ff-8383-e873119d337d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "LastName", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f015eaf3-5b3b-47e9-adc3-33766a773483", "Magiera", "Mateusz", "AQAAAAEAACcQAAAAEEC19xe2JYKHwo6W52VNnunMQQgG8AI8cj33ml19oo2pbWHfdeTInBgwsxBzVP5yYA==", "a3771fe6-d465-41ae-b8d8-1d8a2a088816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcac8113-424d-4b88-adb3-78fe1e846c75", "AQAAAAEAACcQAAAAECvS28jPNtIVhEjlVO5ndAvNXF57iJiFEBzcaA7pyWTtY1hR2LNo2sAfKdO5xl2Ocg==", "76cacddb-2912-4b28-9e4e-ea6933a51e5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a08b25c-1cbd-4c14-b8b6-7d53de3c6dea", "AQAAAAEAACcQAAAAEGcdp18lCOnlT6RKvbQK0wOoUxJpAaYNqZosBpBZQvFeCUEpU1WGCPTLLB9NVIHqZw==", "243d03cf-fbd5-4e06-8080-22923d02a945" });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderId",
                value: 0);
        }
    }
}
