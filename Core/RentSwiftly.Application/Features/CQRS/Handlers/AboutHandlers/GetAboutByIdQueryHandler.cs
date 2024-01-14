using RentSwiftly.Application.Features.CQRS.Queries.AboutQueries;
using RentSwiftly.Application.Features.CQRS.Results.AboutResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.AboutHandlers;

public class GetAboutByIdQueryHandler
{
    private readonly IRepository<About> _repository;

    public GetAboutByIdQueryHandler(IRepository<About> repository)
    {
        _repository = repository;
    }

    public async Task<GetAboutByIdQueryResult> Handle(GetAboutByIdQuery query)
    {
        var values = await _repository.GetByIdAsync(query.Id);
        return new GetAboutByIdQueryResult
        {
            AboutID = values.AboutID,
            Description = values.Description,
            ImageUrl = values.ImageUrl,
            Title = values.Title
        };
    }
}