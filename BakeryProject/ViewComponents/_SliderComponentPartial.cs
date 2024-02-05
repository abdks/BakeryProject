using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _SliderComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
