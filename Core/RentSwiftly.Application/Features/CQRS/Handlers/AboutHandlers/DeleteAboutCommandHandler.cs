using RentSwiftly.Application.Features.CQRS.Commands.AboutCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.AboutHandlers;

public class DeleteAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public DeleteAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteAboutCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.DeleteAsync(value);
    }
}
