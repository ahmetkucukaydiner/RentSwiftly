using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.ReviewQueries;
using RentSwiftly.Application.Features.Mediator.Results.ReviewResults;
using RentSwiftly.Application.Interfaces.ReviewInterfaces;

namespace RentSwiftly.Application.Features.Mediator.Handlers.ReviewHandlers
{
	public class GetReviewByCarIdQueryHandler : IRequestHandler<GetReviewByCarIdQuery, List<GetReviewByCarIdQueryResult>>
	{
		private readonly IReviewRepository _reviewRepository;

		public GetReviewByCarIdQueryHandler(IReviewRepository reviewRepository)
		{
			_reviewRepository = reviewRepository;
		}

		public async Task<List<GetReviewByCarIdQueryResult>> Handle(GetReviewByCarIdQuery request, CancellationToken cancellationToken)
		{
			var values = _reviewRepository.GetReviewsByCarId(request.Id);
			return values.Select(x => new GetReviewByCarIdQueryResult
			{
				CarID = x.CarID,
				Comment = x.Comment,
				CustomerImage = x.CustomerImage,
				CustomerName = x.CustomerName,
				RatingValue = x.RatingValue,
				ReviewDate = x.ReviewDate,
				ReviewID = x.ReviewID,
			}).ToList();
		}
	}
}
