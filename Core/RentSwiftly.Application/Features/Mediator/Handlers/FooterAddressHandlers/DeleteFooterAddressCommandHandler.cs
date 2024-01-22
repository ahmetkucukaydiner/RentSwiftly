using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.FooterAddressCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class DeleteFooterAddressCommandHandler : IRequestHandler<DeleteFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public DeleteFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.DeleteAsync(value);
    }
}
