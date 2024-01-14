using RentSwiftly.Application.Features.CQRS.Results.BannerResults;
using RentSwiftly.Application.Interfaces;
using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Handlers.BannerHandlers;

public class GetBannerQueryHandler
{
    private readonly IRepository<Banner> _repository;

    public GetBannerQueryHandler(IRepository<Banner> repository)
    {
        _repository = repository;
    }

    public async Task<List<GetBannerQueryResult>> Handle()
    {
        var values = await _repository.GetAllAsync();
        return values.Select(x => new GetBannerQueryResult
        {
            Title = x.Title,
            Description = x.Description,
            VideoDescription = x.VideoDescription,
            VideoUrl = x.VideoUrl,
            BannerID = x.BannerID
        }).ToList();
    }
}
