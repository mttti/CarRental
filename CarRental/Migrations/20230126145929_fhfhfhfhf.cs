using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class fhfhfhfhf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99", "a4d55acc-2778-48ed-bd6e-7d454db01b09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "f015eaf3-5b3b-47e9-adc3-33766a773483", "AQAAAAEAACcQAAAAEEC19xe2JYKHwo6W52VNnunMQQgG8AI8cj33ml19oo2pbWHfdeTInBgwsxBzVP5yYA==", null, "a3771fe6-d465-41ae-b8d8-1d8a2a088816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "dcac8113-424d-4b88-adb3-78fe1e846c75", "AQAAAAEAACcQAAAAECvS28jPNtIVhEjlVO5ndAvNXF57iJiFEBzcaA7pyWTtY1hR2LNo2sAfKdO5xl2Ocg==", null, "76cacddb-2912-4b28-9e4e-ea6933a51e5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "Role", "SecurityStamp" },
                values: new object[] { "5a08b25c-1cbd-4c14-b8b6-7d53de3c6dea", "AQAAAAEAACcQAAAAEGcdp18lCOnlT6RKvbQK0wOoUxJpAaYNqZosBpBZQvFeCUEpU1WGCPTLLB9NVIHqZw==", null, "243d03cf-fbd5-4e06-8080-22923d02a945" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99", "a4d55acc-2778-48ed-bd6e-7d454db01b09" });

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "b576b8f8-0954-4a9a-a792-12e30a972d4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "d25fff5f-5d37-48d3-9e1f-26c05cfc9191");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99",
                column: "ConcurrencyStamp",
                value: "1c395c91-8cd0-42f9-8f4a-cec42ad41657");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eba0fc6-e8a5-4187-b15b-dc6dbe27388d", "AQAAAAEAACcQAAAAEPU/gnnZJ1lzhJUQQG1di8y/XD11hDWv3+IV/TNubMfiwu7skU1rY+WlbKVz5v32OA==", "5aa45411-dc5b-4402-a7c2-ee0e1e87f9b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6cf5e67-2865-4ee2-852e-4c20898d22e2", "AQAAAAEAACcQAAAAEGZfkBVyaUwcc6h1zIKWgwkI7H+iW5YAYue0HkP/xFOmo6pGcj66ElkMZugAarSjlQ==", "29532793-68e6-4397-a95d-044d70e4a75a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "871d3f77-d87a-4588-ad63-96dd1aa880ef", "AQAAAAEAACcQAAAAEFTbp/nvfxuoEh4PyAv0rdKLNQwLV6zpooms6UZtJVXDDj9Ll9dTMqSXlSYKnUzlsg==", "5d373001-34c4-4422-bf82-ed69abfdeeb5" });
        }
    }
}
