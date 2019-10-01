using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOnline.Models;

namespace WebOnline.Controllers
{
    public class KhachHangController : Controller
    {
        private readonly MyPhamContext db;

        public KhachHangController(MyPhamContext context)
        {
            db = context;
        }

        [Route("khach-hang")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DoiMK(LoginViewModel model, string nhapmk, string nhaplaimk)
        {
            if (ModelState.IsValid)
            {
                KhachHang kh = db.KhachHang.SingleOrDefault(p => p.MaKh == model.MaKh);
                if (nhapmk != nhaplaimk)
                {
                    ModelState.AddModelError("Loi", "Mật khẩu xác nhận không khớp.");
                    return View("Index");
                }
                else
                {
                    kh.MatKhau = nhaplaimk;
                    db.Update(kh);
                    db.SaveChanges();
                    HttpContext.Session.Remove("TaiKhoan");
                    return RedirectToAction("Index", "DangNhap");
                }
                
            }
            return View("Index");
        }

        public IActionResult DoiTT(string makh, string hoten, string gioi, string diachi, string sdt, string email )
        {
            if (ModelState.IsValid)
            {
                KhachHang kh = db.KhachHang.SingleOrDefault(p => p.MaKh == makh);

                kh.HoTen = hoten;
                kh.GioiTinh = Convert.ToBoolean(gioi);
                kh.DiaChi = diachi;
                kh.DienThoai = sdt;
                kh.Email = email;
                db.Update(kh);
                db.SaveChanges();
                HttpContext.Session.Set("TaiKhoan",kh);

            }        
            return View("Index");
        }

    }
}