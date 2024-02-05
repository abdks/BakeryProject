using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _ServicesComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
