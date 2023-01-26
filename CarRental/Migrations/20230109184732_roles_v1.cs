using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class rolesv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6651635-b38e-4ac5-b369-4522d82fbd46");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0773fad5-d7e7-47e1-9ef8-6fad8120694f", "a5796b19-8a7d-460d-a3f8-8ee9d4b2ff99", "admin", "ADMIN" },
                    { "5d1880d4-bc4a-4873-9043-5320c72b35c0", "6faa80c8-53f8-4566-ae75-0a8cf1135220", "mechanik", "MECHANIK" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26481377-54b6-4866-9552-673295ea5e98", 0, "ab5248b1-a21b-418b-ac10-1abc6d5875b1", "AppUser", "admin@admin.pl", false, "Magiera", false, null, "Mateusz", "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAEAACcQAAAAEFeknyCuIo+gHhv9YBGXLEW24TZIVpKXaoYr2ulxmBNz8piIVq62ShxfIjD8up2Oqw==", null, false, "333d4998-0339-4273-b408-27cd2eea0091", false, "Admin" },
                    { "a4d55acc-2778-48ed-bd6e-7d454db01b09", 0, "8624c5c5-4919-4163-b57a-ddda5aa7edfe", "AppUser", "jnowak@interia.pl", false, "Kowalski", false, null, "Jan", "JNOWAK@INTERIA.PL", "NOWAK_JAN", "AQAAAAEAACcQAAAAEGBhA3gO6T/FSlyHRZbVsjNkndXqJA7KRt+TGIdoOpcp2vgt6H39i87klKchU9eRdQ==", null, false, "d6c81550-5636-4061-83d6-efbe01f45d02", false, "Nowak_Jan" },
                    { "ff023250-c33f-48c2-80b8-703f5ab34531", 0, "0e7a8c57-046e-4bf8-b813-e251f270e949", "AppUser", "Mietekmechanik@onet.pl", false, "Kowalski", false, null, "Mieczyslaw", "MIETEKMECHANIK@ONET.PL", "MIETEKMECHANIK", "AQAAAAEAACcQAAAAEIRTivmo5STqNNn8ZcmAPn67lopdKhPqf7P6gazOnnzpII7Dt/kKRRWy8WakIa8kEA==", null, false, "178c111f-1feb-4b39-9971-951ff23db658", false, "MietekMechanik" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6651635-b38e-4ac5-b369-4522d82fbd46", 0, "f50aee30-e9d5-4302-b067-39cdc185fc3e", "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAEAACcQAAAAEC8C9WqKKJ5S+jWzvUzjaBp6Zf+V/m7vxBfuGUbA3huUvQNALKWifPm+Y4BfRjtG/w==", null, false, "1db694cc-78b0-4b22-8a6f-972907dfd69e", false, "Admin" });
        }
    }
}
