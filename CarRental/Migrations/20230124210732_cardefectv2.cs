using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class cardefectv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReported",
                table: "orders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "carDefects",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "3d1fbe6c-b122-416c-8b64-e2eac574a4e6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "b48a0f64-58b6-4e7a-a7fd-ce581e53bdf0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9fb800-e1a0-4cc2-b5ef-03e7c6c436fa", "AQAAAAEAACcQAAAAEI7Z/ucQZMSrJS6r9S/1SRa+MleCKIx1j/rl77RIWrxJ9iAA4yT2SyGAiMm8lc/2Sg==", "c9af12dc-06b9-4c07-90a1-a1d1806b4861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c624582a-d505-4c1b-84ae-fcc92b822788", "AQAAAAEAACcQAAAAEP8ZQnci/WJox6CgX5ia6pNOanJBXWGF3WH4hDQeMXzxRSjBlVJ+ztR3fRGo3/+/FQ==", "c0e39d60-bccd-4802-9ae7-d91890784f4d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8ec117c-735c-4213-826b-94a7cb61ee9a", "AQAAAAEAACcQAAAAEEERVFY7dxV8s3hm2p+ItFjaMQ6Cl49dtsobSg4D3DX4nhKFvXcK3qKIkq97vXRaig==", "ca895505-d6dc-4adc-9ba3-416648bdf7a8" });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsReported",
                value: false);

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsReported",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReported",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "carDefects");

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
    }
}
