using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class regv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99", "1c395c91-8cd0-42f9-8f4a-cec42ad41657", "uzytkownik", "UZYTKOWNIK" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2293ff5-14f7-4a5d-8e36-6ec3107d0f99");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "e0dfae77-2ba5-4970-9856-213d6b2c4eaa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "5431dcee-3dac-442c-ac02-7ed37ff07d78");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ded9306d-78e7-4573-aeb8-b5450d61f554", "AQAAAAEAACcQAAAAECowvuqf3aWKmFunftjl/w0BREitLzS6Tlr9qkDfsUsGPCxuva/Dmxtb/e7sjqsgaw==", "55b01c20-7fb9-48ef-b8fb-d0c19a3e9a39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a94ebf6-809e-4dad-9854-3a7002295339", "AQAAAAEAACcQAAAAEJytVteZhGMb2/FnwlZBi4E9ER6pI0XLnM+L/9S2yvL104lCaTVGauFVTvdnmKck6Q==", "bcafecdb-ecf9-4d27-815d-81ea7cd77224" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10bb4ec6-8d72-4550-a1dd-042a5f0a3e81", "AQAAAAEAACcQAAAAEFcJtsnfVOGu8mdqXNKmX0ujuoU5Yot2xnR/tmXwu1Ze/aJB3BpyJUdicYMndIMcDw==", "4e096f53-9f45-4d18-962e-92c6d8ccf592" });
        }
    }
}
