using Microsoft.AspNetCore.Mvc;

namespace RazorSyntaxDemo.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
