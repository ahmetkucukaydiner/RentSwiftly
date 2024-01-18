using RentSwiftly.Application.Features.CQRS.Commands.CarCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers;

public class CreateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public CreateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateCarCommand command)
    {
        await _repository.CreateAsync(new Car
        {
            Baggage = command.Baggage,
            BigImageUrl = command.BigImageUrl,
            BrandID = command.BrandID,
            CoverImageUrl = command.CoverImageUrl,
            Fuel = command.Fuel,
            Kilometer = command.Kilometer,
            Model = command.Model,
            Seat = command.Seat,
            Transmission = command.Transmission
        });
    }
}
