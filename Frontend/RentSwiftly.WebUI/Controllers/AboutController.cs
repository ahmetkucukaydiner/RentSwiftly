using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
