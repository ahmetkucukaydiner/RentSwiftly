using RentSwiftly.Application.Features.CQRS.Commands.BannerCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BannerHandlers;

public class UpdateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public UpdateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateBannerCommand command)
    {
        var value = await _repository.GetByIdAsync(command.BannerID);
        value.VideoDescription = command.VideoDescription;
        value.VideoUrl = command.VideoUrl;
        value.Description = command.Description;
        value.Title = command.Title;
        await _repository.UpdateAsync(value);
    }
}
