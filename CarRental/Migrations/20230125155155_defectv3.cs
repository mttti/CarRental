using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarRental.Migrations
{
    /// <inheritdoc />
    public partial class defectv3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSolved",
                table: "carDefects",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSolved",
                table: "carDefects");

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
        }
    }
}
