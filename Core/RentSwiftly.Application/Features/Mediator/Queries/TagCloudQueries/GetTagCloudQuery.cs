using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.TagCloudResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.TagCloudQueries
{
    public class GetTagCloudQuery : IRequest<List<GetTagCloudQueryResult>>
    {
    }
}
