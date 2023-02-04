using MediatR;
using static vertical_slice_architecture.Features.Television.GetTelevisionsForBrand;

namespace vertical_slice_architecture.Features.Television
{
    public class AddTelevision
    {
        public class AddTelevisionCommand : IRequest<TvResult>
        {
            public int Id { get; set; }
            public string Model { get; set; }
            public int BrandId { get; set; }
            public decimal Inch { get; set; }
        }

        public class Handler : IRequestHandler<AddTelevisionCommand, TvResult>
        {
            private readonly ITelevisionService _televisionService;

            public Handler(ITelevisionService televisionService)
            {
                _televisionService = televisionService;
            }

            //TODO: implement automapper
            public async Task<TvResult> Handle(AddTelevisionCommand request, CancellationToken cancellationToken)
            {
                Domain.Television tv = new()
                {
                    BrandId = request.BrandId,
                    Inch = request.Inch,
                    Model = request.Model,
                };

                await _televisionService.AddTelevision(tv);

                return new TvResult { Id = request.Id, Model = request.Model, BrandId = request.BrandId, Inch = request.Inch };
            }
        }
    }
}
