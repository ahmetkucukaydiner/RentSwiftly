﻿using RentSwiftly.Application.Features.CQRS.Queries.ContactQueries;
using RentSwiftly.Application.Features.CQRS.Results.ContactResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.ContactHandlers;

public class GetContactByIdQueryHandler
{
    private readonly IRepository<Contact> _repository;

    public GetContactByIdQueryHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task<GetContactByIdQueryResult> Handle(GetContactByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetContactByIdQueryResult
        {
            ContactID = value.ContactID,
            Email = value.Email,
            Message = value.Message,
            Name = value.Name,
            SendDate = value.SendDate,
            Subject = value.Subject
        };
    }
}
