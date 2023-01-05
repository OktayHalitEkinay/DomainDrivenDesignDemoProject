using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrdersController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("AddAsync")]
        public async Task<IActionResult> AddAsync()
        {
            var query = new GetAllProductsQuery();
            return Ok(await _mediator.Send(query));
        }

    }
}
