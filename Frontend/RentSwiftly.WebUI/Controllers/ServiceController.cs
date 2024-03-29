using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.ServiceDtos;

namespace RentSwiftly.WebUI.Controllers
{
    public class ServiceController : Controller
    {       
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
