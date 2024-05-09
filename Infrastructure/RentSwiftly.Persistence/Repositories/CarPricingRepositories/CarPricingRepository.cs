using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.CarPricingInterfaces;
using RentSwiftly.Application.Models;
using RentSwiftly.Domain.Entities;
using RentSwiftly.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

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
			
		}
    }
}
