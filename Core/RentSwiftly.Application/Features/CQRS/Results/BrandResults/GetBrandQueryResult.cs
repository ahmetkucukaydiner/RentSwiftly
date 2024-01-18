using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Results.BrandResults;

public class GetBrandQueryResult
{
    public int BrandId { get; set; }
    public string Name { get; set; }
}
