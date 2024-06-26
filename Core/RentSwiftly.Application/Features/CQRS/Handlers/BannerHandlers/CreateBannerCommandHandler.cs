﻿using RentSwiftly.Application.Features.CQRS.Commands.BannerCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BannerHandlers;

public class CreateBannerCommandHandler
{
    private readonly IRepository<Banner> _repository;

    public CreateBannerCommandHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task Handle(CreateBannerCommand command)
    {
        await _repository.CreateAsync(new Banner
        {
            Description = command.Description,
            Title = command.Title,
            VideoDescription = command.VideoDescription,
            VideoUrl = command.VideoUrl,
        });
    }
}
