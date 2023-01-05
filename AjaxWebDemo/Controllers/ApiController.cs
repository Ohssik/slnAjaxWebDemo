using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace AjaxWebDemo.Controllers
{
    public class ApiController : Controller
    {
        public IActionResult Index(string name)
        {
            if (string.IsNullOrEmpty(name))
                name = "Ajax";
            return Content($"Hello,{name}","text/plain",Encoding.UTF8);
        }
    }
}
