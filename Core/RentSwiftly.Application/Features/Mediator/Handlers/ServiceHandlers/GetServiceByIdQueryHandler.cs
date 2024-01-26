using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.ServiceQueries;
using RentSwiftly.Application.Features.Mediator.Results.ServiceResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.ServiceHandlers;

public class GetServiceByIdQueryHandler : IRequestHandler<GetServiceByIdQuery, GetServiceByIdQueryResult>
{
    private readonly IRepository<Service> _repository;

    public GetServiceByIdQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task<GetServiceByIdQueryResult> Handle(GetServiceByIdQuery request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        return new GetServiceByIdQueryResult
        {
            ServiceID = value.ServiceID,
            Title = value.Title,
            Description = value.Description,
            IconUrl = value.IconUrl
        };
    }
}
