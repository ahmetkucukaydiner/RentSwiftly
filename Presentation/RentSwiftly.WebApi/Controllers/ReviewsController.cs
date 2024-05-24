using MediatR;
using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.Mediator.Commands.ReviewCommands;
using RentSwiftly.Application.Features.Mediator.Queries.ReviewQueries;

namespace RentSwiftly.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReviewsController : ControllerBase
	{
		private readonly IMediator _mediator;

		public ReviewsController(IMediator mediator)
		{
			_mediator = mediator;
		}

		[HttpGet]
		public async Task<IActionResult> GetReviewsByCarId(int id)
		{
			var values = await _mediator.Send(new GetReviewByCarIdQuery(id));
			return Ok(values);
		}

		[HttpPost]
		public async Task<IActionResult> CreateReview(CreateReviewCommand createReviewCommand)
		{
			await _mediator.Send(createReviewCommand);
			return Ok("Ekleme işlemi gerçekleştirildi.");
		}

		[HttpPut]
		public async Task<IActionResult> UpdateReview(UpdateReviewCommand updateReviewCommand)
		{
			await _mediator.Send(updateReviewCommand);
			return Ok("Güncelleme işlemi gerçekleştirildi.");
		}
	}
}