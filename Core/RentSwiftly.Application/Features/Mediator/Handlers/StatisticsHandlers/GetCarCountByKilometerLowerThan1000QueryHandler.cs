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
    public class GetCarCountByKilometerLowerThan1000QueryHandler : IRequestHandler<GetCarCountByKilometerLowerThan1000Query, GetCarCountByKilometerLowerThan1000QueryResult>
    {
        private readonly IStatisticsRepository _repository;

        public GetCarCountByKilometerLowerThan1000QueryHandler(IStatisticsRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarCountByKilometerLowerThan1000QueryResult> Handle(GetCarCountByKilometerLowerThan1000Query request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCarCountByKilometerLowerThan1000();
            return new GetCarCountByKilometerLowerThan1000QueryResult
            {
                CarCountByKilometerLowerThan1000 = value
            };
        }
    }
}
