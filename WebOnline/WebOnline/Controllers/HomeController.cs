using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOnline.Models;

namespace WebOnline.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyPhamContext db;
        public HomeController(MyPhamContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult LienHe(string ten, string tieude, string sdt, string email, string noidung)
        {
            LienHe lh = new LienHe
            {

                HoTen = ten,
                TieuDe = tieude,
                DienThoai = sdt,
                Email = email,
                NoiDung = noidung,
                NgayGy = DateTime.Now,
                
            };
            db.LienHe.Add(lh);
            db.SaveChanges();
            return RedirectToAction("Contact");
        }
            
        
    }
}
