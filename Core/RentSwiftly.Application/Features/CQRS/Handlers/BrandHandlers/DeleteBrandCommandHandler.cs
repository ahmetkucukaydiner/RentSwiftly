using RentSwiftly.Application.Features.CQRS.Commands.BrandCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BrandHandlers;

public class DeleteBrandCommandHandler
{
    private readonly IRepository<Brand> _repository;

    public DeleteBrandCommandHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteBrandCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.DeleteAsync(value);
    }
}
