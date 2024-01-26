using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.FooterAddressResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.FooterQueries;

public class GetFooterAddressQuery : IRequest<List<GetFooterAddressQueryResult>>
{
}
