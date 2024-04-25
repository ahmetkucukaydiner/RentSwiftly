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
            Random carCount = new Random(); 
            var client = _httpClientFactory.CreateClient();
            var responseMessageCarCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetCarCount");
            if(responseMessageCarCount.IsSuccessStatusCode)
            {
                int carCountProgress = carCount.Next(1, 101);
                var jsonData = await responseMessageCarCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.CarCount = values.CarCount;
                ViewBag.CarCountProgress = carCountProgress;
            }

            Random locationCount = new Random();
            var responseMessageLocationCount = await client.GetAsync("https://localhost:7000/api/Statistics/GetLocationCount");
            if (responseMessageLocationCount.IsSuccessStatusCode)
            {
                int locationCountProgress = locationCount.Next(1, 101);
                var jsonData = await responseMessageLocationCount.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ResultStatisticsDto>(jsonData);
                ViewBag.locationCount = values.LocationCount;
                ViewBag.locationCountProgress = locationCountProgress;
            }
            return View();
        }
    }
}
