using RentSwiftly.Application.Features.CQRS.Commands.ContactCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.CQRS.Handlers.ContactHandlers;

public class DeleteContactCommandHandler
{
    private readonly IRepository<Contact> _repository;

    public DeleteContactCommandHandler(IRepository<Contact> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteContactCommand command)
    {
        var value = await _repository.GetByIdAsync(command.Id);
        await _repository.DeleteAsync(value);
    }
}
