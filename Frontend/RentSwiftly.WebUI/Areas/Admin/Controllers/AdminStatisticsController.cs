using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.StatisticsDtos;

namespace RentSwiftly.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminStatistics")]
    public class AdminStatisticsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminStatisticsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            #region CarCount
            Random carCount = new Random();             
            var responseMessageCarCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCount");
            if(responseMessageCarCount.IsSuccessStatusCode)
            {
                int carCountProgress = carCount.Next(1, 101);
                var jsonData = await responseMessageCarCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCount = values.CarCount;
                ViewBag.CarCountProgress = carCountProgress;
            }
            #endregion

            #region LocationCount
            Random locationCount = new Random();
            var responseMessageLocationCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetLocationCount");
            if (responseMessageLocationCount.IsSuccessStatusCode)
            {
                int locationCountProgress = locationCount.Next(1, 101);
                var jsonData = await responseMessageLocationCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.LocationCount = values.LocationCount;
                ViewBag.LocationCountProgress = locationCountProgress;
            }
            #endregion

            #region AuthorCount
            Random authorCount = new Random();
            var responseMessageAuthorCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetAuthorCount");
            if (responseMessageAuthorCount.IsSuccessStatusCode)
            {
                int authorCountProgress = authorCount.Next(1, 101);
                var jsonData = await responseMessageAuthorCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.AuthorCount = values.AuthorCount;
                ViewBag.AuthorCountProgress = authorCountProgress;
            }
            #endregion

            #region BlogCount
            Random blogCount = new Random();
            var responseMessageBlogCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetBlogCount");
            if (responseMessageBlogCount.IsSuccessStatusCode)
            {
                int blogCountProgress = blogCount.Next(1, 101);
                var jsonData = await responseMessageBlogCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.BlogCount = values.BlogCount;
                ViewBag.BlogCountProgress = blogCountProgress;
            }
            #endregion

            #region BrandCount
            Random brandCount = new Random();
            var responseMessageBrandCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetBrandCount");
            if (responseMessageBrandCount.IsSuccessStatusCode)
            {
                int brandCountProgress = brandCount.Next(1, 101);
                var jsonData = await responseMessageBrandCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.BrandCount = values.BrandCount;
                ViewBag.BrandCountProgress = brandCountProgress;
            }
            #endregion

            #region AverageRentPriceForDaily
            Random averageRentPriceForDaily = new Random();
            var responseMessageAverageRentPriceForDaily = await client.GetAsync("https://localhost:7000/api/Statistics/GetAverageRentPriceForDaily");
            if (responseMessageAverageRentPriceForDaily.IsSuccessStatusCode)
            {
                int averageRentPriceForDailyProgress = averageRentPriceForDaily.Next(1, 101);
                var jsonData = await responseMessageAverageRentPriceForDaily.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.AverageRentPriceForDaily = values.AverageRentPriceForDaily.ToString("0.00");
                ViewBag.AverageRentPriceForDailyProgress = averageRentPriceForDailyProgress;
            }
            #endregion

            #region AverageRentPriceForWeekly
            Random averageRentPriceForWeekly = new Random();
            var responseMessageAverageRentPriceForWeekly = await client.GetAsync("https://localhost:7000/api/Statistics/GetAverageRentPriceForWeekly");
            if (responseMessageAverageRentPriceForWeekly.IsSuccessStatusCode)
            {
                int averageRentPriceForWeeklyProgress = averageRentPriceForWeekly.Next(1, 101);
                var jsonData = await responseMessageAverageRentPriceForWeekly.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.AverageRentPriceForWeekly = values.AverageRentPriceForWeekly.ToString("0.00");
                ViewBag.AverageRentPriceForWeeklyProgress = averageRentPriceForWeeklyProgress;
            }
            #endregion

            #region AverageRentPriceForMonthly
            Random averageRentPriceForMonthly = new Random();
            var responseMessageAverageRentPriceForMonthly = await client.GetAsync("https://localhost:7000/api/Statistics/GetAverageRentPriceForMonthly");
            if (responseMessageAverageRentPriceForMonthly.IsSuccessStatusCode)
            {
                int averageRentPriceForMonthlyProgress = averageRentPriceForMonthly.Next(1, 101);
                var jsonData = await responseMessageAverageRentPriceForMonthly.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.AverageRentPriceForMonthly = values.AverageRentPriceForMonthly.ToString("0.00");
                ViewBag.AverageRentPriceForMonthlyProgress = averageRentPriceForMonthlyProgress;
            }
            #endregion

            #region CarCountByTransmissionIsAuto
            Random carCountByTransmissionIsAuto = new Random();
            var responseMessagecarCountByTransmissionIsAuto = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCountByTransmissionIsAuto");
            if (responseMessagecarCountByTransmissionIsAuto.IsSuccessStatusCode)
            {
                int carCountByTransmissionIsAutoProgress = carCountByTransmissionIsAuto.Next(1, 101);
                var jsonData = await responseMessagecarCountByTransmissionIsAuto.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCountByTransmissionIsAuto = values.CarCountByTransmissionIsAuto;
                ViewBag.CarCountByTransmissionIsAutoProgress = carCountByTransmissionIsAutoProgress;
            }
            #endregion

            #region BrandNameByMaxCar
            Random brandNameByMaxCar = new Random();
            var responseMessagebrandNameByMaxCar = await client.GetAsync("https://localhost:7000/api/Statistics/GetBrandNameByMaxCar");
            if (responseMessagebrandNameByMaxCar.IsSuccessStatusCode)
            {
                int brandNameByMaxCarProgress = brandNameByMaxCar.Next(1, 101);
                var jsonData = await responseMessagebrandNameByMaxCar.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.BrandNameByMaxCar = values.BrandNameByMaxCar;
                ViewBag.BrandNameByMaxCarProgress = brandNameByMaxCarProgress;
            }
            #endregion

            #region BlogTitleByMaxBlogComment
            Random blogTitleByMaxBlogComment = new Random();
            var responseMessageBlogTitleByMaxBlogComment = await client.GetAsync("https://localhost:7000/api/Statistics/GetBlogTitleByMaxBlogComment");
            if (responseMessageBlogTitleByMaxBlogComment.IsSuccessStatusCode)
            {
                int blogTitleByMaxBlogCommentProgress = blogTitleByMaxBlogComment.Next(1, 101);
                var jsonData = await responseMessageBlogTitleByMaxBlogComment.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.BlogTitleByMaxBlogComment = values.BlogTitleByMaxBlogComment;
                ViewBag.BlogTitleByMaxBlogCommentProgress = blogTitleByMaxBlogCommentProgress;
            }
            #endregion

            #region CarCountByKilometerLowerThan1000
            Random carCountByKilometerLowerThan1000 = new Random();
            var responseMessageCarCountByKilometerLowerThan1000 = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCountByKilometerLowerThan1000");
            if (responseMessageCarCountByKilometerLowerThan1000.IsSuccessStatusCode)
            {
                int carCountByKilometerLowerThan1000Progress = carCountByKilometerLowerThan1000.Next(1, 101);
                var jsonData = await responseMessageCarCountByKilometerLowerThan1000.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCountByKilometerLowerThan1000 = values.CarCountByKilometerLowerThan1000;
                ViewBag.CarCountByKilometerLowerThan1000Progress = carCountByKilometerLowerThan1000Progress;
            }
            #endregion

            #region CarCountByFuelGasolineOrDiesel
            Random carCountByFuelGasolineOrDiesel = new Random();
            var responseMessageCarCountByFuelGasolineOrDiesel = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCountByFuelGasolineOrDiesel");
            if (responseMessageCarCountByFuelGasolineOrDiesel.IsSuccessStatusCode)
            {
                int carCountByFuelGasolineOrDieselProgress = carCountByFuelGasolineOrDiesel.Next(1, 101);
                var jsonData = await responseMessageCarCountByFuelGasolineOrDiesel.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCountByFuelGasolineOrDiesel = values.CarCountByFuelGasolineOrDiesel;
                ViewBag.CarCountByFuelGasolineOrDieselProgress = carCountByFuelGasolineOrDieselProgress;
            }
            #endregion

            #region CarCountByFuelElectric
            Random carCountByFuelElectric = new Random();
            var responseMessageCarCountByFuelElectric = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessageCarCountByFuelElectric.IsSuccessStatusCode)
            {
                int carCountByFuelElectricProgress = carCountByFuelElectric.Next(1, 101);
                var jsonData = await responseMessageCarCountByFuelElectric.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCountByFuelElectric = values.CarCountByFuelElectric;
                ViewBag.CarCountByFuelElectricProgress = carCountByFuelElectricProgress;
            }
            #endregion

            #region CarBrandAndModelByRentPriceDailyMax
            Random carBrandAndModelByRentPriceDailyMax = new Random();
            var responseMessageCarBrandAndModelByRentPriceDailyMax = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarBrandAndModelByRentPriceDailyMax");
            if (responseMessageCarBrandAndModelByRentPriceDailyMax.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMaxProgress = carBrandAndModelByRentPriceDailyMax.Next(1, 101);
                var jsonData = await responseMessageCarBrandAndModelByRentPriceDailyMax.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarBrandAndModelByRentPriceDailyMax = values.CarBrandAndModelByRentPriceDailyMax;
                ViewBag.CarBrandAndModelByRentPriceDailyMaxProgress = carBrandAndModelByRentPriceDailyMaxProgress;
            }
            #endregion

            #region CarBrandAndModelByRentPriceDailyMin
            Random carBrandAndModelByRentPriceDailyMin = new Random();
            var responseMessageCarBrandAndModelByRentPriceDailyMin = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarBrandAndModelByRentPriceDailyMin");
            if (responseMessageCarBrandAndModelByRentPriceDailyMin.IsSuccessStatusCode)
            {
                int carBrandAndModelByRentPriceDailyMinProgress = carBrandAndModelByRentPriceDailyMin.Next(1, 101);
                var jsonData = await responseMessageCarBrandAndModelByRentPriceDailyMin.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarBrandAndModelByRentPriceDailyMin = values.CarBrandAndModelByRentPriceDailyMin;
                ViewBag.CarBrandAndModelByRentPriceDailyMinProgress = carBrandAndModelByRentPriceDailyMinProgress;
            }
            #endregion

            return View();
        }
    }
}
