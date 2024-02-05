using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace BakeryProject.ViewComponents
{
	public class _NewsComponentPartial: ViewComponent 
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
