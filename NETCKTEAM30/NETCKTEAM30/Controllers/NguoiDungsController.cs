using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCKTEAM30.Models;

namespace NETCKTEAM30.Controllers
{
    public class NguoiDungsController : Controller
    {
        private readonly MyDbContext _context;

        public NguoiDungsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NguoiDungs
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NguoiDungs.Include(n => n.GioiTinh).Include(n => n.LoaiNgDung);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NguoiDungs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs
                .Include(n => n.GioiTinh)
                .Include(n => n.LoaiNgDung)
                .FirstOrDefaultAsync(m => m.NguoiDungID == id);
            if (nguoiDung == null)
            {
                return NotFound();
            }
            string[] arrListStr = nguoiDung.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Create
        public IActionResult Create()
        {
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT");
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai");
            return View();
        }

        // POST: NguoiDungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,LoaiNgDungID,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (ModelState.IsValid)
            {
                string arr = "";

                if (myfile != null)
                {
                    foreach (var item in myfile)
                    {
                        string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                        using (var f = new FileStream(url, FileMode.Create))
                        {
                            item.CopyTo(f);
                        }
                        arr += item.FileName;
                    }
                    nguoiDung.Hinh = arr;
                }
                _context.Add(nguoiDung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "GioiTinhID", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "LoaiNgDungID", nguoiDung.LoaiNgDungID);
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            if (nguoiDung == null)
            {
                return NotFound();
            }
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai", nguoiDung.LoaiNgDungID);
            string[] arrListStr = nguoiDung.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(nguoiDung);
        }

        // POST: NguoiDungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,LoaiNgDungID,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (id != nguoiDung.NguoiDungID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string arr = "";

                    if (myfile != null)
                    {
                        foreach (var item in myfile)
                        {
                            string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                            using (var f = new FileStream(url, FileMode.Create))
                            {
                                item.CopyTo(f);
                            }
                            arr += item.FileName;
                        }
                        nguoiDung.Hinh = arr;
                    }
                    _context.Update(nguoiDung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiDungExists(nguoiDung.NguoiDungID))
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
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "GioiTinhID", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "LoaiNgDungID", nguoiDung.LoaiNgDungID);
            return View(nguoiDung);
        }

        // GET: NguoiDungs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nguoiDung = await _context.NguoiDungs
                .Include(n => n.GioiTinh)
                .Include(n => n.LoaiNgDung)
                .FirstOrDefaultAsync(m => m.NguoiDungID == id);
            if (nguoiDung == null)
            {
                return NotFound();
            }

            return View(nguoiDung);
        }

        // POST: NguoiDungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nguoiDung = await _context.NguoiDungs.FindAsync(id);
            _context.NguoiDungs.Remove(nguoiDung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NguoiDungExists(int id)
        {
            return _context.NguoiDungs.Any(e => e.NguoiDungID == id);
        }
        public IActionResult dangnhap()
        {
            return View();
        }
        [HttpPost]
        public IActionResult dangnhap(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                NguoiDung kh = _context.NguoiDungs.SingleOrDefault(p => p.TenDangNhap == model.MaKH && p.MatKhau == model.MatKhau);
                if (kh == null)
                {
                    ModelState.AddModelError("Loi", "Không có khách hàng này.");
                    return View();
                }

                HttpContext.Session.Set("MaKH", kh);
                HttpContext.Session.Set<int>("a", 1);
                return RedirectToAction("index", "Home");
            }
            else
            {
                return RedirectToAction("index", "Home");
            }

        }
        public IActionResult dangky()
        {
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT");
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai");
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> dangky([Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (ModelState.IsValid)
            {
                string arr = "";

                if (myfile != null)
                {
                    foreach (var item in myfile)
                    {
                        string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                        using (var f = new FileStream(url, FileMode.Create))
                        {
                            item.CopyTo(f);
                        }
                        arr += item.FileName;
                    }
                    nguoiDung.Hinh = arr;
                    nguoiDung.LoaiNgDungID = 3;
                }
                _context.Add(nguoiDung);
                HttpContext.Session.Set<int>("a", 2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index), "Home");
            }
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "GioiTinhID", nguoiDung.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "LoaiNgDungID", nguoiDung.LoaiNgDungID);
            return View(nguoiDung);
        }
        [HttpGet]
        public IActionResult suathongtinkh(int id)
        {
            NguoiDung ngd = _context.NguoiDungs.Where(p => p.NguoiDungID == id).First();
            ViewData["GioiTinhID"] = new SelectList(_context.GioiTinhs, "GioiTinhID", "TenGT", ngd.GioiTinhID);
            ViewData["LoaiNgDungID"] = new SelectList(_context.LoaiNgDungs, "LoaiNgDungID", "TenLoai", ngd.LoaiNgDungID);

            return View(ngd);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> suathongtinkh(int id, int lngd, [Bind("NguoiDungID,HoTen,GioiTinhID,NgaySinh,DiaChi,SDT,Email,Hinh,TenDangNhap,MatKhau")] NguoiDung nguoiDung, IFormFile[] myfile)
        {
            if (id != nguoiDung.NguoiDungID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string arr = "";

                    if (myfile != null)
                    {
                        foreach (var item in myfile)
                        {
                            string url = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", item.FileName);
                            using (var f = new FileStream(url, FileMode.Create))
                            {
                                item.CopyTo(f);
                            }
                            arr += item.FileName;
                        }
                        nguoiDung.Hinh = arr;
                    }
                    nguoiDung.LoaiNgDungID = lngd;
                    _context.Update(nguoiDung);
                    await _context.SaveChangesAsync();
                    HttpContext.Session.Set("MaKH", nguoiDung);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NguoiDungExists(nguoiDung.NguoiDungID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("index", "Home");
            }

            return RedirectToAction("index", "Home");
        }
        public IActionResult dangxuat()
        {
            HttpContext.Session.Set<int>("a", 0);
            return RedirectToAction("index", "Home");
        }
        [HttpPost]
        public IActionResult binhluan(int idhh, string bluan)
        {
            if (HttpContext.Session.Get<NguoiDung>("MaKH") == null)
            {
                HttpContext.Session.Set<int>("a", 4);
                return RedirectToAction("index", "Home");
            }
            NguoiDung ngd = HttpContext.Session.Get<NguoiDung>("MaKH");
            DateTime d = DateTime.Now;
            BinhLuan bl = new BinhLuan();
            bl.NguoiDungID = ngd.NguoiDungID;
            bl.HangHoaID = idhh;
            HttpContext.Session.Set<int>("idhh", idhh);
            bl.NoiDung = bluan;
            bl.NgayBl = d;
            _context.BinhLuans.Add(bl);
            _context.SaveChanges();


            return RedirectToAction("chitiet", "HangHoas");
        }
        public IActionResult customer()
        {
            List<NguoiDung> Dsnd = new List<NguoiDung>();
            Dsnd = _context.NguoiDungs.Where(h => h.LoaiNgDungID == 3).ToList();
            return View(Dsnd.Select(h => new NguoiDung
            {
                HoTen = h.HoTen,
                NguoiDungID = h.NguoiDungID,
                GioiTinh = h.GioiTinh,
                NgaySinh = h.NgaySinh,
                DiaChi = h.DiaChi,
                SDT = h.SDT,
                Email = h.Email,
                Hinh = h.Hinh,
                LoaiNgDung = h.LoaiNgDung,
                TenDangNhap = h.TenDangNhap,
                MatKhau = h.MatKhau
            }));
        }
        public IActionResult admin()
        {
            List<NguoiDung> Dsnd = new List<NguoiDung>();
            Dsnd = _context.NguoiDungs.Where(h => h.LoaiNgDungID == 1).ToList();
            return View(Dsnd.Select(h => new NguoiDung
            {
                HoTen = h.HoTen,
                NguoiDungID = h.NguoiDungID,
                GioiTinh = h.GioiTinh,
                NgaySinh = h.NgaySinh,
                DiaChi = h.DiaChi,
                SDT = h.SDT,
                Email = h.Email,
                Hinh = h.Hinh,
                LoaiNgDung = h.LoaiNgDung,
                TenDangNhap = h.TenDangNhap,
                MatKhau = h.MatKhau
            }));
        }
      
        public IActionResult SearchAdmin(string keyword = "")
        {
            if (keyword != null)
            {
                keyword = keyword.ToLower();
                var data = _context.NguoiDungs.Include(n => n.GioiTinh).Include(n => n.LoaiNgDung).Where(p => p.HoTen.ToLower().Contains(keyword))
                    .ToList();

                return PartialView(data);
            }
            else
            {
                return PartialView();
            }
        }
        public IActionResult SearchUser(string keyword = "")
        {
            if (keyword != null)
            {
                keyword = keyword.ToLower();
                var data = _context.NguoiDungs.Include(n => n.GioiTinh).Include(n => n.LoaiNgDung).Where(p => p.HoTen.ToLower().Contains(keyword))
                    .ToList();

                return PartialView(data);
            }
            else
            {
                return PartialView();
            }
        }
    }
}
