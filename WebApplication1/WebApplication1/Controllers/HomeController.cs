using Microsoft.AspNetCore.Mvc;

namespace MyFirstDotNet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "This message from controller";
            return View();
        }
    }
}
