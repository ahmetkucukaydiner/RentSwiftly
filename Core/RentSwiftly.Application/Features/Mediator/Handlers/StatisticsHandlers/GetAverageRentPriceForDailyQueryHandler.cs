using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.StatisticsQueries;
using RentSwiftly.Application.Features.Mediator.Results.StatisticsResults;
using RentSwiftly.Application.Interfaces.StatisticsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.StatisticsHandlers
{
    public class GetAverageRentPriceForDailyQueryHandler : IRequestHandler<GetAverageRentPriceForDailyQuery, GetAverageRentPriceForDailyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAverageRentPriceForDailyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAverageRentPriceForDailyQueryResult> Handle(GetAverageRentPriceForDailyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetBlogCount();
            return new GetAverageRentPriceForDailyQueryResult
            {
                AverageRentPriceForDaily = value
            };
        }
    }
}
