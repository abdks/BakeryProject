using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class HeadPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
