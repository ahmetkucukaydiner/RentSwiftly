﻿using MediatR;
using RentSwiftly.Application.Features.Mediator.Commands.FooterAddressCommands;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class UpdateFooterAddressCommandHandler : IRequestHandler<UpdateFooterAddressCommand>
{
    private readonly IRepository<FooterAddress> _repository;

    public UpdateFooterAddressCommandHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task Handle(UpdateFooterAddressCommand request, CancellationToken cancellationToken)
    {
        var value = await _repository.GetByIdAsync(request.FooterAddressID);
        value.PhoneNumber = request.PhoneNumber;
        value.Address = request.Address;
        value.Description = request.Description;
        value.Email = request.Email;
        await _repository.UpdateAsync(value);
    }
}
