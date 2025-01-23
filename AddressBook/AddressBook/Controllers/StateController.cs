using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class StateController : Controller
    {
        public IActionResult StateForm()
        {
            return View();
        }
        public IActionResult StateList()
        {
            return View();
        }
    }
}
