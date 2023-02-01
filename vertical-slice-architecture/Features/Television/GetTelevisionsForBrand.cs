using MediatR;

namespace vertical_slice_architecture.Features.Television
{
    public class GetTelevisionsForBrand
    {
        public class GetTvQuery : IRequest<IEnumerable<TvResult>>
        {
            public int BrandId { get; set; }
        }

        public class TvResult
        {
            public int Id { get; set; }
            public string Model { get; set; }
            public int BrandId { get; set; }
            public decimal Inch { get; set; }
        }

        public class Handler : IRequestHandler<GetTvQuery, IEnumerable<TvResult>>
        {
            public Task<IEnumerable<TvResult>> Handle(GetTvQuery request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
