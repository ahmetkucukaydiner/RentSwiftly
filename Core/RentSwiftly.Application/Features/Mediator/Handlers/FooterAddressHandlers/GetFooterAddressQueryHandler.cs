using MediatR;
using RentSwiftly.Application.Features.Mediator.Queries.FooterQueries;
using RentSwiftly.Application.Features.Mediator.Results.FooterAddressResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Application.Features.Mediator.Handlers.FooterAddressHandlers;

public class GetFooterAddressQueryHandler : IRequestHandler<GetFooterAddressQuery, List<GetFooterAddressQueryResult>>
{
    private readonly IRepository<FooterAddress> _repository;

    public GetFooterAddressQueryHandler(IRepository<FooterAddress> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetFooterAddressQueryResult>> Handle(GetFooterAddressQuery request, CancellationToken cancellationToken)
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetFooterAddressQueryResult
        {
            Address = x.Address,
            Description = x.Description,
            Email = x.Email,
            FooterAddressID = x.FooterAddressID,
            PhoneNumber = x.PhoneNumber
        }).ToList();
    }
}
