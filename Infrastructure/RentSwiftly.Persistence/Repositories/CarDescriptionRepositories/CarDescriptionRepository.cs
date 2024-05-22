using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.CarDescriptionInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;

namespace RentSwiftly.Persistence.Repositories.CarDescriptionRepositories
{
	public class CarDescriptionRepository : ICarDescriptionRepository
	{
		private readonly RentSwiftlyContext _context;

		public CarDescriptionRepository(RentSwiftlyContext context)
		{
			_context = context;
		}

		public async Task<CarDescription> GetCarDescriptionByCarId(int carId)
		{
			var values = await _context.CarDescriptions.Where(x => x.CarID == carId).FirstOrDefaultAsync();
			return values;
		}
	}
}