using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.ReviewCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.Mediator.Handlers.ReviewHandlers
{
	public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
	{
		private readonly IRepository<Review> _repository;

		public UpdateReviewCommandHandler(IRepository<Review> repository)
		{
			_repository = repository;
		}

		public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetByIdAsync(request.ReviewID);
			values.Comment = request.Comment;
			values.CustomerName = request.CustomerName;
			values.CustomerImage = request.CustomerImage;
			values.CarID = request.CarID;
			values.RatingValue = request.RatingValue;
			await _repository.CreateAsync(values);
		}
	}
}
