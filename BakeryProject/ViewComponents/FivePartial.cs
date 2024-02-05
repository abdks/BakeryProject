using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class FivePartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
