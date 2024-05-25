using Microsoft.AspNetCore.Mvc;

namespace SharedDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
