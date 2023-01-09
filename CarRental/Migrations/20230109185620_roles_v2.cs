using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class rolesv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0773fad5-d7e7-47e1-9ef8-6fad8120694f", "26481377-54b6-4866-9552-673295ea5e98" },
                    { "5d1880d4-bc4a-4873-9043-5320c72b35c0", "ff023250-c33f-48c2-80b8-703f5ab34531" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0773fad5-d7e7-47e1-9ef8-6fad8120694f", "26481377-54b6-4866-9552-673295ea5e98" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5d1880d4-bc4a-4873-9043-5320c72b35c0", "ff023250-c33f-48c2-80b8-703f5ab34531" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "a5796b19-8a7d-460d-a3f8-8ee9d4b2ff99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "6faa80c8-53f8-4566-ae75-0a8cf1135220");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5248b1-a21b-418b-ac10-1abc6d5875b1", "AQAAAAEAACcQAAAAEFeknyCuIo+gHhv9YBGXLEW24TZIVpKXaoYr2ulxmBNz8piIVq62ShxfIjD8up2Oqw==", "333d4998-0339-4273-b408-27cd2eea0091" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8624c5c5-4919-4163-b57a-ddda5aa7edfe", "AQAAAAEAACcQAAAAEGBhA3gO6T/FSlyHRZbVsjNkndXqJA7KRt+TGIdoOpcp2vgt6H39i87klKchU9eRdQ==", "d6c81550-5636-4061-83d6-efbe01f45d02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e7a8c57-046e-4bf8-b813-e251f270e949", "AQAAAAEAACcQAAAAEIRTivmo5STqNNn8ZcmAPn67lopdKhPqf7P6gazOnnzpII7Dt/kKRRWy8WakIa8kEA==", "178c111f-1feb-4b39-9971-951ff23db658" });
        }
    }
}
