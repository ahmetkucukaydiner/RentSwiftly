using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.Mediator.Commands.FeatureCommands;
using RentSwiftly.Application.Features.Mediator.Queries.FeatureQueries;

namespace RentSwiftly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeature(CreateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yeni özellik eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            await _mediator.Send(id);
            return Ok("Özellik silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureCommand command)
        {
            await _mediator.Send(command);
            return Ok("Özellik güncellendi.");
        }

        [HttpGet]
        public async Task<IActionResult> FeatureList()
        {
            var values = await _mediator.Send(new GetFeatureQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(int id)
        {
            var value = await _mediator.Send(new GetFeatureByIdQuery(id));
            return Ok(value);
        }
    }
}
