using RentSwiftly.Application.Features.CQRS.Commands.BrandCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BrandHandlers;

public class UpdateBrandCommandHandler
{
    private readonly IRepository<Brand> _repository;

    public UpdateBrandCommandHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBrandCommand command)
    {
        var value = await _repository.GetByIdAsync(command.BrandId);
        value.Name = command.Name;
        await _repository.UpdateAsync(value);
    }
}
