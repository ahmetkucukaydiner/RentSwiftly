using RentSwiftly.Application.Interfaces.ReviewInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;

namespace RentSwiftly.Persistence.Repositories.ReviewRepositories
{
	public class ReviewRepository : IReviewRepository
	{
		private readonly RentSwiftlyContext _context;

		public ReviewRepository(RentSwiftlyContext context)
		{
			_context = context;
		}

		public List<Review> GetReviewsByCarId(int carId)
		{
			var values = _context.Reviews.Where(x => x.CarID == carId).ToList();
			return values;
		}
	}
}
