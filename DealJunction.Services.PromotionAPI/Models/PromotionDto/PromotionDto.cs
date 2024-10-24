namespace DealJunction.Services.PromotionAPI.Models.PromotionDto
{
    public class BasePromotionDto
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string DiscountCode { get; set; } = string.Empty;
        public DateTimeOffset EndDate { get; set; }

    }
    public class CreatePromotionDto : BasePromotionDto
    {
        public DateTimeOffset StartDate { get; set; }
        public int EmployeeId { get; set; }
    }

    public class ReadPromotionDto : BasePromotionDto
    {
        public object? Result { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
    }

    public class UpdatePromotionDto : BasePromotionDto
    {
    }
}
