using MediatR;
using RentSwiftly.Application.Enums;
using RentSwiftly.Application.Features.Mediator.Commands.AppUserCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.Mediator.Handlers.AppUserHandlers
{
	public class CreateAppUserCommandHandler : IRequestHandler<CreateAppUserCommand>
	{
		private readonly IRepository<AppUser> _repository;
		public CreateAppUserCommandHandler(IRepository<AppUser> repository)
		{
			_repository = repository;
		}

		public async Task Handle(CreateAppUserCommand request, CancellationToken cancellationToken)
		{
			await _repository.CreateAsync(new AppUser
			{
				Password = request.Password,
				UserName = request.Username,
				Email = request.Email,
				AppRoleID = (int)RolesType.Member
			});
		}
	}
}
