using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class ThanhToanViewModel
    {
        public Thongtinkh thongtinKH { get; set; }
        public List<ChiTietHd> Cthd { get; set; }

    }
    public class Thongtinkh
    {
        public string TENKH { get; set; }
        public string SDT { get; set; }
        public int HTTHANHTOAN { get; set; }
        public string DCNHAN { get; set; }
        public int HTVANCHUYEN { get; set; }
        public double PHIVC { get; set; }
    }
}
