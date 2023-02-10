using MediatR;
using vertical_slice_architecture.Features.Television.Exceptions;

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
            private readonly ITelevisionService _televisionService;

            public Handler(ITelevisionService televisionService)
            {
                _televisionService = televisionService;
            }

            public async Task<IEnumerable<TvResult>> Handle(GetTvQuery request, CancellationToken cancellationToken)
            {
                var serviceResult = await _televisionService.GetTelevisionsForBrand(request.BrandId);

                if (serviceResult is null || !serviceResult.Any())
                    throw new NoTelevisionExistException(request.BrandId, "");

                return serviceResult.Select(s => new TvResult
                {
                    BrandId = s.BrandId,
                    Model = s.Model,
                    Id = s.Id,
                    Inch = s.Inch,
                });
            }
        }
    }
}
