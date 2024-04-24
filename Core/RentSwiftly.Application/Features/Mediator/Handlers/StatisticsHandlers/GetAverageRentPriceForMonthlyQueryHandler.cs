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
    public class GetAverageRentPriceForMonthlyQueryHandler : IRequestHandler<GetAverageRentPriceForMonthlyQuery, GetAverageRentPriceForMonthlyQueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetAverageRentPriceForMonthlyQueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAverageRentPriceForMonthlyQueryResult> Handle(GetAverageRentPriceForMonthlyQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetAverageRentPriceForMonthly();
            return new GetAverageRentPriceForMonthlyQueryResult
            {
                AverageRentPriceForMonthly = value
            };
        }
    }
}
