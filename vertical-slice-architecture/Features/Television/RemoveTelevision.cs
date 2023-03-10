using MediatR;

namespace vertical_slice_architecture.Features.Television
{
    public class RemoveTelevision
    {
        public class RemoveTelevisionCommand : IRequest<Unit>
        {
            public int TelevisionId { get; set; }
        }

        public class Handler : IRequestHandler<RemoveTelevisionCommand, Unit>
        {
            private readonly ITelevisionService _televisionService;

            public Handler(ITelevisionService televisionService)
            {
                _televisionService = televisionService;
            }

            public Task<Unit> Handle(RemoveTelevisionCommand request, CancellationToken cancellationToken)
            {
                _televisionService.RemoveTelevision(new Domain.Television { Id = request.TelevisionId });
                return Unit.Task;
            }
        }
    }
}
