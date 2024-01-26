using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.PricingCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.PricingHandlers;

public class DeletePricingCommandHandler : IRequestHandler<DeletePricingCommand>
{
    private readonly IRepository<Pricing> _repository;

    public DeletePricingCommandHandler(IRepository<Pricing> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeletePricingCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.Id);
        await _repository.DeleteAsync(value);   
    }
}
