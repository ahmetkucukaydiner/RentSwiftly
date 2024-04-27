using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.Controllers
{
    public class RentACarListController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
