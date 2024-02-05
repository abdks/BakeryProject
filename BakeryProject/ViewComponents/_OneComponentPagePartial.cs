using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _OneComponentPagePartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
