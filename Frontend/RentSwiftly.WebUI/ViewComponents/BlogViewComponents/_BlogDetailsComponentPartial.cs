using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
