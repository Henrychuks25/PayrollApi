using AutoMapper;
using Entities;
using Shared.DataTransferObjects;

namespace PayrollApi.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee, EmployeeDto>()
                .ForCtorParam("FullAddress",
         //.ForMember(c => c.FullAddress,
         opt => opt.MapFrom(x => string.Join(' ', x.Address, x.EmergencyContact)));
        }
    }
}
