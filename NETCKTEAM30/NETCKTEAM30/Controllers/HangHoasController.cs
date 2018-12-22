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
    public class HangHoasController : Controller
    {
        private readonly MyDbContext _context;

        public HangHoasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: HangHoas
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.HangHoas.Include(h => h.Loai).Include(h => h.NhaCungCap);

            return View(await myDbContext.ToListAsync());
        }

        // GET: HangHoas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas
                .Include(h => h.Loai)
                .Include(h => h.NhaCungCap)
                .FirstOrDefaultAsync(m => m.HanghoaID == id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            string[] arrListStr = hangHoa.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(hangHoa);
        }

        // GET: HangHoas/Create
        public IActionResult Create()
        {
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "TenLoai");
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "TenNhaCc");
            return View();
        }

        // POST: HangHoas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("HanghoaID,TenHh,MaLoaiID,DonGia,Hinh,NhaCungCapID,NgayNhap,MoTa,GiamGia,LuotMua")] HangHoa hangHoa, IFormFile[] myfile)
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
                    hangHoa.Hinh = arr;
                }
                _context.Add(hangHoa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "LoaiID", hangHoa.MaLoaiID);
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "NhaCungCapID", hangHoa.NhaCungCapID);
            return View(hangHoa);
        }

        // GET: HangHoas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas.FindAsync(id);
            if (hangHoa == null)
            {
                return NotFound();
            }
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "TenLoai", hangHoa.MaLoaiID);
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "TenNhaCc", hangHoa.NhaCungCapID);
            string[] arrListStr = hangHoa.Hinh.Split(';');
            ViewBag.arr = arrListStr;
            return View(hangHoa);
        }

        // POST: HangHoas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HanghoaID,TenHh,MaLoaiID,DonGia,Hinh,NhaCungCapID,NgayNhap,MoTa,GiamGia,LuotMua")] HangHoa hangHoa, IFormFile[] myfile)
        {
            if (id != hangHoa.HanghoaID)
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
                        hangHoa.Hinh = arr;
                    }
                    _context.Update(hangHoa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HangHoaExists(hangHoa.HanghoaID))
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
            ViewData["MaLoaiID"] = new SelectList(_context.Loais, "LoaiID", "LoaiID", hangHoa.MaLoaiID);
            ViewData["NhaCungCapID"] = new SelectList(_context.NhaCungCaps, "NhaCungCapID", "NhaCungCapID", hangHoa.NhaCungCapID);
            return View(hangHoa);
        }

        // GET: HangHoas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hangHoa = await _context.HangHoas
                .Include(h => h.Loai)
                .Include(h => h.NhaCungCap)
                .FirstOrDefaultAsync(m => m.HanghoaID == id);
            if (hangHoa == null)
            {
                return NotFound();
            }

            return View(hangHoa);
        }

        // POST: HangHoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hangHoa = await _context.HangHoas.FindAsync(id);
            _context.HangHoas.Remove(hangHoa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HangHoaExists(int id)
        {
            return _context.HangHoas.Any(e => e.HanghoaID == id);
        }
        public IActionResult HangHoaTheoLoai(int? LoaiID, int? NhaCungCapID)
        {

            List<HangHoa> DsHh = new List<HangHoa>();
            if (LoaiID.HasValue)
            {
                DsHh = _context.HangHoas.Where(h => h.HanghoaID == LoaiID).ToList();
            }
            if (NhaCungCapID.HasValue)
            {
                DsHh = _context.HangHoas.Where(h => h.NhaCungCapID == NhaCungCapID).ToList();
            }
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));

        }
        public IActionResult selectAo()
        {
            List<HangHoa> DsHh = new List<HangHoa>();
            DsHh = _context.HangHoas.Where(h => h.MaLoaiID == 1).ToList();
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
        }
        public IActionResult selectQuan()
        {
            List<HangHoa> DsHh = new List<HangHoa>();
            DsHh = _context.HangHoas.Where(h => h.MaLoaiID == 2).ToList();
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
        }
        public IActionResult selectGiay()
        {
            List<HangHoa> DsHh = new List<HangHoa>();
            DsHh = _context.HangHoas.Where(h => h.MaLoaiID == 4).ToList();
            return View(DsHh.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));
        }
        public IActionResult Search(string keyword = "")
        {
            if (keyword != null)
            {
                keyword = keyword.ToLower();
                var data = _context.HangHoas.Where(p => p.TenHh.ToLower().Contains(keyword))
                    .Select(p => new HangHoaViewModel
                    {
                        MaHH = p.HanghoaID,
                        TenHH = p.TenHh,
                        Hinh = p.Hinh,
                        DonGia = p.DonGia,
                        GiamGia = p.GiamGia
                    }).ToList();

                return PartialView(data);
            }
            else
            {
                return PartialView();
            }
        }
        public IActionResult layhanghoa(int? maloai, int? mancc)
        {

            List<HangHoa> dsHangHoas = new List<HangHoa>();
            if (maloai.HasValue)
            {
                dsHangHoas = _context.HangHoas.Where(p => p.MaLoaiID == maloai)
                    .ToList();
            }

            if (mancc.HasValue)
            {
                dsHangHoas = _context.HangHoas.Where(p => p.NhaCungCapID == mancc)
                    .ToList();
            }
            return View(dsHangHoas.Select(h => new HangHoaViewModel
            {
                MaHH = h.HanghoaID,
                TenHH = h.TenHh,
                Hinh = h.Hinh,
                DonGia = h.DonGia,
                GiamGia = h.GiamGia
            }));

        }
        public IActionResult chitiet(int? id)
        {
            chitietViewModel model = new chitietViewModel();
            List<HangHoa> dshhcl = new List<HangHoa>();
            List<HangHoa> dshhcnhacc = new List<HangHoa>();
            HangHoa hh = new HangHoa();
            List<BinhLuan> bls = new List<BinhLuan>();
            if (id.HasValue)
            {
                hh = _context.HangHoas.SingleOrDefault(p => p.HanghoaID == id);

                bls = _context.BinhLuans.Include(x => x.NguoiDung).Where(p => p.HangHoaID == id).ToList();
            }
            else
            {
                hh = _context.HangHoas.SingleOrDefault(p => p.HanghoaID == HttpContext.Session.Get<int>("idhh"));
                bls = _context.BinhLuans.Include(x => x.NguoiDung).Where(p => p.HangHoaID == HttpContext.Session.Get<int>("idhh")).ToList();
            }
            dshhcl = _context.HangHoas.Where(p => p.MaLoaiID == hh.MaLoaiID).ToList();
            dshhcnhacc = _context.HangHoas.Where(p => p.NhaCungCapID == hh.NhaCungCapID).ToList();
            model.don = hh;
            model.dhhhcungloai = dshhcl;
            model.dhhhcungncc = dshhcnhacc;

            model.bluans = bls;
            return View(model);
        }

        [HttpPost]
        public IActionResult mua(int mahh, int soluong, int id)
        {

            if (mahh != 0)
            {
                HangHoa hh = new HangHoa();
                hh = _context.HangHoas.Where(p => p.HanghoaID == mahh).First();
                if (HttpContext.Session.Get<int>("xacnhanmuaxong") != 1)
                {

                    if (HttpContext.Session.Get<NguoiDung>("MaKH") == null)
                    {
                        HttpContext.Session.Set<int>("a", 3);
                        return RedirectToAction("index", "Home");
                    }
                    else
                    {
                        NguoiDung ngd = HttpContext.Session.Get<NguoiDung>("MaKH");
                        HoaDon hd = new HoaDon();
                        hd.NguoiDungID = ngd.NguoiDungID;
                        DateTime d = DateTime.Now;

                        hd.NgayDat = d;
                        hd.NgayNhan = d;

                        hd.HoTen = ngd.HoTen;
                        hd.DiaChi = ngd.DiaChi;
                        hd.ThanhToanID = 1;
                        hd.VanChuyenID = 1;
                        hd.PhiVanChuyen = 0;
                        hd.TrangThaiID = 1;
                        hd.GhiChu = ngd.DiaChi;
                        _context.hoaDons.Add(hd);
                        _context.SaveChanges();
                        HttpContext.Session.Set("hoadonid", hd.HoaDonID);
                        ChiTietHd cthd = new ChiTietHd();

                        cthd.HoaDonID = hd.HoaDonID;

                        cthd.HangHoaID = mahh;
                        cthd.DonGia = hh.DonGia;
                        cthd.SoLuong = soluong;

                        cthd.GiamGia = hh.GiamGia;

                        _context.chiTietHds.Add(cthd);
                        _context.SaveChanges();
                        HttpContext.Session.Set("xacnhanmuaxong", 1);
                    }
                }
                else
                {

                    ChiTietHd cthd = new ChiTietHd();

                    cthd.HoaDonID = HttpContext.Session.Get<int>("hoadonid");

                    cthd.HangHoaID = mahh;
                    cthd.DonGia = hh.DonGia;
                    cthd.SoLuong = soluong;

                    cthd.GiamGia = hh.GiamGia;

                    _context.chiTietHds.Add(cthd);
                    _context.SaveChanges();
                    HttpContext.Session.Set("xacnhanmuaxong", 1);

                }
            }
            else
            {
                var ct = _context.chiTietHds.Find(id);
                _context.chiTietHds.Remove(ct);
                _context.SaveChanges();
            }


            List<ChiTietHd> dscts = new List<ChiTietHd>();
            dscts = _context.chiTietHds.Include(x => x.HangHoa).Where(p => p.HoaDonID == HttpContext.Session.Get<int>("hoadonid")).ToList();
            double tongtien = 0;
            foreach (var item in dscts)
            {
                tongtien += item.ThanhTien;
            }
            ViewBag.TongTien = tongtien;
            return View(dscts);



        }
        public IActionResult laphoadon()
        {
            ThanhToanViewModel model = new ThanhToanViewModel();
            HoaDon hd = new HoaDon();
            hd = _context.hoaDons.Where(p => p.HoaDonID == HttpContext.Session.Get<int>("hoadonid")).First();
            NguoiDung ngd = new NguoiDung();
            ngd = _context.NguoiDungs.Where(p => p.NguoiDungID == hd.NguoiDungID).First();
            Thongtinkh tt = new Thongtinkh();
            ThanhToan ttoan = _context.ThanhToans.Where(p => p.ThanhToanID == hd.ThanhToanID).First();
            VanChuyen vc = _context.VanChuyens.Where(p => p.VanChuyenID == hd.VanChuyenID).First();
            tt.TENKH = ngd.HoTen;
            tt.SDT = ngd.SDT;
            tt.HTTHANHTOAN = ttoan.ThanhToanID;
            tt.DCNHAN = ngd.DiaChi;
            tt.HTVANCHUYEN = vc.VanChuyenID;
            tt.PHIVC = hd.PhiVanChuyen;
            model.thongtinKH = tt;
            List<ChiTietHd> dscts = new List<ChiTietHd>();
            dscts = _context.chiTietHds.Include(x => x.HangHoa).Where(p => p.HoaDonID == HttpContext.Session.Get<int>("hoadonid")).ToList();
            model.Cthd = dscts;
            double tongtien = 0;
            foreach (var item in dscts)
            {
                tongtien += item.ThanhTien;
            }
            ViewBag.TongTien = tongtien;
            ViewData["VanChuyenID"] = new SelectList(_context.VanChuyens, "VanChuyenID", "Ten");
            ViewData["ThanhToanID"] = new SelectList(_context.ThanhToans, "ThanhToanID", "Ten");
            return View(model);
        }

        public IActionResult hoattatdonhang(int tt, int vc)
        {
            HoaDon hd = _context.hoaDons.Where(p => p.HoaDonID == HttpContext.Session.Get<int>("hoadonid")).First();
            hd.TrangThaiID = 3;
            hd.VanChuyenID = vc;
            hd.ThanhToanID = tt;
            _context.hoaDons.Update(hd);
            _context.SaveChanges();

            List<ChiTietHd> cts = new List<ChiTietHd>();
            cts = _context.chiTietHds.Where(p => p.HoaDonID == hd.HoaDonID).ToList();
            foreach (var item in cts)
            {
                HangHoa hh = _context.HangHoas.Where(p => p.HanghoaID == item.HangHoaID).First();
                hh.LuotMua++;
                _context.HangHoas.Update(hh);
                _context.SaveChanges();
            }
            HttpContext.Session.Set<int>("a", 7);

            return RedirectToAction("index", "Home");
        }
        public IActionResult viewgiohang()
        {
            List<ChiTietHd> dscts = new List<ChiTietHd>();
            dscts = _context.chiTietHds.Include(x => x.HangHoa).Where(p => p.HoaDonID == HttpContext.Session.Get<int>("hoadonid")).ToList();
            double tongtien = 0;
            foreach (var item in dscts)
            {
                tongtien += item.ThanhTien;
            }
            ViewBag.TongTien = tongtien;
            return View(dscts);
        }
        public IActionResult Searchadmin(string keyword = "")
        {
            if (keyword != null)
            {
                keyword = keyword.ToLower();
                var data = _context.HangHoas.Include(h => h.Loai).Include(h => h.NhaCungCap).Where(p => p.TenHh.ToLower().Contains(keyword)).ToList();

                return PartialView(data);
            }
            else
            {
                return PartialView();
            }
        }






    }
}
