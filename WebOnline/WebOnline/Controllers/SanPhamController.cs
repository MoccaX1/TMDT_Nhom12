using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReflectionIT.Mvc.Paging;
using WebOnline.Models;

namespace WebOnline.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly MyPhamContext db;
        public SanPhamController(MyPhamContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index(int? id, int page = 1)
        {
            
            var qry = db.SanPham.AsNoTracking().OrderBy(p => p.MaSp);
            var model = await PagingList.CreateAsync(qry, 9, page);
            if (id.HasValue)
            {

                var qery = db.SanPham.Where(p => p.MaLoai == id).AsNoTracking().OrderBy(p=>p.MaSp);

                var md = await PagingList.CreateAsync(qery, 9, page);
                return View(md);
            }

            return View(model);
        }

        public async Task<IActionResult> Hieu(int? id, int page = 1)
        {

            var qry = db.SanPham.AsNoTracking().OrderBy(p => p.MaSp);
            var model = await PagingList.CreateAsync(qry, 9, page);
            if (id.HasValue)
            {

                var qery = db.SanPham.Where(p => p.MaHieu == id).AsNoTracking().OrderBy(p => p.MaSp);

                var md = await PagingList.CreateAsync(qery, 9, page);
                return View(md);
            }

            return View(model);
        }

       [Route("[controller]/{url}")]
        public IActionResult ChiTiet(string url)
        {
            SanPham hh = db.SanPham.SingleOrDefault(p => p.TenSpSeoUrl == url);
            if (hh == null)
            {
                return RedirectToAction("Index", "SanPham");
            }
            return View(hh);
        }

        public IActionResult BinhLuan(string makh, int masp, string hoten, string email, string noidung)
        {
            BinhLuan bl = new BinhLuan
            {
                MaSp = masp,
                MaKh = makh,
                NgayBl = DateTime.Now,
                HoTen = hoten,
                Email = email,
                NoiDung = noidung,
            };
            db.BinhLuan.Add(bl);
            db.SaveChanges();
            return RedirectToAction("ChiTiet", "SanPham", new { @id = masp });
        }
        public IActionResult timKiem()
        {
            return View();
        }
        public IActionResult timSp()
        {
            string key = Request.Form["keysearch"].ToString();
            var sanPham = (from sp in db.SanPham
                           where sp.TenSp.Contains(key) && key != ""
                           select new SanPham
                           {
                               MaSp = sp.MaSp,
                               TenSp = sp.TenSp,
                               TenAlias = sp.TenAlias,
                               MaLoai = sp.MaLoai,
                               MoTa = sp.MoTa,
                               DonGia = sp.DonGia,
                               Hinh = sp.Hinh,
                               GiaCu = sp.GiaCu,
                               MaNcc = sp.MaNcc,
                               MaHieu = sp.MaHieu
                           }).ToList();
            return View(sanPham);
        }
    }
}