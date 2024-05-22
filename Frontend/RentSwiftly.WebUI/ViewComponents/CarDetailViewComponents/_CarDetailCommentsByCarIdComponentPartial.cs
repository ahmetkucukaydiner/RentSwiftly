using Microsoft.AspNetCore.Mvc;

namespace RentSwiftly.WebUI.ViewComponents.CarDetailViewComponents
{
	public class _CarDetailCommentsByCarIdComponentPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
