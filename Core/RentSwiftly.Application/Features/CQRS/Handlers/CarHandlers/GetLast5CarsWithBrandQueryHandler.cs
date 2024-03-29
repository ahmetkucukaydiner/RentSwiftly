using RentSwiftly.Application.Features.CQRS.Results.CarResults;
using RentSwiftly.Application.Interfaces.CarInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetLast5CarsWithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetLast5CarsWithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public List<GetLast5CarsWithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetLast5CarsWithBrands();

            return values.Select(x=> new GetLast5CarsWithBrandQueryResult
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
}
