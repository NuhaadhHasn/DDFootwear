using AutoMapper;
using DDFootwear.API.DTO;
using DDFootwear.API.Model;

namespace DDFootwear.API.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductReadDTO>();
            CreateMap<ProductCreateDTO, Product>();
        }
    }
}
