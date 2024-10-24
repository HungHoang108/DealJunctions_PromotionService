using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealJunction.Services.PromotionAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PhoneNumber", "UpdatedAt", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5528), new TimeSpan(0, 3, 0, 0, 0)), "contact@techcorp.com", "TechCorp Solutions", "+1-800-123-4567", new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5606), new TimeSpan(0, 3, 0, 0, 0)), "https://www.techcorp.com" },
                    { 2, new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 3, 0, 0, 0)), "info@innovatech.com", "Innovatech Industries", "+1-800-987-6543", new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 3, 0, 0, 0)), "https://www.innovatech.com" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5789), new TimeSpan(0, 3, 0, 0, 0)), "john.doe@techcorp.com", "John", "Doe", "+1-555-123-4567", "Software Engineer", new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5792), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, 2, new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5795), new TimeSpan(0, 3, 0, 0, 0)), "jane.smith@innovatech.com", "Jane", "Smith", "+1-555-987-6543", "Product Manager", new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5797), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "Id", "CreatedAt", "Description", "DiscountCode", "EmployeeId", "EndDate", "StartDate", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5834), new TimeSpan(0, 3, 0, 0, 0)), "50% off on all services for new clients", "NY2024", 1, new DateTimeOffset(new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)), "New Year Discount", new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5835), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5873), new TimeSpan(0, 3, 0, 0, 0)), "25% discount on all products and services", "SUMMER2024", 2, new DateTimeOffset(new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)), "Summer Sale", new DateTimeOffset(new DateTime(2024, 10, 23, 20, 13, 9, 77, DateTimeKind.Unspecified).AddTicks(5874), new TimeSpan(0, 3, 0, 0, 0)) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
