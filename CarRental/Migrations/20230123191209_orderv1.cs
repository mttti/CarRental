using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class orderv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256,
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "TEXT",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "26481377-54b6-4866-9552-673295ea5e98", 0, "dd7374cf-0808-4151-8f9a-ab4ca80f96d1", "AppUser", "admin@admin.pl", false, "Magiera", false, null, "Mateusz", "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAEAACcQAAAAEPc+6OPXtoNaoQaaSGROehJrzyWA7UKbgZUY/1vrvJnLScJhlpzlO/DgD824QErN+Q==", null, false, "04f15619-c967-4cac-90bc-2caa9b58f82c", false, "Admin" },
                    { "a4d55acc-2778-48ed-bd6e-7d454db01b09", 0, "d313ec76-03b4-4702-94ed-f01e8612f8d0", "AppUser", "jnowak@interia.pl", false, "Kowalski", false, null, "Jan", "JNOWAK@INTERIA.PL", "NOWAK_JAN", "AQAAAAEAACcQAAAAEGPtAB3G3qJbrt1iktujvuLXeyoeu6FF8esAzG1A9J5Z/kzAYzXGNuVwISKphWcqIQ==", null, false, "dcce6f59-da7d-42c4-9976-c6a63bba746a", false, "Nowak_Jan" },
                    { "ff023250-c33f-48c2-80b8-703f5ab34531", 0, "e8ee6c45-9439-414f-a87a-048464c0d06b", "AppUser", "Mietekmechanik@onet.pl", false, "Kowalski", false, null, "Mieczyslaw", "MIETEKMECHANIK@ONET.PL", "MIETEKMECHANIK", "AQAAAAEAACcQAAAAEP8+k+wIFP3t6+Qw8DA1T5p3gA//4uMOlZiv8qMBAq6RDhpE8r44HM6DgxaWpZRHCg==", null, false, "64cd658c-d672-4616-95ed-965bb589a020", false, "MietekMechanik" }
                });
        }
    }
}
