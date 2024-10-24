using DealJunction.Services.CompanyAPI.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Company> Companies { get; set; }

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
    }
}
