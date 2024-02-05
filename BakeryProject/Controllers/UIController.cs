using Microsoft.AspNetCore.Mvc;

namespace BakeryProject.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
