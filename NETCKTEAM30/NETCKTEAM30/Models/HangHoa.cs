using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class HangHoa
    {
        public int HanghoaID { get; set; }
        public string TenHh { get; set; }
        public int MaLoaiID { get; set; }
        [ForeignKey("MaLoaiID")]
        public Loai Loai { get; set; }
        public double DonGia { get; set;}
        public string Hinh { get; set; }
        public int NhaCungCapID { get; set; }
        [ForeignKey("NhaCungCapID")]
        public NhaCungCap NhaCungCap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MoTa { get; set; }
        public double GiamGia { get; set; }
        public int LuotMua { get; set; }
    }
}
