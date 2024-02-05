using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class OnePagePartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
