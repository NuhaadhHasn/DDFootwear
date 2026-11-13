using AutoMapper;
using DDFootwear.API.DTO;
using DDFootwear.API.Model;

namespace DDFootwear.API.Profiles
{
    public class SalesProfile : Profile
    {
        public SalesProfile()
        {
            CreateMap<Sale, SalesReadDTO>();
            CreateMap<SalesCreateDTO, Sale>();
        }
    }
}
