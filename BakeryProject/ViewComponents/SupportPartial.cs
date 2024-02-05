using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class SupportPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}

	}
}
