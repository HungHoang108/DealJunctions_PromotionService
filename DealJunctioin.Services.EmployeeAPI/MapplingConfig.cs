using AutoMapper;
using DealJunction.Services.EmployeeAPI.Models;
using DealJunction.Services.EmployeeAPI.Models.EmployeeDto;

namespace DealJunction.Services.EmployeeAPI
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Employee, CreateEmployeeDto>().ReverseMap();
            CreateMap<Employee, UpdateEmployeeDto>().ReverseMap();

            CreateMap<Employee, ReadEmployeeDto>()
                .ForMember(dest => dest.Result, opt => opt.Ignore())
                .ForMember(dest => dest.IsSuccess, opt => opt.Ignore())
                .ForMember(dest => dest.Message, opt => opt.Ignore());
        }
    }
}
