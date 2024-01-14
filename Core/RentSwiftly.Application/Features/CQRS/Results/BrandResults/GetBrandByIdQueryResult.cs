using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Features.CQRS.Results.BrandResults;

public class GetBrandByIdQueryResult
{
    public int BrandId { get; set; }
    public string Name { get; set; }
    public List<Car> Cars { get; set; }
}
