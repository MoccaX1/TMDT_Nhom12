using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebOnline.Models;

namespace WebOnline.Controllers
{
    public class YeuThichController : Controller
    {
        private readonly MyPhamContext _context;

        public YeuThichController(MyPhamContext context)
        {
            _context = context;
        }

        // GET: YeuThich
        public async Task<IActionResult> Index()
        {
            var myPhamContext = _context.YeuThich.Include(y => y.MaKhNavigation).Include(y => y.MaSpNavigation);
            return View(await myPhamContext.ToListAsync());
        }

        // GET: YeuThich/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yeuThich = await _context.YeuThich
                .Include(y => y.MaKhNavigation)
                .Include(y => y.MaSpNavigation)
                .FirstOrDefaultAsync(m => m.MaYt == id);
            if (yeuThich == null)
            {
                return NotFound();
            }

            return View(yeuThich);
        }

        // GET: YeuThich/Create
        public IActionResult Create()
        {
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "MaKh");
            ViewData["MaSp"] = new SelectList(_context.SanPham, "MaSp", "MaSp");
            return View();
        }

        // POST: YeuThich/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MaYt,MaSp,MaKh,NgayChon,MoTa")] YeuThich yeuThich)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yeuThich);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "MaKh", yeuThich.MaKh);
            ViewData["MaSp"] = new SelectList(_context.SanPham, "MaSp", "MaSp", yeuThich.MaSp);
            return View(yeuThich);
        }

        // GET: YeuThich/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yeuThich = await _context.YeuThich.FindAsync(id);
            if (yeuThich == null)
            {
                return NotFound();
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "MaKh", yeuThich.MaKh);
            ViewData["MaSp"] = new SelectList(_context.SanPham, "MaSp", "MaSp", yeuThich.MaSp);
            return View(yeuThich);
        }

        // POST: YeuThich/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MaYt,MaSp,MaKh,NgayChon,MoTa")] YeuThich yeuThich)
        {
            if (id != yeuThich.MaYt)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(yeuThich);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!YeuThichExists(yeuThich.MaYt))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaKh"] = new SelectList(_context.KhachHang, "MaKh", "MaKh", yeuThich.MaKh);
            ViewData["MaSp"] = new SelectList(_context.SanPham, "MaSp", "MaSp", yeuThich.MaSp);
            return View(yeuThich);
        }

        // GET: YeuThich/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var yeuThich = await _context.YeuThich
                .Include(y => y.MaKhNavigation)
                .Include(y => y.MaSpNavigation)
                .FirstOrDefaultAsync(m => m.MaYt == id);
            if (yeuThich == null)
            {
                return NotFound();
            }

            return View(yeuThich);
        }

        // POST: YeuThich/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var yeuThich = await _context.YeuThich.FindAsync(id);
            _context.YeuThich.Remove(yeuThich);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool YeuThichExists(int id)
        {
            return _context.YeuThich.Any(e => e.MaYt == id);
        }
        public IActionResult themYT(int masp, string makh)
        {
            ViewBag.chon = "1";
            YeuThich yt = new YeuThich
            {
                MaKh = makh,
                MaSp = masp,
                NgayChon = DateTime.Now,
                
        };
            
            _context.YeuThich.Add(yt);
            _context.SaveChanges();
            return RedirectToAction("ChiTiet", "SanPham", new { @id = masp });
        }

        public IActionResult boYT(int masp)
        {
            YeuThich yt = _context.YeuThich.SingleOrDefault(p => p.MaSp == masp);
            
            _context.YeuThich.Remove(yt);
            _context.SaveChanges();
            return RedirectToAction("ChiTiet", "SanPham", new { @id = masp });
        }
    }
}
