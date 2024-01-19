using RentSwiftly.Application.Features.CQRS.Results.CarResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Application.Interfaces.CarInterfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers;

public class GetCarWithBrandQueryHandler
{
    private readonly ICarRepository _carRepository;

    public GetCarWithBrandQueryHandler(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public List<GetCarWithBrandQueryResult> Handle()
    {
        var values = _carRepository.GetCarsListWithBrands();
        return values.Select(x => new GetCarWithBrandQueryResult
        {
            BrandName = x.Brand.Name,
            Baggage = x.Baggage,
            BigImageUrl = x.BigImageUrl,
            CoverImageUrl = x.CoverImageUrl,
            Fuel = x.Fuel,
            Kilometer = x.Kilometer,
            Model = x.Model,
            Seat = x.Seat,
            Transmission = x.Transmission,
            BrandID = x.BrandID,
            CarID = x.CarID
        }).ToList();
    }
}