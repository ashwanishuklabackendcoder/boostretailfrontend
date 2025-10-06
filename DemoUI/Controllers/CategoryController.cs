using Microsoft.AspNetCore.Mvc;

namespace DemoUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult MainTainCategory()
        {
            return View();
        }


        public IActionResult MainLookupTabels()
        {
            return View();
        }
    }
}
