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
    public class GioiTinhsController : Controller
    {
        private readonly MyDbContext _context;

        public GioiTinhsController(MyDbContext context)
        {
            _context = context;
        }

        // GET: GioiTinhs
        public async Task<IActionResult> Index()
        {
            return View(await _context.GioiTinhs.ToListAsync());
        }

        // GET: GioiTinhs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioiTinh = await _context.GioiTinhs
                .FirstOrDefaultAsync(m => m.GioiTinhID == id);
            if (gioiTinh == null)
            {
                return NotFound();
            }

            return View(gioiTinh);
        }

        // GET: GioiTinhs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GioiTinhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GioiTinhID,TenGT")] GioiTinh gioiTinh)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gioiTinh);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(gioiTinh);
        }

        // GET: GioiTinhs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioiTinh = await _context.GioiTinhs.FindAsync(id);
            if (gioiTinh == null)
            {
                return NotFound();
            }
            return View(gioiTinh);
        }

        // POST: GioiTinhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GioiTinhID,TenGT")] GioiTinh gioiTinh)
        {
            if (id != gioiTinh.GioiTinhID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gioiTinh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GioiTinhExists(gioiTinh.GioiTinhID))
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
            return View(gioiTinh);
        }

        // GET: GioiTinhs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gioiTinh = await _context.GioiTinhs
                .FirstOrDefaultAsync(m => m.GioiTinhID == id);
            if (gioiTinh == null)
            {
                return NotFound();
            }

            return View(gioiTinh);
        }

        // POST: GioiTinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gioiTinh = await _context.GioiTinhs.FindAsync(id);
            _context.GioiTinhs.Remove(gioiTinh);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GioiTinhExists(int id)
        {
            return _context.GioiTinhs.Any(e => e.GioiTinhID == id);
        }
    }
}
