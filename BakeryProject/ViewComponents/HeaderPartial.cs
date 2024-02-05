using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class HeaderPartial : ViewComponent
	{

		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
