using RentSwiftly.Application.Features.CQRS.Queries.BrandQueries;
using RentSwiftly.Application.Features.CQRS.Results.BrandResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BrandHandlers;

public class GetBrandByIdQueryHandler
{
    private readonly IRepository<Brand> _repository;

    public GetBrandByIdQueryHandler(IRepository<Brand> repository)
    {
        _repository = repository;
    }

    public async Task<GetBrandByIdQueryResult> Handle(GetBrandByIdQuery query)
    {
        var value = await _repository.GetByIdAsync(query.Id);
        return new GetBrandByIdQueryResult
        {
            BrandId = value.BrandId,
            Name = value.Name
        };
    }
}
