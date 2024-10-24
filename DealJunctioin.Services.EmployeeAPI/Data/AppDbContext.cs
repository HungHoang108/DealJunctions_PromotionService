using DealJunction.Services.EmployeeAPI.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

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

            entity.Property(p => p.CompanyId).IsRequired();

            entity.Property(e => e.CreatedAt).HasColumnType("datetimeoffset");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetimeoffset");
        });

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
    }
}
