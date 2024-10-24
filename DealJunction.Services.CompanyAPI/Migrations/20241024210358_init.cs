using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DealJunction.Services.CompanyAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    WebsiteUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CreatedAt", "Email", "Name", "PhoneNumber", "UpdatedAt", "WebsiteUrl" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7851), new TimeSpan(0, 3, 0, 0, 0)), "contact@techcorp.com", "TechCorp Solutions", "+1-800-123-4567", new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 3, 0, 0, 0)), "https://www.techcorp.com" },
                    { 2, new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 3, 0, 0, 0)), "info@innovatech.com", "Innovatech Industries", "+1-800-987-6543", new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7931), new TimeSpan(0, 3, 0, 0, 0)), "https://www.innovatech.com" }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
