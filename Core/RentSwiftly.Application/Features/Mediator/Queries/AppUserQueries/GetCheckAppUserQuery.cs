using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.AppUserResults;

namespace RentSwiftly.Application.Features.Mediator.Queries.AppUserQueries
{
	public class GetCheckAppUserQuery : IRequest<GetCheckAppUserQueryResult>
	{
		public string Username { get; set; }
		public string Password { get; set; }
	}
}
