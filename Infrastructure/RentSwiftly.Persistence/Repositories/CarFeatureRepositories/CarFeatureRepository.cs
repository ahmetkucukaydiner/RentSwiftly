using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.CarFeatureInterfaces;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;

namespace RentSwiftly.Persistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly RentSwiftlyContext _context;

        public CarFeatureRepository(RentSwiftlyContext context)
        {
            _context = context;
        }

        public List<CarFeature> GetCarFeaturesByCarId(int carId)
        {
            var values = _context.CarFeatures.Include(y => y.Feature).Where(x => x.CarID == carId).ToList();
            return values;
        }
    }
}
