using Microsoft.AspNetCore.Mvc;
using RepositoryDemo.Models;
using RepositoryDemo.Repository;
using System.Diagnostics;

namespace RepositoryDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository studentRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            studentRepository = new StudentRepository();
        }
        public IActionResult Students()
        {

            List<Student> students = studentRepository.Students();

            return View(students);
        }
        public IActionResult GetStudent(int id)
        {
            Student student = studentRepository.GetStudent(id);
            return View(student);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
