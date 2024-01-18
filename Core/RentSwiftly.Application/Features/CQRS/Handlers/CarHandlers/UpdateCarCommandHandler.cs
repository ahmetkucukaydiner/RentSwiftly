using RentSwiftly.Application.Features.CQRS.Commands.CarCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.CarHandlers;

public class UpdateCarCommandHandler
{
    private readonly IRepository<Car> _repository;

    public UpdateCarCommandHandler(IRepository<Car> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateCarCommand command)
    {
        var value = await _repository.GetByIdAsync(command.CarID);
        value.Fuel = command.Fuel;
        value.Seat = command.Seat;
        value.BrandID = command.BrandID;
        value.Transmission = command.Transmission;
        value.Baggage = command.Baggage;
        value.BigImageUrl = command.BigImageUrl;
        value.CoverImageUrl = command.CoverImageUrl;
        value.Model = command.Model;
        value.Kilometer = command.Kilometer;
        await _repository.UpdateAsync(value);
    }
}
