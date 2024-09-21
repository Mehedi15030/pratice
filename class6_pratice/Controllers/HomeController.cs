using class6_pratice.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace class6_pratice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult employeeinfo()
        {
            return View();
        }
        [HttpPost]
         public IActionResult employeeinfo(Employe emp)
        {
            if(ModelState.IsValid)
            {
                return Content("Model is Valid");
            }
            else
            {
                ViewBag.msg="Model ia not valid";
                return View(emp);
            }
            //return View();
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
