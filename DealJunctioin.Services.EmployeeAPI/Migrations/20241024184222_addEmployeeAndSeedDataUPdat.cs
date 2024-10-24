using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealJunction.Services.EmployeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeAndSeedDataUPdat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3003), new TimeSpan(0, 3, 0, 0, 0)), "john.doe@techcorp.com", "John", "Doe", "+1-555-123-4567", "Software Engineer", new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3073), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, 2, new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3076), new TimeSpan(0, 3, 0, 0, 0)), "jane.smith@innovatech.com", "Jane", "Smith", "+1-555-987-6543", "Product Manager", new DateTimeOffset(new DateTime(2024, 10, 24, 21, 42, 21, 933, DateTimeKind.Unspecified).AddTicks(3078), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 1, new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 3, 0, 0, 0)), "john.doe@techcorp.com", "John", "Doe", "+1-555-123-4567", "Software Engineer", new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3387), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, 2, new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 3, 0, 0, 0)), "jane.smith@innovatech.com", "Jane", "Smith", "+1-555-987-6543", "Product Manager", new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }
    }
}
