using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealJunction.Services.EmployeeAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, 1, new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3322), new TimeSpan(0, 3, 0, 0, 0)), "john.doe@techcorp.com", "John", "Doe", "+1-555-123-4567", "Software Engineer", new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3387), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 4, 2, new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3391), new TimeSpan(0, 3, 0, 0, 0)), "jane.smith@innovatech.com", "Jane", "Smith", "+1-555-987-6543", "Product Manager", new DateTimeOffset(new DateTime(2024, 10, 24, 21, 27, 30, 951, DateTimeKind.Unspecified).AddTicks(3392), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Email",
                table: "Employees",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_PhoneNumber",
                table: "Employees",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
