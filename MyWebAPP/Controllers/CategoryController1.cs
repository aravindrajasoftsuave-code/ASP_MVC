using Microsoft.AspNetCore.Mvc;

namespace MyWebAPP.Controllers
{
    public class CategoryController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
