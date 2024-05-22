using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.CarDescriptionQueries;
using RentSwiftly.Application.Features.Mediator.Results.CarDescriptionResults;
using RentSwiftly.Application.Interfaces.CarDescriptionInterfaces;

namespace RentSwiftly.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
	public class GetCarDescriptionByIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionByIdQueryResult>
	{
		private readonly ICarDescriptionRepository _repository;

		public GetCarDescriptionByIdQueryHandler(ICarDescriptionRepository repository)
		{
			_repository = repository;
		}

		public async Task<GetCarDescriptionByIdQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetCarDescriptionByCarId(request.Id);
			return new GetCarDescriptionByIdQueryResult
			{
				CarDescriptionID = values.CarDescriptionID,
				CarID = values.CarID,
				Details = values.Details,
			};
		}
	}
}
