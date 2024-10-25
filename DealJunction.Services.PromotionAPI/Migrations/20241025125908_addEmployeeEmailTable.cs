using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealJunction.Services.PromotionAPI.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeEmailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Promotions_Employees_EmployeeId",
                table: "Promotions");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropIndex(
                name: "IX_Promotions_EmployeeId",
                table: "Promotions");

            migrationBuilder.CreateTable(
                name: "EmployeeEmails",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeEmails", x => x.Email);
                });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 25, 15, 59, 7, 894, DateTimeKind.Unspecified).AddTicks(2187), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 25, 15, 59, 7, 894, DateTimeKind.Unspecified).AddTicks(2199), new TimeSpan(0, 3, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                table: "Promotions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 10, 25, 15, 59, 7, 894, DateTimeKind.Unspecified).AddTicks(2206), new TimeSpan(0, 3, 0, 0, 0)), new DateTimeOffset(new DateTime(2024, 10, 25, 15, 59, 7, 894, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 3, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeEmails");

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PhoneNumber", "UpdatedAt", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 3, 0, 0, 0)), "contact@techcorp.com", "TechCorp Solutions", "+1-800-123-4567", new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(456), new TimeSpan(0, 3, 0, 0, 0)), "https://www.techcorp.com" },
                    { 2, new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, 3, 0, 0, 0)), "info@innovatech.com", "Innovatech Industries", "+1-800-987-6543", new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 3, 0, 0, 0)), "https://www.innovatech.com" }
                });

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

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "CompanyId", "CreatedAt", "Email", "FirstName", "LastName", "PhoneNumber", "Role", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, 1, new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 3, 0, 0, 0)), "john.doe@techcorp.com", "John", "Doe", "+1-555-123-4567", "Software Engineer", new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 3, 0, 0, 0)) },
                    { 2, 2, new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 3, 0, 0, 0)), "jane.smith@innovatech.com", "Jane", "Smith", "+1-555-987-6543", "Product Manager", new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 3, 0, 0, 0)) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_EmployeeId",
                table: "Promotions",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_Email",
                table: "Companies",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Companies_PhoneNumber",
                table: "Companies",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CompanyId",
                table: "Employees",
                column: "CompanyId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Promotions_Employees_EmployeeId",
                table: "Promotions",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
