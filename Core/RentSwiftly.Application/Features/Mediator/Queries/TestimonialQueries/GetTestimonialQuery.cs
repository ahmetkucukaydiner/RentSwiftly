using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.TestimonialResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.TestimonialQueries;

public class GetTestimonialQuery :IRequest<List<GetTestimonialQueryResult>>
{
}
