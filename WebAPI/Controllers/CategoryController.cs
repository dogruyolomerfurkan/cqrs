using System;
using System.Threading.Tasks;
using Business.CQRS.Commands.Category.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator) { _mediator = mediator; }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            try
            {
                var response = await _mediator.Send(createCategoryRequest);
                return Ok(new { productId = response.ProductId, result = response.Result });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}