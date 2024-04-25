using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentSwiftly.Dto.StatisticsDtos
{
    public class ResultStatisticsDto
    {
        public int CarCount { get; set; }
        public int LocationCount { get; set; }
        public int AuthorCount { get; set; }
        public int BlogCount { get; set; }
        public int BrandCount { get; set; }
        public decimal AverageRentPriceForDaily { get; set; }
        public decimal AverageRentPriceForWeekly { get; set; }
        public decimal AverageRentPriceForMonthly { get; set; }
        public int CarCountByTransmissionIsAuto { get; set; }
        public string BrandNameByMaxCar { get; set; }
        public string BlogTitleByMaxBlogComment { get; set; }
        public int CarCountByKilometerLowerThan1000 { get; set; }
        public int CarCountByFuelGasolineOrDiesel { get; set; }
        public int CarCountByFuelElectric { get; set; }
        public decimal CarBrandAndModelByRentPriceDailyMax { get; set; }
        public decimal CarBrandAndModelByRentPriceDailyMin { get; set; }
    }
}
