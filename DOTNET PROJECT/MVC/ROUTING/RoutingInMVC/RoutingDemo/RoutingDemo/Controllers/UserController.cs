using Microsoft.AspNetCore.Mvc;

namespace RoutingDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
