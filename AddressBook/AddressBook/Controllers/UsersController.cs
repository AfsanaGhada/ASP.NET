using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UsersForm()
        {
            return View();
        }
        public IActionResult UsersList()
        {
            return View();
        }
    }
}
