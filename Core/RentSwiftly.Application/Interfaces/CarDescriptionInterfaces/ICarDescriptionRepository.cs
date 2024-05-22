using RentSwiftly.Domain.Entities;

namespace RentSwiftly.Application.Interfaces.CarDescriptionInterfaces
{
	public interface ICarDescriptionRepository
	{
		Task<CarDescription> GetCarDescriptionByCarId(int carId);
	}
}
