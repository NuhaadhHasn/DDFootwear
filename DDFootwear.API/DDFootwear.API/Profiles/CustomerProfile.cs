using AutoMapper;
using DDFootwear.API.DTO;
using DDFootwear.API.Model;

namespace DDFootwear.API.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile() {
            CreateMap<Customer, CustomerReadDTO>();
            CreateMap<CustomerCreateDTO, Customer>();
        }
    }
}
