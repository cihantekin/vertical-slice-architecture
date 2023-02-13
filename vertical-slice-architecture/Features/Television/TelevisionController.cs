using MediatR;
using Microsoft.AspNetCore.Mvc;
using static vertical_slice_architecture.Features.Television.AddTelevision;
using static vertical_slice_architecture.Features.Television.GetTelevisionsForBrand;
using static vertical_slice_architecture.Features.Television.RemoveTelevision;

namespace vertical_slice_architecture.Features.Television
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelevisionController : Controller
    {
        private readonly IMediator _mediator;

        public TelevisionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetTelevisionsForBrand")]
        public async Task<ActionResult<IEnumerable<TvResult>>> GetTelevisionsForBrand(int brandId)
        {
            var query = new GetTvQuery
            {
                BrandId = brandId
            };

            var result = await _mediator.Send(query);

            if (result.IsFailed)
                return NotFound(result.ErrorMessage);

            return Ok(result.Data);
        }

        [HttpPost("AddTelevision")]
        public async Task<ActionResult<TvResult>> AddTelevision(AddTelevisionCommand command)
        {
            var result = await _mediator.Send(command);

            if (result.IsFailed)
                return StatusCode(StatusCodes.Status500InternalServerError, result.ErrorMessage);

            return Ok(result);
        }

        [HttpPost("RemoveTelevision")]
        public async Task<ActionResult> RemoveTelevision(RemoveTelevisionCommand command)
        {
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
