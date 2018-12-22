using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class HoaDon
    {
        public int HoaDonID { get; set; }
        public int NguoiDungID { get; set; }
        [ForeignKey("NguoiDungID")]
        public NguoiDung NguoiDung { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayNhan { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public int ThanhToanID { get; set; }
        [ForeignKey("ThanhToanID")]
        public ThanhToan ThanhToan { get; set; }
        public int VanChuyenID { get; set; }
        [ForeignKey("VanChuyenID")]
        public VanChuyen VanChuyen { get; set; }
        public double PhiVanChuyen { get; set; }
        public int TrangThaiID { get; set; }
        [ForeignKey("TrangThaiID")]
        public TrangThai TrangThai { get; set; }
        public string GhiChu { get; set; }
    }
}
