namespace DealJunction.Services.PromotionAPI.Models
{
    public class Promotion : BaseModel
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
        public string DiscountCode { get; set; } = string.Empty;
    }
}
