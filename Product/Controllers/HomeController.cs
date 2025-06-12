using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Product.Models;

namespace Product.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult User_Form()
        {
            return View();
        }

        public IActionResult User_List()
        {
            return View();
        }
        public IActionResult Save(IFormCollection fc)
        {
            ViewBag.name = fc["name"];
            ViewBag.email = fc["email"];
            ViewBag.phone = fc["phone"];
            ViewBag.address = fc["address"];

            return View("User_List");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
