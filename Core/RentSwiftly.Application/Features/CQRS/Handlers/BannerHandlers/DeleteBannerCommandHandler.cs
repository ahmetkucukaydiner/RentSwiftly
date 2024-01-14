using RentSwiftly.Application.Features.CQRS.Commands.BannerCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BannerHandlers;

public class DeleteBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public DeleteBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteBannerCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.DeleteAsync(value);
    }
}
