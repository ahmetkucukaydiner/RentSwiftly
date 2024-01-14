using RentSwiftly.Application.Features.CQRS.Commands.AboutCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.AboutHandlers;

public class UpdateAboutCommandHandler
{
    private readonly IRepository<About> _repository;

    public UpdateAboutCommandHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateAboutCommand command)
    {
        var values = await _repository.GetByIdAsync(command.AboutID);

        values.Description = command.Description;
        values.Title = command.Title;
        values.ImageUrl = command.ImageUrl;
        await _repository.UpdateAsync(values);
    }
}
