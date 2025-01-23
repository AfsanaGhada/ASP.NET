using Microsoft.AspNetCore.Mvc;

namespace LAB_6.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentList()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
