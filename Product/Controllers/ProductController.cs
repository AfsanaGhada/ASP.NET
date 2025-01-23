using Microsoft.AspNetCore.Mvc;

namespace Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Product()
        {
            return View();
        }
        public IActionResult ProductForm()
        {
            return View();
        }
    }
}
