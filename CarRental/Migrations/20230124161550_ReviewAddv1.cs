using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class ReviewAddv1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userName",
                table: "reviews",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "3fee70e6-f0a5-44c3-8428-49db946c83ed");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "a51f27b8-ee51-49d1-bba1-53bf84b08b1c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "634f4088-2dbe-4a6e-848c-926cbc1c1642", "AQAAAAEAACcQAAAAEIlZtIg6QJoEMxvc9wiQdelj9QrWJyBfPz21TINIyQT+RDGutc2nTNlE4ABY/q9TWQ==", "62f7e396-2721-4398-a1e3-8b85b096a9e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e427dde5-3b71-4e80-a32c-e12fdfafb9d7", "AQAAAAEAACcQAAAAEIbxCHdCr1Zd+2xJEmr2j3u2uiuU9GaVVwBr31/urfesYgBny8D2e+ABd4zjz2eozQ==", "4a1aaaa7-4ad6-4469-8f2a-7e26704334a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "337a04de-592d-47e3-951c-9d26117c62b6", "AQAAAAEAACcQAAAAEPCE7kk9YcRLVCLOA7McUf6cUZm+2nsn22lBdEtdms/dMxiYK3vSjAzs7zAsH77oQA==", "131b2206-1a8c-476f-b2c0-e9cd57779253" });

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "userName",
                value: "Joanna");

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "userName",
                value: "Jakub");

            migrationBuilder.UpdateData(
                table: "reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "userName",
                value: "Michał");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userName",
                table: "reviews");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "a791bdd3-5c84-4127-8a5e-30ea00053e74");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "bbd772be-bdb4-45da-ad02-295b10ab994d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d98b35ac-f908-47b5-9724-f242407ea6ce", "AQAAAAEAACcQAAAAEIDpAraos4uykIDiLTlD40nCu8pLw49ZymKur3iGCmoASDTXcFYi8jsZiongzrOcaA==", "1851eaf2-6c1e-4ad3-9d32-0c10b809d092" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3fea800-cd83-433f-8e2f-3ffcea6dbed7", "AQAAAAEAACcQAAAAEK6HHVYMhXVENy8E+et5p18It3aG2HyDEVJAs/ItPn2CJpZy3yXGoGgDmZB6Rq9DMA==", "842232c1-9f31-4921-8798-ee34966a0ee8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "588ae5ee-6b93-47d6-b3f3-a6e57790a836", "AQAAAAEAACcQAAAAEL0BznlE0gFKLn0xrYBpv+t1IZH6silp2tROCLVxDqYLe12NdI1d0u6kQWUMCOZwfg==", "ecfd2def-d4bf-4175-be20-0248c1d21aba" });
        }
    }
}
