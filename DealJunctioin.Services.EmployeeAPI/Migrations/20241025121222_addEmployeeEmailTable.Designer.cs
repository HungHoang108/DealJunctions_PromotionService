﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DealJunction.Services.EmployeeAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241025121222_addEmployeeEmailTable")]
    partial class addEmployeeEmailTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DealJunction.Services.EmployeeAPI.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset?>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CompanyId = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7370), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "john.doe@techcorp.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "+1-555-123-4567",
                            Role = "Software Engineer",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7563), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7568), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "jane.smith@innovatech.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "+1-555-987-6543",
                            Role = "Product Manager",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 15, 12, 21, 918, DateTimeKind.Unspecified).AddTicks(7570), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
