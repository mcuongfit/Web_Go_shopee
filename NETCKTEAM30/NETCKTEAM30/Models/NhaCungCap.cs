using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class NhaCungCap
    {
        public int NhaCungCapID { get; set; }
        public string TenNhaCc { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string MoTa { get; set; }
        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
