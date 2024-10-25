using DealJunction.Services.PromotionAPI.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<EmployeeEmails> EmployeeEmails { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.Property(p => p.Id).ValueGeneratedOnAdd();

            entity.Property(p => p.Title).IsRequired().HasMaxLength(250);
            entity.Property(p => p.Description).IsRequired().HasMaxLength(2000);
            entity.Property(p => p.DiscountCode).IsRequired().HasMaxLength(30);

            entity.HasIndex(p => p.DiscountCode).IsUnique();

            entity.Property(p => p.EmployeeId).IsRequired();

            entity.Property(p => p.CreatedAt).HasColumnType("datetimeoffset");
            entity.Property(p => p.UpdatedAt).HasColumnType("datetimeoffset");

            entity.Property(p => p.StartDate).HasColumnType("datetimeoffset");
            entity.Property(p => p.EndDate).HasColumnType("datetimeoffset");
        });


        modelBuilder.Entity<Promotion>().HasData(
            new Promotion
            {
                Id = 1,
                EmployeeId = 1,
                Title = "New Year Discount",
                Description = "50% off on all services for new clients",
                StartDate = new DateTimeOffset(new DateTime(2024, 1, 1)),
                EndDate = new DateTimeOffset(new DateTime(2024, 1, 31)),
                DiscountCode = "NY2024",
                CreatedAt = DateTimeOffset.Now,
                UpdatedAt = DateTimeOffset.Now
            },
            new Promotion
            {
                Id = 2,
                EmployeeId = 2,
                Title = "Summer Sale",
                Description = "25% discount on all products and services",
                StartDate = new DateTimeOffset(new DateTime(2024, 6, 1)),
                EndDate = new DateTimeOffset(new DateTime(2024, 6, 30)),
                DiscountCode = "SUMMER2024",
                CreatedAt = DateTimeOffset.Now,
                UpdatedAt = DateTimeOffset.Now
            }
        );

        modelBuilder.Entity<EmployeeEmails>(entity =>
        {
            entity.HasKey(e => e.Email);
        });
    }
}
