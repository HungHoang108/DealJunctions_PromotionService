namespace DealJunction.Services.CompanyAPI.Models.CompanyDto
{
    public class BaseCompanyDto
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;

    }
    public class CreateCompanyDto : BaseCompanyDto
    {

    }

    public class ReadCompanyDto : BaseCompanyDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class UpdateCompanyDto : BaseCompanyDto
    {
    }
}
