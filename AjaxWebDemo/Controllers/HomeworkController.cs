using Microsoft.AspNetCore.Mvc;
using AjaxWebDemo.Models;

namespace AjaxWebDemo.Controllers
{    
    public class HomeworkController : Controller
    {
        private readonly DemoContext _db;
        public HomeworkController(DemoContext db)
        {
            _db = db;
        }
        public IActionResult Index(DemoContext db)
        {    
            return View();
        }
        public IActionResult Travel()
        {
            return View();
        }
        public IActionResult Register()
        {
            Member lastMember = _db.Members.OrderBy(c=>c.MemberId).Last();
            int newId = lastMember.MemberId+1;
            ViewData["newId"]=newId;
            return View();
        }
        public IActionResult Address()
        {
            return View();
        }
    }
}
