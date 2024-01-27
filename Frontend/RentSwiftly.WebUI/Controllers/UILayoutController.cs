using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
