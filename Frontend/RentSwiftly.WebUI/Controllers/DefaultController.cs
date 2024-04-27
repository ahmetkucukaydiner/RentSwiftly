using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using RentSwiftly.Dto.LocationDtos;

namespace RentSwiftly.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7000/api/locations");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultLocationDto>>(jsonData);
            List<SelectListItem> result = (from x in values
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.LocationId.ToString()
                                           }).ToList();
            ViewBag.LocationResult = result;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string id)
        {

        }
    }
}
