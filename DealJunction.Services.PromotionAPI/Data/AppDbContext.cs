using DealJunction.Services.PromotionAPI.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Promotion> Promotions { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(c => c.Id);

            entity.Property(c => c.Name).IsRequired().HasMaxLength(150);
            entity.Property(c => c.PhoneNumber).IsRequired().HasMaxLength(30);
            entity.Property(c => c.Email).IsRequired().HasMaxLength(100);
            entity.Property(c => c.WebsiteUrl).IsRequired().HasMaxLength(100);

            entity.HasIndex(c => c.PhoneNumber).IsUnique();
            entity.HasIndex(c => c.Email).IsUnique();

            entity.Property(c => c.CreatedAt).HasColumnType("datetimeoffset");
            entity.Property(c => c.UpdatedAt).HasColumnType("datetimeoffset");

            entity.HasMany(c => c.Employees)
                  .WithOne(e => e.Company)
                  .HasForeignKey(e => e.CompanyId)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.FirstName).IsRequired().HasMaxLength(50);
            entity.Property(e => e.LastName).IsRequired().HasMaxLength(50);
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).IsRequired().HasMaxLength(30);
            entity.Property(e => e.Role).IsRequired().HasMaxLength(50);

            entity.HasIndex(e => e.Email).IsUnique();
            entity.HasIndex(e => e.PhoneNumber).IsUnique();

            entity.HasOne(e => e.Company)
                  .WithMany(c => c.Employees)
                  .HasForeignKey(e => e.CompanyId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.Property(e => e.CreatedAt).HasColumnType("datetimeoffset");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetimeoffset");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.Property(p => p.Id).ValueGeneratedOnAdd();

            entity.Property(p => p.Title).IsRequired().HasMaxLength(250);
            entity.Property(p => p.Description).IsRequired().HasMaxLength(2000);
            entity.Property(p => p.DiscountCode).IsRequired().HasMaxLength(30);

            entity.HasIndex(p => p.DiscountCode).IsUnique();

            entity.HasOne(p => p.Employee)
                  .WithMany()
                  .HasForeignKey(p => p.EmployeeId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.Property(p => p.CreatedAt).HasColumnType("datetimeoffset");
            entity.Property(p => p.UpdatedAt).HasColumnType("datetimeoffset");

            entity.Property(p => p.StartDate).HasColumnType("datetimeoffset");
            entity.Property(p => p.EndDate).HasColumnType("datetimeoffset");
        });

        modelBuilder.Entity<Company>().HasData(
            new Company
            {
                Id = 1,
                Name = "TechCorp Solutions",
                PhoneNumber = "+1-800-123-4567",
                Email = "contact@techcorp.com",
                WebsiteUrl = "https://www.techcorp.com",
                CreatedAt = DateTimeOffset.Now,
                UpdatedAt = DateTimeOffset.Now
            },
            new Company
            {
                Id = 2,
                Name = "Innovatech Industries",
                PhoneNumber = "+1-800-987-6543",
                Email = "info@innovatech.com",
                WebsiteUrl = "https://www.innovatech.com",
                CreatedAt = DateTimeOffset.Now,
                UpdatedAt = DateTimeOffset.Now
            }
        );

        modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@techcorp.com",
                PhoneNumber = "+1-555-123-4567",
                CompanyId = 1,
                Role = "Software Engineer",
                CreatedAt = DateTimeOffset.Now,
                UpdatedAt = DateTimeOffset.Now
            },
            new Employee
            {
                Id = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@innovatech.com",
                PhoneNumber = "+1-555-987-6543",
                CompanyId = 2,
                Role = "Product Manager",
                CreatedAt = DateTimeOffset.Now,
                UpdatedAt = DateTimeOffset.Now
            }
        );


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
    }
}
