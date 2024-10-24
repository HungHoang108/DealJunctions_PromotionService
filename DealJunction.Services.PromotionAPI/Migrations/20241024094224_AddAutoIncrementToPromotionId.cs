using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DealJunction.Services.PromotionAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAutoIncrementToPromotionId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(456), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(648), new TimeSpan(0, 3, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5792), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5797), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 3, 0, 0, 0)) });
        }
    }
}
