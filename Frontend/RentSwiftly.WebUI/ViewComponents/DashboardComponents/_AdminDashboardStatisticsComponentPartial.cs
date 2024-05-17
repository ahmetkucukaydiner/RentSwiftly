using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.StatisticsDtos;

namespace RentSwiftly.WebUI.ViewComponents.DashboardComponents
{
    public class _AdminDashboardStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _AdminDashboardStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            #region CarCount
            Random carCount = new Random();
            var responseMessageCarCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCount");
            if (responseMessageCarCount.IsSuccessStatusCode)
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

            return View();
        }
    }
}