using Microsoft.AspNetCore.Mvc;

namespace MVCProjectDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
