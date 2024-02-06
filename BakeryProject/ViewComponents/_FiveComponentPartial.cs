using BakeryProject.CQRSPattern.Handlers.FiveProduct;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _FiveComponentPartial : ViewComponent
	{
		private readonly GetFiveProductQueryHandler _getFiveProductQueryHandler;

		public _FiveComponentPartial(GetFiveProductQueryHandler getFiveProductQueryHandler)
		{
			_getFiveProductQueryHandler = getFiveProductQueryHandler;
		}

		public IViewComponentResult Invoke()
		{
			var values = _getFiveProductQueryHandler.Handle();
			return View(values);
		}
	}
}
