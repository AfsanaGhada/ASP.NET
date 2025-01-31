using Microsoft.AspNetCore.Mvc;

namespace AreaDemo.Areas.User.Controllers
{
    [Area("User")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
