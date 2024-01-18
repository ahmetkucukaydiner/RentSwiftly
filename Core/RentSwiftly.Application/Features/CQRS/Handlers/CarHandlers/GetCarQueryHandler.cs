using RentSwiftly.Application.Features.CQRS.Results.CarResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarQueryHandler
{
    private readonly IRepository<Car> _repository;

    public GetCarQueryHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetCarQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetCarQueryResult
        {
            Baggage = x.Baggage,
            BigImageUrl = x.BigImageUrl,
            BrandID = x.BrandID,
            CarID = x.CarID,
            CoverImageUrl = x.CoverImageUrl,
            Fuel = x.Fuel,
            Kilometer = x.Kilometer,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission
        }).ToList();
    }
}
