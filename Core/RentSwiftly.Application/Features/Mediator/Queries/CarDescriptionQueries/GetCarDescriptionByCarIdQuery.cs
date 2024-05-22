using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.CarDescriptionResults;

namespace RentSwiftly.Application.Features.Mediator.Queries.CarDescriptionQueries
{
	public class GetCarDescriptionByCarIdQuery : IRequest<GetCarDescriptionByIdQueryResult>
	{
		public int Id { get; set; }

		public GetCarDescriptionByCarIdQuery(int id)
		{
			Id = id;
		}
	}
}
