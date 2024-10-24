﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DealJunction.Services.CompanyAPI.Migrations
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

            modelBuilder.Entity("DealJunction.Services.CompanyAPI.Models.Company", b =>
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
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7851), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "contact@techcorp.com",
                            Name = "TechCorp Solutions",
                            PhoneNumber = "+1-800-123-4567",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7924), new TimeSpan(0, 3, 0, 0, 0)),
                            WebsiteUrl = "https://www.techcorp.com"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7929), new TimeSpan(0, 3, 0, 0, 0)),
                            Email = "info@innovatech.com",
                            Name = "Innovatech Industries",
                            PhoneNumber = "+1-800-987-6543",
                            UpdatedAt = new DateTimeOffset(new DateTime(2024, 10, 25, 0, 3, 58, 181, DateTimeKind.Unspecified).AddTicks(7931), new TimeSpan(0, 3, 0, 0, 0)),
                            WebsiteUrl = "https://www.innovatech.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
