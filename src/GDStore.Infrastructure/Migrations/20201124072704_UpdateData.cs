using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GDStore.Infrastructure.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d9dad063-b798-47fe-9a3d-512cacabebe5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "d53616fa-135c-4147-9068-4e65dfe56ef3", "likeafternoonqp@gmail.com", "likeafternoonqp@gmail.com", "AQAAAAEAACcQAAAAEDQK9aXGF9F3kUDfEEODBkFzuLwom36NpF4OQEDxBOCJfZp5NSTqDCEloaO4hKsqlA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2b6655dc-8c63-4521-abf5-7de9aff2756e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash" },
                values: new object[] { "8bf1b765-63ac-467d-8fa4-ca0ee26a3cf9", "tedu.international@gmail.com", "tedu.international@gmail.com", "AQAAAAEAACcQAAAAEDO7GmCSx7FWbQojU32Rci2dq1HmOJJ8IqDlzQy5G//gDgAYn99IZ0Tw281rvc59zg==" });
        }
    }
}
