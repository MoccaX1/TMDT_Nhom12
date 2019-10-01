using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
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

        [Route("hoi-dap")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("lien-he")]
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

        [Route("[controller]/[action]")]
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

        [Route("[controller]/[action]")]
        public IActionResult Excel()
        {

            var comlumHeadrs = new string[]
            {
                "Email"
            };

            byte[] result;

            using (var package = new ExcelPackage())
            {
                // add a new worksheet to the empty workbook

                var worksheet = package.Workbook.Worksheets.Add("Email khách hàng"); //Worksheet name
                using (var cells = worksheet.Cells[1, 1, 1, 5]) //(1,1) (1,5)
                {
                    cells.Style.Font.Bold = true;
                }

                //First add the headers
                for (var i = 0; i < comlumHeadrs.Count(); i++)
                {
                    worksheet.Cells[1, i + 1].Value = comlumHeadrs[i];
                }

                //Add values
                var j = 2;
                foreach (var email in db.KhachHang)
                {
                    worksheet.Cells["A" + j].Value = email.Email;
                    j++;
                }
                result = package.GetAsByteArray();
            }

            return File(result, "application/ms-excel", $"Email-List.xlsx");
        }

    }
}
