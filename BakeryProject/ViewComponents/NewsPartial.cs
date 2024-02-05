using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;

namespace BakeryProject.ViewComponents
{
	public class NewsPartial: ViewComponent 
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
			return View();
		}
	}
}
