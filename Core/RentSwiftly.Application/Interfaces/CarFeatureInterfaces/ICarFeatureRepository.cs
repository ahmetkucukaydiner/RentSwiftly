using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        List<CarFeature> GetCarFeaturesByCarId(int carId);
    }
}
