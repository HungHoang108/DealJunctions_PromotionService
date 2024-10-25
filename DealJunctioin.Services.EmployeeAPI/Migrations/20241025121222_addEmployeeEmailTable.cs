using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealJunction.Services.EmployeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeEmailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 3, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3078), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
