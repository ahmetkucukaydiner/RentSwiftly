using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.LocationQueries;
using RentSwiftly.Application.Features.Mediator.Results.LocationResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.LocationHandlers;

public class GetLocationQueryHandler : IRequestHandler<GetLocationQuery, List<GetLocationQueryResult>> 
{
    private readonly IRepository<Location> _repository;

    public GetLocationQueryHandler(IRepository<Location> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetLocationQueryResult>> Handle(GetLocationQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x=>new GetLocationQueryResult
        {
            LocationID = x.LocationID,
            Name = x.Name
        }).ToList();
    }
}
