namespace DealJunction.Services.EmployeeAPI.Models.EmployeeDto
{
    public class BaseEmployeeDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;

    }
    public class CreateEmployeeDto : BaseEmployeeDto
    {
        public int CompanyId { get; set; }
    }

    public class ReadEmployeeDto : BaseEmployeeDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class UpdateEmployeeDto : BaseEmployeeDto
    {
    }

    public class EmployeeLoginRequest
    {
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

    }
}
