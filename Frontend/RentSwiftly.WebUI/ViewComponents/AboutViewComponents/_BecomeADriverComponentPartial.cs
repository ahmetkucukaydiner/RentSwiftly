using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.ViewComponents.AboutViewComponents;

public class _BecomeADriverComponentPartial : ViewComponent
{
	public IViewComponentResult Invoke()
	{
		return View();
	}
}
