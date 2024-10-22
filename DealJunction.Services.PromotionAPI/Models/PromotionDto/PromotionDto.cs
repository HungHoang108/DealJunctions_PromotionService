namespace DealJunction.Services.PromotionAPI.Models.PromotionDto
{
    public class PromotionDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTimeOffset EndDate { get; set; }
        public string DiscountCode { get; set; } = string.Empty;
    }
}
