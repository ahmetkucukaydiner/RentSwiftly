using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.TestimonialResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.TestimonialQueries;

public class GetTestimonialByIdQuery : IRequest<GetTestimonialByIdQueryResult>
{
    public int Id { get; set; }

	public GetTestimonialByIdQuery(int id)
	{
		Id = id;
	}
}
