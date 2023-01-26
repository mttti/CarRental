using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class isreviewed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "reviews",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsReviewed",
                table: "orders",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsReviewed",
                value: false);

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsReviewed",
                value: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "reviews");

            migrationBuilder.DropColumn(
                name: "IsReviewed",
                table: "orders");

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
        }
    }
}
