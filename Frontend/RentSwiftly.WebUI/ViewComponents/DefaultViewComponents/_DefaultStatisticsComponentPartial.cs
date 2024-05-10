using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.StatisticsDtos;

namespace RentSwiftly.WebUI.ViewComponents.DefaultViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultStatisticsComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            #region CarCount
            var client = _httpClientFactory.CreateClient();
            var responseMessageCarCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCount");
            if (responseMessageCarCount.IsSuccessStatusCode)
            {
                var jsonData = await responseMessageCarCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCount = values.CarCount;
            }
            #endregion

            #region LocationCount
            var responseMessageLocationCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetLocationCount");
            if (responseMessageLocationCount.IsSuccessStatusCode)
            {
                var jsonData = await responseMessageLocationCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.LocationCount = values.LocationCount;
            }
            #endregion

            #region BrandCount
            var responseMessageBrandCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetBrandCount");
            if (responseMessageBrandCount.IsSuccessStatusCode)
            {
                var jsonData = await responseMessageBrandCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.BrandCount = values.BrandCount;
            }
            #endregion

            #region CarCountByFuelElectric
            var responseMessageCarCountByFuelElectric = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCountByFuelElectric");
            if (responseMessageCarCountByFuelElectric.IsSuccessStatusCode)
            {
                var jsonData = await responseMessageCarCountByFuelElectric.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCountByFuelElectric = values.CarCountByFuelElectric;
            }
            #endregion

            return View();
        }
    }
}
