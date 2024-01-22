using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.Mediator.Commands.FooterAddressCommands;
using RentSwiftly.Application.Features.Mediator.Queries.FooterAddressQueries;
using RentSwiftly.Application.Features.Mediator.Queries.FooterQueries;

namespace RentSwiftly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FooterAddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FooterAddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> FooterAddressList()
        {
            var values = await _mediator.Send(new GetFooterAddressQuery());
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFooterAddress(CreateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Yeni adres bilgisi eklendi.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFooterAddress(int id)
        {
            var value = await _mediator.Send(new GetFooterAddressByIdQuery(id));
            return Ok(value);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFooterAddress(int id)
        {
            await _mediator.Send(new DeleteFooterAddressCommand(id));
            return Ok("Adres bilgisi silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFooterAddress(UpdateFooterAddressCommand command)
        {
            await _mediator.Send(command);
            return Ok("Adres bilgisi güncellendi.");
        }
    }
}
