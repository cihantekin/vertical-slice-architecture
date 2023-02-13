using MediatR;
using Microsoft.AspNetCore.Mvc;
using vertical_slice_architecture.Domain.Shared;
using static vertical_slice_architecture.Features.Brand.GetBrands;

namespace vertical_slice_architecture.Features.Brand
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : Controller
    {
        private readonly IMediator _mediator;

        public BrandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllBrands")]
        public async Task<ActionResult<IEnumerable<BrandResult>>> GetAllBrands()
        {
            Result<IEnumerable<BrandResult>> result = await _mediator.Send(new GetBrandQuery());

            if (result.IsFailed)
                return NotFound(result.ErrorMessage);

            return Ok(result);
        }
    }
}
