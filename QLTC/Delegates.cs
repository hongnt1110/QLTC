using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC
{
    public delegate void PassDataFromHoaDon(object sender, PrintTheBillEventArgs e);

     public class PrintTheBillEventArgs : EventArgs
     {
        public string _maHD { get; set; }
        public string _maPhieu { get; set; }
        public string _tongTienHD { get; set; }
        public string _tienCoc { get; set; }
        public string _tienPhaiTra { get; set; }
        public string _ngayThanhToan { get; set; }
    }
}
