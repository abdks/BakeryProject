using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _FiveComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
