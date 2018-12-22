using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class ChiTietHd
    {
        public int ChiTietHdID { get; set; }
        public int HoaDonID { get; set; }
        [ForeignKey("HoaDonID")]
        public HoaDon HoaDon { get; set; }
        public int HangHoaID { get; set; }
        [ForeignKey("HangHoaID")]
        public HangHoa HangHoa { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public double GiamGia { get; set; }
        public double ThanhTien => SoLuong * (DonGia * (1 - GiamGia));
    }
}
