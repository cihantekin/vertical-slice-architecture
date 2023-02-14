using AutoMapper;
using static vertical_slice_architecture.Features.Brand.GetBrands;

namespace vertical_slice_architecture.Features.Brand
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Domain.Brand, BrandResult>();
        }
    }
}
