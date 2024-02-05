using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
	public class DeneController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
