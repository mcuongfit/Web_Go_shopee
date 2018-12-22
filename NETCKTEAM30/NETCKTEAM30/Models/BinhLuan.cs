using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NETCKTEAM30.Models
{
    public class BinhLuan
    {
        public int BinhLuanID { get; set; }
        public int HangHoaID { get; set; }
        [ForeignKey("HangHoaID")]
        public HangHoa HangHoa { get; set; }
        public string NoiDung { get; set; }
        public int NguoiDungID { get; set; }
        [ForeignKey("NguoiDungID")]
        public NguoiDung NguoiDung { get; set; }
        public DateTime NgayBl { get; set; }

    }
}
