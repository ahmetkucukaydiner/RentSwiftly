using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.Controllers
{
    public class SignalRCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
