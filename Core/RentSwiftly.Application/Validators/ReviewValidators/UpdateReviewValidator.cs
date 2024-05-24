using FluentValidation;
using RentSwiftly.Application.Features.Mediator.Commands.ReviewCommands;

namespace RentSwiftly.Application.Validators.ReviewValidators
{
	public class UpdateReviewValidator : AbstractValidator<UpdateReviewCommand>
	{
		public UpdateReviewValidator()
		{
			RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Lütfen müşteri adını boş geçmeyiniz.");
			RuleFor(x => x.CustomerName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapınız.");
			RuleFor(x => x.RatingValue).NotEmpty().WithMessage("Lütfen puan değerini boş geçmeyiniz.");
			RuleFor(x => x.Comment).NotEmpty().WithMessage("Lütfen yorumu boş geçmeyiniz.");
			RuleFor(x => x.Comment).MinimumLength(30).WithMessage("Lütfen yorum kısmına en az 30 karakter veri girişi yapınız.");
			RuleFor(x => x.Comment).MaximumLength(500).WithMessage("Lütfen yorum kısmına en fazla 500 karakter veri girişi yapınız.");
			RuleFor(x => x.CustomerImage).NotEmpty().WithMessage("Lütfen müşteri görselini boş geçmeyiniz.");
		}
	}
}