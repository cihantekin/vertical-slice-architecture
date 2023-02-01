using MediatR;
using Microsoft.AspNetCore.Mvc;
using static vertical_slice_architecture.Features.Television.GetTelevisionsForBrand;

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
            try
            {
                var query = new GetTvQuery
                {
                    BrandId = brandId
                };

                var result = await _mediator.Send(query); 
                
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
