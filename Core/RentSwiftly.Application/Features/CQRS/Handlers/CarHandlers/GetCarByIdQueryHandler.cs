using RentSwiftly.Application.Features.CQRS.Queries.CarQueries;
using RentSwiftly.Application.Features.CQRS.Results.CarResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarByIdQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarByIdQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetCarByIdQueryResult
        {
            Baggage = value.Baggage,
            BigImageUrl = value.BigImageUrl,
            BrandID = value.BrandID,
            CarID = value.CarID,
            CoverImageUrl = value.CoverImageUrl,
            Fuel = value.Fuel,
            Kilometer = value.Kilometer,
            Model = value.Model,
            Seat = value.Seat,
            Transmission = value.Transmission
        };
    }
}
