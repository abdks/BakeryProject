using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace BakeryProject.ViewComponents
{
	public class _StatsComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
