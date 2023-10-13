using Microsoft.AspNetCore.Mvc;

namespace FrituurApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
