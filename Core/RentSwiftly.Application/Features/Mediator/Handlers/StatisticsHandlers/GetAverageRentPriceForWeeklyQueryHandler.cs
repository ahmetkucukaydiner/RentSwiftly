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
    public class GetAverageRentPriceForWeeklyQueryHandler : IRequestHandler<GetAverageRentPriceForWeeklyQuery, GetAverageRentPriceForWeeklyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAverageRentPriceForWeeklyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAverageRentPriceForWeeklyQueryResult> Handle(GetAverageRentPriceForWeeklyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAverageRentPriceForWeekly();
            return new GetAverageRentPriceForWeeklyQueryResult
            {
                AverageRentPriceForWeekly = value
            };
        }
    }
}
