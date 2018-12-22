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
    public class BinhLuansController : Controller
    {
        private readonly MyDbContext _context;

        public BinhLuansController(MyDbContext context)
        {
            _context = context;
        }

        // GET: BinhLuans
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.BinhLuans.Include(b => b.HangHoa).Include(b => b.NguoiDung);
            return View(await myDbContext.ToListAsync());
        }

        // GET: BinhLuans/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuan = await _context.BinhLuans
                .Include(b => b.HangHoa)
                .Include(b => b.NguoiDung)
                .FirstOrDefaultAsync(m => m.BinhLuanID == id);
            if (binhLuan == null)
            {
                return NotFound();
            }

            return View(binhLuan);
        }

        // GET: BinhLuans/Create
        public IActionResult Create()
        {
            ViewData["HangHoaID"] = new SelectList(_context.HangHoas, "HanghoaID", "HanghoaID");
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID");
            return View();
        }

        // POST: BinhLuans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BinhLuanID,HangHoaID,NoiDung,NguoiDungID,NgayBl")] BinhLuan binhLuan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(binhLuan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["HangHoaID"] = new SelectList(_context.HangHoas, "HanghoaID", "HanghoaID", binhLuan.HangHoaID);
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID", binhLuan.NguoiDungID);
            return View(binhLuan);
        }

        // GET: BinhLuans/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuan = await _context.BinhLuans.FindAsync(id);
            if (binhLuan == null)
            {
                return NotFound();
            }
            ViewData["HangHoaID"] = new SelectList(_context.HangHoas, "HanghoaID", "HanghoaID", binhLuan.HangHoaID);
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID", binhLuan.NguoiDungID);
            return View(binhLuan);
        }

        // POST: BinhLuans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BinhLuanID,HangHoaID,NoiDung,NguoiDungID,NgayBl")] BinhLuan binhLuan)
        {
            if (id != binhLuan.BinhLuanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(binhLuan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BinhLuanExists(binhLuan.BinhLuanID))
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
            ViewData["HangHoaID"] = new SelectList(_context.HangHoas, "HanghoaID", "HanghoaID", binhLuan.HangHoaID);
            ViewData["NguoiDungID"] = new SelectList(_context.NguoiDungs, "NguoiDungID", "NguoiDungID", binhLuan.NguoiDungID);
            return View(binhLuan);
        }

        // GET: BinhLuans/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var binhLuan = await _context.BinhLuans
                .Include(b => b.HangHoa)
                .Include(b => b.NguoiDung)
                .FirstOrDefaultAsync(m => m.BinhLuanID == id);
            if (binhLuan == null)
            {
                return NotFound();
            }

            return View(binhLuan);
        }

        // POST: BinhLuans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var binhLuan = await _context.BinhLuans.FindAsync(id);
            _context.BinhLuans.Remove(binhLuan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BinhLuanExists(int id)
        {
            return _context.BinhLuans.Any(e => e.BinhLuanID == id);
        }
    }
}
