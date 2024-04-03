using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RentSwiftly.Dto.ServiceDtos;

namespace RentSwiftly.WebUI.Controllers
{
    public class ServiceController : Controller
    {       
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Hizmetler";
            ViewBag.v2 = "Hizmetlerimiz";
            return View();
        }
    }
}
