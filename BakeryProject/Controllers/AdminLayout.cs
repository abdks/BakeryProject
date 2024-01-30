using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class AdminLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
