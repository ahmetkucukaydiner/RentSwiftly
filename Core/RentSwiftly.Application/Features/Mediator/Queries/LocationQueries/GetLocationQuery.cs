using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.LocationResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.LocationQueries;

public class GetLocationQuery : IRequest<List<GetLocationQueryResult>>
{
}
