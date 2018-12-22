using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class NguoiDung
    {
        public int NguoiDungID { get; set; }
        public string HoTen { get; set; }
        public int GioiTinhID { get; set; }
        [ForeignKey("GioiTinhID")]
        public GioiTinh GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string Hinh { get; set; }
        public int LoaiNgDungID { get; set; }
        [ForeignKey("LoaiNgDungID")]
        public LoaiNgDung LoaiNgDung { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }
}
