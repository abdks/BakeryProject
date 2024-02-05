using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _NewComponentProductPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
