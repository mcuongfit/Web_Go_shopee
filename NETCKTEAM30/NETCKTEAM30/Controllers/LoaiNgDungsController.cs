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
    public class LoaiNgDungsController : Controller
    {
        private readonly MyDbContext _context;

        public LoaiNgDungsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: LoaiNgDungs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoaiNgDungs.ToListAsync());
        }

        // GET: LoaiNgDungs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiNgDung = await _context.LoaiNgDungs
                .FirstOrDefaultAsync(m => m.LoaiNgDungID == id);
            if (loaiNgDung == null)
            {
                return NotFound();
            }

            return View(loaiNgDung);
        }

        // GET: LoaiNgDungs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoaiNgDungs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LoaiNgDungID,TenLoai")] LoaiNgDung loaiNgDung)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loaiNgDung);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loaiNgDung);
        }

        // GET: LoaiNgDungs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiNgDung = await _context.LoaiNgDungs.FindAsync(id);
            if (loaiNgDung == null)
            {
                return NotFound();
            }
            return View(loaiNgDung);
        }

        // POST: LoaiNgDungs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LoaiNgDungID,TenLoai")] LoaiNgDung loaiNgDung)
        {
            if (id != loaiNgDung.LoaiNgDungID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loaiNgDung);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoaiNgDungExists(loaiNgDung.LoaiNgDungID))
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
            return View(loaiNgDung);
        }

        // GET: LoaiNgDungs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loaiNgDung = await _context.LoaiNgDungs
                .FirstOrDefaultAsync(m => m.LoaiNgDungID == id);
            if (loaiNgDung == null)
            {
                return NotFound();
            }

            return View(loaiNgDung);
        }

        // POST: LoaiNgDungs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loaiNgDung = await _context.LoaiNgDungs.FindAsync(id);
            _context.LoaiNgDungs.Remove(loaiNgDung);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoaiNgDungExists(int id)
        {
            return _context.LoaiNgDungs.Any(e => e.LoaiNgDungID == id);
        }
    }
}
