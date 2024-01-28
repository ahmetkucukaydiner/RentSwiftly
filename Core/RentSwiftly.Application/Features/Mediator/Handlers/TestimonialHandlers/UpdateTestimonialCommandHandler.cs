using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.TestimonialCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.TestimonialHandlers;

public class UpdateTestimonialCommandHandler : IRequestHandler<UpdateTestimonialCommand>
{
	private readonly IRepository<Testimonial> _repository;

	public UpdateTestimonialCommandHandler(IRepository<Testimonial> repository)
	{
		_repository = repository;
	}

	public async Task Handle(UpdateTestimonialCommand request, CancellationToken cancellationToken)
	{
		var value = await _repository.GetByIdAsync(request.TestimonialID);
		value.Title = request.Title;
		value.Comment = request.Comment;
		value.Name = request.Name;
		value.ImageUrl = request.ImageUrl;
		await _repository.UpdateAsync(value);
	}
}
