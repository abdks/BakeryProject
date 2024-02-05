using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _HeaderComponentPartial : ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
