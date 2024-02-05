using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class ServicesPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
