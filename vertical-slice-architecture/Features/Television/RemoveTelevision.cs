using MediatR;

namespace vertical_slice_architecture.Features.Television
{
    public class RemoveTelevision
    {
        public class RemoveTelevisionCommand : IRequest<Unit>
        {
            public int TelevisionId { get; set; }
        }
    }
}
