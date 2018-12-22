using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class Loai
    {
        public int LoaiID { get; set; }
        public string TenLoai { get; set; }
        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
