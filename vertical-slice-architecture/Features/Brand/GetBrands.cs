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
            public Task<IEnumerable<BrandResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }

    }
}
