using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailTabPaneComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
