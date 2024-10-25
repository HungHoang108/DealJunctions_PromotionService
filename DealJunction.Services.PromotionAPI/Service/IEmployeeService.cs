using DealJunction.Services.PromotionAPI.Models;

namespace DealJunction.Services.PromotionAPI.Service
{
    public interface IEmployeeService
    {
        Task CreateEmployee(EmployeeEmails email);
    }
}
