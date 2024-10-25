﻿namespace DealJunction.Services.CompanyAPI.Models
{
    public class Company : BaseModel
    {
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string WebsiteUrl { get; set; } = string.Empty;
    }
}
