using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.StatisticsResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.StatisticsQueries
{
    public class GetCarCountByKilometerLowerThan1000Query : IRequest<GetCarCountByKilometerLowerThan1000QueryResult>
    {
    }
}
