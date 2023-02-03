using MediatR;

namespace vertical_slice_architecture.Features.Brand
{
    public class GetBrands
    {
        public class GetBrandQuery : IRequest<IEnumerable<BrandResult>> { }
        public class BrandResult
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Origin { get; set; }
        }

        public class Handler : IRequestHandler<GetBrandQuery, IEnumerable<BrandResult>>
        {
            private readonly IBrandService _brandService;

            public Handler(IBrandService brandService)
            {
                _brandService = brandService;
            }

            public async Task<IEnumerable<BrandResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
            {
                var brands = await _brandService.GetAllBrands();

                return brands.Select(b => new BrandResult
                {
                    Id = b.Id,
                    Name = b.Name,
                    Origin = b.Origin
                });
            }
        }

    }
}
