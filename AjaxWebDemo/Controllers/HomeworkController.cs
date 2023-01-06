using Microsoft.AspNetCore.Mvc;

namespace AjaxWebDemo.Controllers
{
    public class HomeworkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Travel()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
