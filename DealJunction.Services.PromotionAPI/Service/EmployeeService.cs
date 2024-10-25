using DealJunction.Services.PromotionAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace DealJunction.Services.PromotionAPI.Service
{
    public class EmployeeService : IEmployeeService
    {
        private DbContextOptions<AppDbContext> _contextOptions;

        public EmployeeService(DbContextOptions<AppDbContext> contextOptions)
        {
            _contextOptions = contextOptions;
        }
        public async Task CreateEmployee(EmployeeEmails emEmail)
        {

            await using var _db = new AppDbContext(_contextOptions);


            _db.EmployeeEmails.Add(emEmail);
            await _db.SaveChangesAsync();
        }
    }
}
