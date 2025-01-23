using System.Diagnostics;
using LAB_6.Models;
using Microsoft.AspNetCore.Mvc;

namespace LAB_6.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }


    }
}
