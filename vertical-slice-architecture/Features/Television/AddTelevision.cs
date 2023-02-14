using AutoMapper;
using MediatR;
using vertical_slice_architecture.Domain.Shared;
using static vertical_slice_architecture.Features.Television.GetTelevisionsForBrand;

namespace vertical_slice_architecture.Features.Television
{
    public class AddTelevision
    {
        public class AddTelevisionCommand : IRequest<Result<TvResult>>
        {
            public int Id { get; set; }
            public string Model { get; set; } = string.Empty;
            public int BrandId { get; set; }
            public decimal Inch { get; set; }
        }

        public class Handler : IRequestHandler<AddTelevisionCommand, Result<TvResult>>
        {
            private readonly ITelevisionService _televisionService;
            private readonly IMapper _mapper;

            public Handler(ITelevisionService televisionService, IMapper mapper)
            {
                _televisionService = televisionService;
                _mapper = mapper;
            }

            public async Task<Result<TvResult>> Handle(AddTelevisionCommand request, CancellationToken cancellationToken)
            {
                Domain.Television tv = new()
                {
                    BrandId = request.BrandId,
                    Inch = request.Inch,
                    Model = request.Model,
                };

                await _televisionService.AddTelevision(tv);

                return new Result<TvResult>(_mapper.Map<TvResult>(tv));
            }
        }
    }
}
