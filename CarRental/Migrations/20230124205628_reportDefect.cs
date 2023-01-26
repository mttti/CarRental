using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class reportDefect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carDefects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    CarId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carDefects", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "3e36419a-89d0-4c31-bc88-9418b9d593d7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "4c44a13c-83fe-4c7b-97cd-789a197b172a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de3999ea-0fd1-4f52-b0fd-64f25ea6e5d0", "AQAAAAEAACcQAAAAEF2Q8w0vvgx+Pg3C09ypa0xZoZ3HkYRPfOpF0MzrS9pQyc+PafZrv4yl/XiFHWZRvQ==", "dc21864f-f4a6-42fd-bc41-7c06bd3a7fdf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1602460-de2a-4cbd-bbd1-91e0e6895073", "AQAAAAEAACcQAAAAEAvJjS1Mgc1+JIfHcdra2VovsKk3D54O/u94FOjEoxd5pz15p7Bqag0Y8HVZem/Kbw==", "a101897b-f90e-4a8e-aa2d-370dda9d8693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "884d0165-75b6-46f0-af3b-8d15c74559ed", "AQAAAAEAACcQAAAAELUFwWw0eBqlrh7K7bXrnT/EQY7OiVPX8U4bxx8fI0wmfSa3p6GUarJSV9LTh6qv5Q==", "d865a84e-8ef0-4d1a-90d5-315ded0e14de" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carDefects");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "480c7f58-c4c3-417c-960f-e5dbdfe91939");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "5f4dc194-d437-4106-a7cb-6451a566a063");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3879af5-624f-412d-827e-b34a119a3110", "AQAAAAEAACcQAAAAEE0jdrRiLMgLaPxFQQ+WOCZjAJKHK3gMPZaxwzljBQEjgRyK0HYCl7xkzYsJgft9Jg==", "d3f4a965-0c11-4029-adff-9e50b78ccab3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a582408-8eae-4ce3-b673-19850d108f81", "AQAAAAEAACcQAAAAEKszkztNcchSM2jruvdLbugYY8Jg8DynxR8+GsDZx6gzwPBcsSuFBCq/bjh1L1ZkFA==", "363d917b-73d0-4fe7-b691-b6e4aca43736" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ab8d90a-d3d6-43c1-928c-46b3c9fadd11", "AQAAAAEAACcQAAAAEGtEkuFqte2H5xv8B+1iimC7Q/R4uHAOUoAtPf+hGcCnZBoO/96JsGH5bsmq9HbQSA==", "44b7cd00-04e1-472a-874c-0468136515ad" });
        }
    }
}
