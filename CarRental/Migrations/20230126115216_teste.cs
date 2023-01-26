using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DamageDescription",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "orders");

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

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsBroken",
                value: false);

            migrationBuilder.CreateIndex(
                name: "IX_orders_CarId",
                table: "orders",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_cars_CarId",
                table: "orders",
                column: "CarId",
                principalTable: "cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_cars_CarId",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_CarId",
                table: "orders");

            migrationBuilder.AddColumn<string>(
                name: "DamageDescription",
                table: "orders",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "orders",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0773fad5-d7e7-47e1-9ef8-6fad8120694f",
                column: "ConcurrencyStamp",
                value: "0d7009f1-060b-42e7-8307-56e62ab1f4cd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5d1880d4-bc4a-4873-9043-5320c72b35c0",
                column: "ConcurrencyStamp",
                value: "470cd610-f197-451f-9adc-0b9460e4ca88");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26481377-54b6-4866-9552-673295ea5e98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d436bcf6-00a6-4efb-bdf1-42a9929f776c", "AQAAAAEAACcQAAAAEDCy6DDT5ihtjX6NZ9ODfaHAl4lydLHJbyH4bKzmiA32/KGukB6VrfOC4Qh+mSRO6w==", "8c097c52-6df6-4e90-b24e-049da1548636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4d55acc-2778-48ed-bd6e-7d454db01b09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19c52562-85fc-4a02-9eec-aec6ca8f846e", "AQAAAAEAACcQAAAAEOcpOHefqEtAZAhVNDqWKsOuBPizOf75jkQ21LcXrUG9Udg9i9zmXkwGA5NNilMH5g==", "552ab9ac-c7bb-45fd-8d8b-782cf06641b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff023250-c33f-48c2-80b8-703f5ab34531",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "515f3070-cfce-4526-836c-17306400bf50", "AQAAAAEAACcQAAAAEACYs1adpGPKoeicqELitrlnywycG8P1tlG7swtKNWprWcgntalLmUZLkYIMzlBQ7A==", "11ae59a1-a0ae-4d14-ae76-c06ebe3feee9" });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsBroken",
                value: true);

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DamageDescription", "Rating" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "orders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DamageDescription", "Rating" },
                values: new object[] { null, null });
        }
    }
}
