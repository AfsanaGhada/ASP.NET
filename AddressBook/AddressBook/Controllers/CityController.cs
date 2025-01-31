using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class CityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CityForm()
        {
            return View();
        }

        public IActionResult CityList()
        {
            return View();
        }
    }
}
