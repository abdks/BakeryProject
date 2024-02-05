using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class SliderPartial : ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
