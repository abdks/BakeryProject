using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class NewProductPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
