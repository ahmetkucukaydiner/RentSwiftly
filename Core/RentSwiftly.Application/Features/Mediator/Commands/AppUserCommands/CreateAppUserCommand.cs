using MediatR;

namespace RentSwiftly.Application.Features.Mediator.Commands.AppUserCommands
{
	public class CreateAppUserCommand : IRequest
	{
		public string Username { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
	}
}
