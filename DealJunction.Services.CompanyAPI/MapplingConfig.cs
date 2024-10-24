using AutoMapper;
using DealJunction.Services.CompanyAPI.Models;
using DealJunction.Services.CompanyAPI.Models.CompanyDto;

namespace DealJunction.Services.CompanyAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Company, CreateCompanyDto>().ReverseMap();
            CreateMap<Company, UpdateCompanyDto>().ReverseMap();

            CreateMap<Company, ReadCompanyDto>()
                .ForMember(dest => dest.Result, opt => opt.Ignore())
                .ForMember(dest => dest.IsSuccess, opt => opt.Ignore())
                .ForMember(dest => dest.Message, opt => opt.Ignore());
        }
    }
}
