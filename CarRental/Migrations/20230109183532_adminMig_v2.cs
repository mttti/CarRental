using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class adminMigv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f2e02d9-8faa-455c-b412-0168a319c383");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6651635-b38e-4ac5-b369-4522d82fbd46", 0, "f50aee30-e9d5-4302-b067-39cdc185fc3e", "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAEAACcQAAAAEC8C9WqKKJ5S+jWzvUzjaBp6Zf+V/m7vxBfuGUbA3huUvQNALKWifPm+Y4BfRjtG/w==", null, false, "1db694cc-78b0-4b22-8a6f-972907dfd69e", false, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6651635-b38e-4ac5-b369-4522d82fbd46");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2f2e02d9-8faa-455c-b412-0168a319c383", 0, "2be079c3-6e92-4736-8d6a-7c81b5d9f7e6", "admin@admin.pl", false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEAyE7defwmoEqXXxRBXk6s5p90lMOPWH0LgKvrHkbPaZ3M7eQnMtQtjT67ck5jATVA==", null, false, "0d2303d1-66ca-4798-abb8-ec0d8e96dc13", false, "Admin" });
        }
    }
}
