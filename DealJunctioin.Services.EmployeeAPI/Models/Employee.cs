namespace DealJunction.Services.EmployeeAPI.Models
{
    public class Employee : BaseModel
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int CompanyId { get; set; }
        public string Role { get; set; } = string.Empty;
    }
}
