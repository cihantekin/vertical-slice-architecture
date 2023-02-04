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
            public Task<TvResult> Handle(AddTelevisionCommand request, CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
        }
    }
}
