﻿using RentSwiftly.Application.Features.CQRS.Queries.CategoryQueries;
using RentSwiftly.Application.Features.CQRS.Results.CategoryResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CategoryHandlers;

public class GetCategoryByIdQueryHandler
{
    private readonly IRepository<Category> _repository;

    public GetCategoryByIdQueryHandler(IRepository<Category> repository)
    {
        _repository = repository;
    }

    public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCategoryByIdQueryResult
        {
            CategoryID = value.CategoryID,
            Name = value.Name
        };
    }
}
