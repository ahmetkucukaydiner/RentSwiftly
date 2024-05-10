using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.CarPricingQueries;
using RentSwiftly.Application.Features.Mediator.Results.CarPricingResults;
using RentSwiftly.Application.Interfaces.CarPricingInterfaces;

namespace RentSwiftly.Application.Features.Mediator.Handlers.CarPricingHandlers
{
	public class GetCarPricingWithTimePeriodQueryHandler : IRequestHandler<GetCarPricingWithTimePeriodQuery, List<GetCarPricingWithTimePeriodQueryResult>>
	{
		private readonly ICarPricingRepository _carPricingRepository;

		public GetCarPricingWithTimePeriodQueryHandler(ICarPricingRepository carPricingRepository)
		{
			_carPricingRepository = carPricingRepository;
		}

		public async Task<List<GetCarPricingWithTimePeriodQueryResult>> Handle(GetCarPricingWithTimePeriodQuery request, CancellationToken cancellationToken)
		{
			var values = _carPricingRepository.GetCarPricingWithTimePeriod();
			return values.Select(x => new GetCarPricingWithTimePeriodQueryResult
			{
				BrandName = x.BrandName,
				Model = x.Model,
				CoverImageUrl = x.CoverImageUrl,
				DailyAmount = x.Amounts[0],
				WeeklyAmount = x.Amounts[1],
				MonthlyAmount = x.Amounts[2]
			}).ToList();
		}
	}
}