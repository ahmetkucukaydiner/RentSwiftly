﻿using MediatR;
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

public class GetServiceQueryHandler : IRequestHandler<GetServiceQuery, List<GetServiceQueryResult>>
{
    private readonly IRepository<Service> _repository;

    public GetServiceQueryHandler(IRepository<Service> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetServiceQueryResult>> Handle(GetServiceQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetServiceQueryResult
        {
            ServiceID = x.ServiceID,
            Title = x.Title,
            Description = x.Description,
            IconUrl = x.IconUrl
        }).ToList();
    }
}
