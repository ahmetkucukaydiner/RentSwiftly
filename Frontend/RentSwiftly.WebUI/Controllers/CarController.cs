using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.CarDtos;

namespace RentSwiftly.WebUI.Controllers
{
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Araçlar";
            ViewBag.v2 = "Aracınızı seçiniz";
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7000/api/Cars/GetCarWithBrands");
            if(responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCarWithBrandsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
