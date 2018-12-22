using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NETCKTEAM30.Models;

namespace NETCKTEAM30.Controllers
{
    public class HoaDonsController : Controller
    {
        private readonly MyDbContext _context;

        public HoaDonsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: HoaDons
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.hoaDons.Include(h => h.NguoiDung).Include(h => h.ThanhToan).Include(h => h.TrangThai).Include(h => h.VanChuyen);
            return View(await myDbContext.ToListAsync());
        }

        // GET: HoaDons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.hoaDons
                .Include(h => h.NguoiDung)
                .Include(h => h.ThanhToan)
                .Include(h => h.TrangThai)
                .Include(h => h.VanChuyen)
                .FirstOrDefaultAsync(m => m.HoaDonID == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // GET: HoaDons/Create
        public IActionResult Create()
        {
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID");
            ViewData["ThanhToanID"] = new SelectList(_context.ThanhToans, "ThanhToanID", "ThanhToanID");
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "TrangThaiID");
            ViewData["VanChuyenID"] = new SelectList(_context.VanChuyens, "VanChuyenID", "VanChuyenID");
            return View();
        }

        // POST: HoaDons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HoaDonID,NguoiDungID,NgayDat,NgayNhan,HoTen,DiaChi,ThanhToanID,VanChuyenID,PhiVanChuyen,TrangThaiID,GhiChu")] HoaDon hoaDon)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hoaDon);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID", hoaDon.NguoiDungID);
            ViewData["ThanhToanID"] = new SelectList(_context.ThanhToans, "ThanhToanID", "ThanhToanID", hoaDon.ThanhToanID);
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "TrangThaiID", hoaDon.TrangThaiID);
            ViewData["VanChuyenID"] = new SelectList(_context.VanChuyens, "VanChuyenID", "VanChuyenID", hoaDon.VanChuyenID);
            return View(hoaDon);
        }

        // GET: HoaDons/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.hoaDons.FindAsync(id);
            if (hoaDon == null)
            {
                return NotFound();
            }
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID", hoaDon.NguoiDungID);
            ViewData["ThanhToanID"] = new SelectList(_context.ThanhToans, "ThanhToanID", "ThanhToanID", hoaDon.ThanhToanID);
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "TrangThaiID", hoaDon.TrangThaiID);
            ViewData["VanChuyenID"] = new SelectList(_context.VanChuyens, "VanChuyenID", "VanChuyenID", hoaDon.VanChuyenID);
            return View(hoaDon);
        }

        // POST: HoaDons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HoaDonID,NguoiDungID,NgayDat,NgayNhan,HoTen,DiaChi,ThanhToanID,VanChuyenID,PhiVanChuyen,TrangThaiID,GhiChu")] HoaDon hoaDon)
        {
            if (id != hoaDon.HoaDonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hoaDon);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HoaDonExists(hoaDon.HoaDonID))
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
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID", hoaDon.NguoiDungID);
            ViewData["ThanhToanID"] = new SelectList(_context.ThanhToans, "ThanhToanID", "ThanhToanID", hoaDon.ThanhToanID);
            ViewData["TrangThaiID"] = new SelectList(_context.TrangThais, "TrangThaiID", "TrangThaiID", hoaDon.TrangThaiID);
            ViewData["VanChuyenID"] = new SelectList(_context.VanChuyens, "VanChuyenID", "VanChuyenID", hoaDon.VanChuyenID);
            return View(hoaDon);
        }

        // GET: HoaDons/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoaDon = await _context.hoaDons
                .Include(h => h.NguoiDung)
                .Include(h => h.ThanhToan)
                .Include(h => h.TrangThai)
                .Include(h => h.VanChuyen)
                .FirstOrDefaultAsync(m => m.HoaDonID == id);
            if (hoaDon == null)
            {
                return NotFound();
            }

            return View(hoaDon);
        }

        // POST: HoaDons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hoaDon = await _context.hoaDons.FindAsync(id);
            _context.hoaDons.Remove(hoaDon);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HoaDonExists(int id)
        {
            return _context.hoaDons.Any(e => e.HoaDonID == id);
        }
        public IActionResult chitietdonhang(int? id)
        {
            HoaDonViewModel model = new HoaDonViewModel();
            List<ChiTietHd> ct = new List<ChiTietHd>();
            if (id.HasValue)
            {
                
                HoaDon hd = _context.hoaDons.Include(x=>x.NguoiDung).Include(x=>x.ThanhToan).Include(x=>x.VanChuyen).Include(x=>x.TrangThai).Where(p => p.HoaDonID == id).First();
                ct = _context.chiTietHds.Include(x=>x.HangHoa).Where(p => p.HoaDonID == hd.HoaDonID).ToList();
                model.hoadon = hd;
                model.chitiet = ct;
            }
            double tongtien = 0;
            foreach (var item in ct)
            {
                tongtien += item.ThanhTien;
            }
            ViewBag.TongTien = tongtien;
            return View(model);
        }
        public IActionResult Search(int keyword )
        {
            if (keyword !=null)
            {

                var data = _context.hoaDons.Include(h => h.NguoiDung).Include(h => h.ThanhToan).Include(h => h.TrangThai).Include(h => h.VanChuyen).Where(p => p.HoaDonID==keyword)
                    .ToList();

                return PartialView(data);
            }
            else
            {
                return PartialView();
            }
        }
        public IActionResult giamtrth(int id)
        {
            HoaDon hd = _context.hoaDons.Where(p => p.HoaDonID == id).First();
            --hd.TrangThaiID;
            _context.hoaDons.Update(hd);
            _context.SaveChanges();
            return RedirectToAction("index", "HoaDons");
        }
        public IActionResult tangtrth(int id)
        {
            HoaDon hd = _context.hoaDons.Where(p => p.HoaDonID == id).First();
            ++hd.TrangThaiID;
            _context.hoaDons.Update(hd);
            _context.SaveChanges();
            return RedirectToAction("index", "HoaDons");
        }
    }
}
