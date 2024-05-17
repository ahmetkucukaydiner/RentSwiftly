using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.CarFeatureDtos;
using RentSwiftly.Dto.FeatureDtos;

namespace RentSwiftly.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminCarFeatureDetail")]
    public class AdminCarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminCarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index/{id}")]
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7000/api/CarFeatures?carId=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarFeatureByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("Index/{id}")]
        [HttpPost]
        public async Task<IActionResult> Index(List<ResultCarFeatureByCarIdDto> resultCarFeatureByCarIdDto)
        {
            var client = _httpClientFactory.CreateClient();

            foreach (var item in resultCarFeatureByCarIdDto)
            {
                if (item.Available)
                {
                    await client.GetAsync("https://localhost:7000/api/carfeatures/CarFeatureChangeAvailableToTrue?id=" + item.CarFeatureId);
                }
                else
                {
                    await client.GetAsync("https://localhost:7000/api/carfeatures/CarFeatureChangeAvailableToFalse?id=" + item.CarFeatureId);
                }
            }
            return RedirectToAction("Index", "AdminCar");
        }

        [Route("CreateFeatureByCarId")]
        [HttpGet]
        public async Task<IActionResult> CreateFeatureByCarId()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7000/api/features");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultFeatureDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}