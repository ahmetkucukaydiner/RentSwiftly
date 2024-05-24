using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Interfaces.ReviewInterfaces
{
	public interface IReviewRepository
	{
		List<Review> GetReviewsByCarId(int carId);
	}
}
