using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _HeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
