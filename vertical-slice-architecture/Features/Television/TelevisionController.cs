using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace vertical_slice_architecture.Features.Television
{
    public class TelevisionController : Controller
    {
        private readonly IMediator _mediator;

        public TelevisionController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
