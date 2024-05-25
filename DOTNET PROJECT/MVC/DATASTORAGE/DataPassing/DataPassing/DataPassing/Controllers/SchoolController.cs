using Microsoft.AspNetCore.Mvc;

namespace DataPassing.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            ViewData["data1"] = "ViewData";
            ViewBag.data2 = "ViewBag";
            TempData["data3"] = "TempData";
            TempData.Keep("data3");
          
             return View();
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
