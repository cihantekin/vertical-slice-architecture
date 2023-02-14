using AutoMapper;
using MediatR;
using vertical_slice_architecture.Domain.Shared;

namespace vertical_slice_architecture.Features.Television
{
    public class GetTelevisionsForBrand
    {
        public class GetTvQuery : IRequest<Result<IEnumerable<TvResult>>>
        {
            public int BrandId { get; set; }
        }

        public class TvResult
        {
            public int Id { get; set; }
            public string Model { get; set; } = string.Empty;
            public int BrandId { get; set; }
            public decimal Inch { get; set; }
        }

        public class Handler : IRequestHandler<GetTvQuery, Result<IEnumerable<TvResult>>>
        {
            private readonly ITelevisionService _televisionService;
            private readonly IMapper _mapper;

            public Handler(ITelevisionService televisionService, IMapper mapper)
            {
                _televisionService = televisionService;
                _mapper = mapper;
            }

            public async Task<Result<IEnumerable<TvResult>>> Handle(GetTvQuery request, CancellationToken cancellationToken)
            {
                var serviceResult = await _televisionService.GetTelevisionsForBrand(request.BrandId);

                if (serviceResult is null || !serviceResult.Any())
                    return new Result<IEnumerable<TvResult>> { IsFailed = true, ErrorMessage = "No tv found in db" };

                return new Result<IEnumerable<TvResult>>(_mapper.Map<IEnumerable<TvResult>>(serviceResult));
            }
        }
    }
}
