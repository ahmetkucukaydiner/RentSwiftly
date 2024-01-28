using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.TestimonialQueries;
using RentSwiftly.Application.Features.Mediator.Results.TestimonialResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class GetTestimonialByIdQueryHandler : IRequestHandler<GetTestimonialByIdQuery, GetTestimonialByIdQueryResult>
{
	private readonly IRepository<Testimonial> _repository;

	public GetTestimonialByIdQueryHandler(IRepository<Testimonial> repository)
	{
		_repository = repository;
	}

	public async Task<GetTestimonialByIdQueryResult> Handle(GetTestimonialByIdQuery request, CancellationToken cancellationToken)
	{
		var value = await _repository.GetByIdAsync(request.Id);
		return new GetTestimonialByIdQueryResult
		{
			Comment = value.Comment,
			ImageUrl = value.ImageUrl,
			Name = value.Name,
			TestimonialID = value.TestimonialID,
			Title = value.Title
		};
	}
}
