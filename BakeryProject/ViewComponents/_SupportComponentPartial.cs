using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _SupportComponentPartial : ViewComponent
	{
		//public async Task<IViewComponentResult> InvokeAsync()
		//{
		//	return View();
		//}
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
