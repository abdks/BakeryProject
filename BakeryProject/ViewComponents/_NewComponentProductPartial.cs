using BakeryProject.CQRSPattern.Handlers.NewProduct;
using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.ViewComponents
{
	public class _NewComponentProductPartial : ViewComponent
	{
		private readonly GetNewProductQueryHandler _getNewProductQueryHandler;

		public _NewComponentProductPartial(GetNewProductQueryHandler getNewProductQueryHandler)
		{
			_getNewProductQueryHandler = getNewProductQueryHandler;
		}

		public IViewComponentResult Invoke()
		{
			var values = _getNewProductQueryHandler.Handle();
			return View(values);
		}
	}
}
