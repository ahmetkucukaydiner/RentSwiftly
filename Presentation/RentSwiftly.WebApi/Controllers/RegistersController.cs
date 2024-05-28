using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.Mediator.Commands.AppUserCommands;

namespace RentSwiftly.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RegistersController : ControllerBase
	{
		private readonly IMediator _mediator;

		public RegistersController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpPost]
		public async Task<IActionResult> Register(CreateAppUserCommand command)
		{
			await _mediator.Send(command);
			return Ok("Kullanıcı başarıyla oluşturuldu.");
		}
	}
}
