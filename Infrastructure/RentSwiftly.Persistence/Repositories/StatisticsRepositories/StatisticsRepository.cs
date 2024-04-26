using Microsoft.EntityFrameworkCore;
using RentSwiftly.Application.Interfaces.StatisticsInterfaces;
using RentSwiftly.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Persistence.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly RentSwiftlyContext _context;

        public StatisticsRepository(RentSwiftlyContext context)
        {
            _context = context;
        }

        public string GetBlogTitleByMaxBlogComment()
        {
            var commentValues = _context.Comments.GroupBy(x => x.BlogID)
                .Select(y => new
                {
                    BlogID = y.Key,
                    Count = y.Count()
                }).OrderByDescending(z=>z.Count).Take(1).FirstOrDefault();

            string blogName = _context.Blogs.Where(x => x.BlogID == commentValues.BlogID).Select(y => y.Title).FirstOrDefault();

            return blogName;
        }

        public string GetBrandNameByMaxCar()
        {
            var brandValue = _context.Cars.GroupBy(x => x.BrandID).Select(y => new
            {
                BrandID = y.Key,
                Count = y.Count()
            }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();

            string brandName = _context.Brands.Where(x=>x.BrandId == brandValue.BrandID).Select(y=>y.Name).FirstOrDefault();

            return brandName;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }

        public decimal GetAverageRentPriceForDaily()
        {
            var id = _context.Pricings.Where(x => x.Name == "Günlük").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(y => y.Amount);
            return value;
        }

        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public string GetCarBrandAndModelByRentPriceDailyMax()
        {
            int pricingID = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingID).Max(x => x.Amount);
            int carID = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carID).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public string GetCarBrandAndModelByRentPriceDailyMin()
        {
            int pricingID = _context.Pricings.Where(x => x.Name == "Günlük").Select(y => y.PricingID).FirstOrDefault();
            decimal amount = _context.CarPricings.Where(y => y.PricingID == pricingID).Min(x => x.Amount);
            int carID = _context.CarPricings.Where(x => x.Amount == amount).Select(y => y.CarID).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarID == carID).Include(y => y.Brand).Select(z => z.Brand.Name + " " + z.Model).FirstOrDefault();
            return brandModel;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektrikli").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByKilometerLowerThan1000()
        {
            var value = _context.Cars.Where(x=>x.Kilometer <= 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionIsAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }

        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }

        public decimal GetAverageRentPriceForMonthly()
        {
            var id = _context.Pricings.Where(x => x.Name == "Aylık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(y => y.Amount);
            return value;
        }

        public decimal GetAverageRentPriceForWeekly()
        {
            var id = _context.Pricings.Where(x => x.Name == "Haftalık").Select(z => z.PricingID).FirstOrDefault();
            var value = _context.CarPricings.Where(w => w.PricingID == id).Average(y => y.Amount);
            return value;
        }
    }
}