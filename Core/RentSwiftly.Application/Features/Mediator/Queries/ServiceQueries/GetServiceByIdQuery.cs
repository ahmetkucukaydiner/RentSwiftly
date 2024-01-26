﻿using MediatR;
using RentSwiftly.Application.Features.Mediator.Results.ServiceResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Queries.ServiceQueries;

public class GetServiceByIdQuery : IRequest<GetServiceByIdQueryResult>
{
    public int Id { get; set; }

    public GetServiceByIdQuery(int id)
    {
        Id = id;
    }
}
