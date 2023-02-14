using AutoMapper;
using static vertical_slice_architecture.Features.Television.GetTelevisionsForBrand;

namespace vertical_slice_architecture.Features.Television
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Domain.Television, TvResult>();
        }
    }
}
