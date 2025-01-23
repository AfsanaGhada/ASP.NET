using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult countryForm()
        {
            return View("CountryForm");
        }

        public IActionResult CountryList()
        {
            return View();
        }
    }
}