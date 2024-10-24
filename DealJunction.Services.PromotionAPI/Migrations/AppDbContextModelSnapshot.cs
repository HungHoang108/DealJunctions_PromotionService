﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DealJunction.Services.PromotionAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DealJunction.Services.PromotionAPI.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset?>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("WebsiteUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Companies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(384), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "contact@techcorp.com",
                            Name = "TechCorp Solutions",
                            PhoneNumber = "+1-800-123-4567",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(456), new TimeSpan(0, 3, 0, 0, 0)),
                            WebsiteUrl = "https://www.techcorp.com"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(460), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "info@innovatech.com",
                            Name = "Innovatech Industries",
                            PhoneNumber = "+1-800-987-6543",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(461), new TimeSpan(0, 3, 0, 0, 0)),
                            WebsiteUrl = "https://www.innovatech.com"
                        });
                });

            modelBuilder.Entity("DealJunction.Services.PromotionAPI.Models.Employee", b =>
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

                    b.HasIndex("CompanyId");

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
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(594), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "john.doe@techcorp.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "+1-555-123-4567",
                            Role = "Software Engineer",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            CompanyId = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(600), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "jane.smith@innovatech.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "+1-555-987-6543",
                            Role = "Product Manager",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(602), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("DealJunction.Services.PromotionAPI.Models.Promotion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTimeOffset?>("CreatedAt")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("DiscountCode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTimeOffset?>("UpdatedAt")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("Id");

                    b.HasIndex("DiscountCode")
                        .IsUnique();

                    b.HasIndex("EmployeeId");

                    b.ToTable("Promotions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(638), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "50% off on all services for new clients",
                            DiscountCode = "NY2024",
                            EmployeeId = 1,
                            EndDate = new DateTimeOffset(new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Title = "New Year Discount",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(640), new TimeSpan(0, 3, 0, 0, 0))
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(646), new TimeSpan(0, 3, 0, 0, 0)),
                            Description = "25% discount on all products and services",
                            DiscountCode = "SUMMER2024",
                            EmployeeId = 2,
                            EndDate = new DateTimeOffset(new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            StartDate = new DateTimeOffset(new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 3, 0, 0, 0)),
                            Title = "Summer Sale",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 24, 12, 42, 24, 274, DateTimeKind.Unspecified).AddTicks(648), new TimeSpan(0, 3, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("DealJunction.Services.PromotionAPI.Models.Employee", b =>
                {
                    b.HasOne("DealJunction.Services.PromotionAPI.Models.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DealJunction.Services.PromotionAPI.Models.Promotion", b =>
                {
                    b.HasOne("DealJunction.Services.PromotionAPI.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DealJunction.Services.PromotionAPI.Models.Company", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}