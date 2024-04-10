using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
