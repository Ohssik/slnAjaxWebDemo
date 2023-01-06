using AjaxWebDemo.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace AjaxWebDemo.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _db;
        public ApiController(DemoContext db)
        {
            _db = db;
        }
        public IActionResult Index(string name)
        {
            //System.Threading.Thread.Sleep(7000);
            if (string.IsNullOrEmpty(name))
                name = "Ajax";
            return Content($"Hello,{name}","text/plain",Encoding.UTF8);
        }
        public IActionResult NameCheck(string name)
        {
            string result = "0";
            if (!string.IsNullOrEmpty(name))
            {
                Member m = _db.Members.FirstOrDefault(c => c.Name == name);
                if (m != null)
                {
                    result = "1";                    
                }
            }
            return Content(result, "application/x-www-form-urlencoded", Encoding.UTF8);
        }
    }
}
