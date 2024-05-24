using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.ReviewResults;

namespace RentSwiftly.Application.Features.Mediator.Queries.ReviewQueries
{
	public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
	{
		public int Id { get; set; }

		public GetReviewByCarIdQuery(int id)
		{
			Id = id;
		}
	}
}
