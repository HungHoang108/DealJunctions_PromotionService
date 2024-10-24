using AutoMapper;
using DealJunction.Services.PromotionAPI.Models;
using DealJunction.Services.PromotionAPI.Models.PromotionDto;

namespace DealJunction.Services.PromotionAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Promotion, CreatePromotionDto>().ReverseMap();
            CreateMap<Promotion, UpdatePromotionDto>().ReverseMap();

            CreateMap<Promotion, ReadPromotionDto>()
                .ForMember(dest => dest.Result, opt => opt.Ignore())
                .ForMember(dest => dest.IsSuccess, opt => opt.Ignore())
                .ForMember(dest => dest.Message, opt => opt.Ignore());
        }
    }
}
