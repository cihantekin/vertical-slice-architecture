using AutoMapper;
using MediatR;
using vertical_slice_architecture.Domain.Shared;

namespace vertical_slice_architecture.Features.Brand
{
    public class GetBrands
    {
        public class GetBrandQuery : IRequest<Result<IEnumerable<BrandResult>>> { }
        public class BrandResult
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string Origin { get; set; } = string.Empty;
        }

        public class Handler : IRequestHandler<GetBrandQuery, Result<IEnumerable<BrandResult>>>
        {
            private readonly IBrandService _brandService;
            private readonly IMapper _mapper;

            public Handler(IBrandService brandService, IMapper mapper)
            {
                _brandService = brandService;
                _mapper = mapper;
            }

            public async Task<Result<IEnumerable<BrandResult>>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
            {
                var brands = await _brandService.GetAllBrands();

                if (brands is null || !brands.Any())
                    return new Result<IEnumerable<BrandResult>> { IsFailed = true, ErrorMessage = "No brand was found in the database!" };

                return new Result<IEnumerable<BrandResult>>(_mapper.Map<IEnumerable<BrandResult>>(brands));
            }
        }

    }
}
