using Microsoft.AspNetCore.Mvc;

namespace DemoUI.Controllers
{
    public class IncorrectDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult VisualCategoryChecker()
        {
            return View();
        }

        public IActionResult MissingProduct()
        {
            return View();
        }
    }
}
