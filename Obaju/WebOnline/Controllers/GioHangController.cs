﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebOnline.Models;
using Microsoft.AspNetCore.Http;

namespace WebOnline.Controllers
{
    public class GioHangController : Controller
    {
        private readonly MyPhamContext db;
        public GioHangController(MyPhamContext context)
        {
            db = context;
        }

        [Route("gio-hang")]
        public IActionResult Index()
        {
            return View(Carts);
        }

        public List<CartItem> Carts
        {
            get
            {
                List<CartItem> myCart = HttpContext.Session.Get<List<CartItem>>("GioHang");
                if (myCart == default(List<CartItem>))
                {
                    myCart = new List<CartItem>();
                }

                return myCart;
            }
        }

        [Route("[controller]/[action]")]
        public IActionResult AddToCart(int mahh, int sl)
        {
            List<CartItem> gioHang = Carts;
            //tìm xem có chưa
            CartItem item = gioHang.SingleOrDefault(p => p.MaHh == mahh);
            if (item != null) //có rồi
            {
                item.SoLuong++;
            }
            else
            {
                SanPham hh = db.SanPham.SingleOrDefault(p => p.MaSp == mahh);
                item = new CartItem
                {
                    MaHh = hh.MaSp,
                    TenHh = hh.TenSp,
                    Hinh = hh.Hinh,
                    SoLuong = sl,
                    GiaBan = hh.DonGia.Value,
                };
                gioHang.Add(item);
            }
            //lưu session
            HttpContext.Session.Set("GioHang", gioHang);
            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]")]
        public IActionResult Update(int masua, int sl)
        {
            List<CartItem> giohang = Carts;
            CartItem hh = giohang.SingleOrDefault(p => p.MaHh == masua);
            hh.SoLuong = sl;
            HttpContext.Session.Set("GioHang", giohang);
            return RedirectToAction("Index");
        }

        /* Sai gì v nèeeeeee
        public IActionResult Update(int mahh, int soluong)
        {
            // tìm carditem muon sua
            List<CartItem> giohang = Carts;
            CartItem itemSua = giohang.FirstOrDefault(p => p.MaHh == mahh);
            if (itemSua != null)
            {
                itemSua.SoLuong = soluong;
            }
            return RedirectToAction("Index");

        }
        */

        [Route("[controller]/[action]")]
        public IActionResult Remove(int maxoa)
        {
            List<CartItem> giohang = Carts;
            CartItem hh = giohang.SingleOrDefault(p => p.MaHh == maxoa);
            giohang.Remove(hh);
            HttpContext.Session.Set("GioHang", giohang);
            return RedirectToAction("Index");
        }

        [Route("[controller]/[action]")]
        public IActionResult Delete()
        {
            List<CartItem> giohang = Carts;
            HttpContext.Session.Remove("GioHang");
            return RedirectToAction("Index");
        }

    }
}