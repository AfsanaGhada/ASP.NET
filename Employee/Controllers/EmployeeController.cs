using Microsoft.AspNetCore.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employees()
        {
            return View("Employee_List");
        }
        public IActionResult Employee_Form()
        {
            return View("Employee_Form");
        }

    }
}
