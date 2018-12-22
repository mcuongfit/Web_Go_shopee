using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class chitietViewModel
    {
        public HangHoa don { get; set; }
        public List<HangHoa> dhhhcungloai { get; set; }
        public List<HangHoa> dhhhcungncc { get; set; }
        public List<BinhLuan> bluans { get; set; }
    }
}
