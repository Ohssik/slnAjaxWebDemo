using AjaxWebDemo.Models;
using AjaxWebDemo.Models1;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;
using CoreAPI.Models;

namespace AjaxWebDemo.Controllers
{
    public class ApiController : Controller
    {
        private readonly DemoContext _db;
        private readonly IWebHostEnvironment _host;
        public ApiController(DemoContext db, IWebHostEnvironment host)
        {
            _db = db;
            _host = host;
        }
        public IActionResult Index(string name,int age=20)
        {
            //System.Threading.Thread.Sleep(7000);
            if (string.IsNullOrEmpty(name))
                name = "Ajax";
            return Content($"Hello,{name}, you are {age}","text/plain",Encoding.UTF8);
        }
        public IActionResult NameCheck(string name)
        {
            string result = "0";
            if (!string.IsNullOrEmpty(name))
            {
                //Member m = _db.Members.FirstOrDefault(c => c.Name == name);
                bool isExisted = _db.Members.Any(c => c.Name == name);
                if (/*m != null*/isExisted)
                {
                    result = "1";                    
                }
            }
            return Content(result, "application/x-www-form-urlencoded", Encoding.UTF8);
        }

        public IActionResult checkFormData(Member member,IFormFile file)
        {
            string filePath=Path.Combine(_host.WebRootPath,"img", file.FileName);
            using (var fileStream=new FileStream(filePath,FileMode.Create))
            {
                file.CopyTo(fileStream);
            }
            //return Content($"Hello,{member.Name}.You are {member.Age} and email is {member.Email}", "text/plain", Encoding.UTF8);
            

            byte[]? imgByte = null;
            using (var memoryStream=new MemoryStream())
            {
                imgByte = memoryStream.ToArray();
                member.FileData = imgByte;
            }

            member.FileName = file.FileName;

            _db.Members.Add(member);
            _db.SaveChanges();

            return Content($"{filePath}");
        }

        public IActionResult Test()
        {
            iSpan_ProjectContext db = new iSpan_ProjectContext();
            Models1.NormalMember m = new Models1.NormalMember();
            m.MemberName = DateTime.Now.ToString("yyyyMMddHHmmss");
            db.NormalMembers.Add(m);
            db.SaveChanges();

            return Content("test success");
        }

        public IActionResult city()
        {
            //var cities = _db.Addresses.Select(a => new { a.City }).Distinct().OrderBy(a => a.City);
            var cities = _db.Addresses.Select(a => a.City).Distinct();
            return Json(cities);
        }
        public IActionResult site(string city)
        {
            var sites = _db.Addresses.Where(s => s.City == city).Select(s => s.SiteId).Distinct();
            return Json(sites);
        }
        public IActionResult road(string site)
        {
            var roads = _db.Addresses.Where(r => r.SiteId == site).Select(s => s.Road).Distinct();
            return Json(roads);
        }
    }
}
