using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class adminMigv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2f2e02d9-8faa-455c-b412-0168a319c383", 0, "2be079c3-6e92-4736-8d6a-7c81b5d9f7e6", "admin@admin.pl", false, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEAyE7defwmoEqXXxRBXk6s5p90lMOPWH0LgKvrHkbPaZ3M7eQnMtQtjT67ck5jATVA==", null, false, "0d2303d1-66ca-4798-abb8-ec0d8e96dc13", false, "Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f2e02d9-8faa-455c-b412-0168a319c383");
        }
    }
}
