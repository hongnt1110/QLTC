using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTC
{
    public class BaoCaoNgay
    {
        public int STT { get; set; }
        public string Ngay { get; set; }
        public int SoLuongTiec { get; set; }
        public int DoanhThu { get; set; }
        public string TiLe { get; set; }
        public BaoCaoNgay(int STT,string Ngay,int SoLuongTiec,int DoanhThu,string TiLe="0") { 
            this.STT = STT;
            this.Ngay = Ngay;
            this.SoLuongTiec = SoLuongTiec;
            this.DoanhThu = DoanhThu;
            this.TiLe = TiLe;
        }
    }
}
