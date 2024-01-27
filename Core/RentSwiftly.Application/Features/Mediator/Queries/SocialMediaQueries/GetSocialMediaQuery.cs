using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.SocialMediaResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.SocialMediaQueries;

public class GetSocialMediaQuery : IRequest<List<GetSocialMediaQueryResult>>
{
}
