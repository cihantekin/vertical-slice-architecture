using MediatR;
using Microsoft.AspNetCore.Mvc;
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
            var result = await _mediator.Send(new GetBrandQuery());

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
