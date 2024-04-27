using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.RentACarQueries;
using RentSwiftly.Application.Features.Mediator.Results.RentACarResults;
using RentSwiftly.Application.Interfaces.RentACarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x=>x.LocationID == request.LocationID && x.IsAvailable == true);
            return values.Select(x => new GetRentACarQueryResult
            {
                CarID = x.CarID
            }).ToList();
        }
    }
}