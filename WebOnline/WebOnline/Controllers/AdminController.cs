using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOnline.Models;

namespace WebOnline.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.Get<NhanVien>("MaNv") == null)
            {
                return Redirect("/Admin/Login"); 
            }
            else
            {
                return View();
            }
        }
        private readonly MyPhamContext db;
        public AdminController(MyPhamContext context)
        {
            db = context;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AdminLogin model)
        {
            if (ModelState.IsValid)
            {
                NhanVien nv = db.NhanVien.SingleOrDefault(p => p.MaNv == model.MaNv && p.MatKhau == model.MatKhau);
                if (nv == null)
                {
                    ModelState.AddModelError("Loi", "Tài khoản hoặc mật khẩu không đúng");
                    return View();
                }
                //ghi session
                //HttpContext.Session.SetString("MaKH", kh.MaKh);
                HttpContext.Session.Set("MaNv", nv);
                //chuyển tới trang HangHoa (--> MyProfile)
                return RedirectToAction("Index", "Admin");
            }
            return View();
        }

        public IActionResult Logout()
        {
            //xóa session
            HttpContext.Session.Remove("MaNv");
            return RedirectToAction("Login", "Admin");
        }
    }
}