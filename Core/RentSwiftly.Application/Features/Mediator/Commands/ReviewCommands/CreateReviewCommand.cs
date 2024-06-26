﻿using MediatR;

namespace RentSwiftly.Application.Features.Mediator.Commands.ReviewCommands
{
	public class CreateReviewCommand : IRequest
	{
		public string CustomerName { get; set; }
		public string CustomerImage { get; set; }
		public string Comment { get; set; }
		public int RatingValue { get; set; }
		public DateTime ReviewDate { get; set; }
		public int CarID { get; set; }
	}
}
