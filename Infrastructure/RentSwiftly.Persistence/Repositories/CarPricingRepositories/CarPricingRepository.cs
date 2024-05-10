using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.CarPricingInterfaces;
using RentSwiftly.Application.Models;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;

namespace RentSwiftly.Persistence.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
	{
		private readonly RentSwiftlyContext _context;

		public CarPricingRepository(RentSwiftlyContext context)
		{
			_context = context;
		}

		public List<CarPricing> GetCarPricingWithCars()
		{
			var values = _context.CarPricings.Include(x => x.Car).ThenInclude(y => y.Brand).Include(z => z.Pricing).Where(a => a.PricingID == 1).ToList();
			return values;
		}

		public List<CarPricingModel> GetCarPricingWithTimePeriod()
		{
			List<CarPricingModel> values = new List<CarPricingModel>();
			using (var command = _context.Database.GetDbConnection().CreateCommand())
			{
				command.CommandText = "select * from (select Brands.Name, Model, CoverImageUrl,  PricingID, Amount from CarPricings inner join Cars on Cars.CarID = CarPricings.CarID inner join Brands on Brands.BrandID = Cars.BrandID) as SourceTable Pivot (Sum(Amount) for PricingID In ([1],[2],[3])) as PivotTable;";
				command.CommandType = System.Data.CommandType.Text;
				_context.Database.OpenConnection();
				using (var reader = command.ExecuteReader())
				{
					while (reader.Read())
					{
						CarPricingModel carPricingModel = new CarPricingModel()
						{
							BrandName = reader["Name"].ToString(),
							Model = reader["Model"].ToString(),
							CoverImageUrl = reader["CoverImageUrl"].ToString(),
							Amounts = new List<decimal>
							{
								Convert.ToDecimal(reader[3]),
								Convert.ToDecimal(reader[4]),
								Convert.ToDecimal(reader[5])
							}
						};
						values.Add(carPricingModel);
					}
				}
				_context.Database.CloseConnection();
				return values;
			}
		}
	}
}
