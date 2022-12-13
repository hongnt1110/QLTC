using QLTC.Temporary_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC.AdminChildForm
{
    public partial class ThucDonForm : Form
    {

        public ThucDonForm()
        {
            InitializeComponent();
        }

        private void ThucDonForm_Load(object sender, EventArgs e)
        {
            List<ThucDon> thucDonList = new List<ThucDon>();
            ThucDon _thucDon;

            _thucDon = new ThucDon() { MaMatHang = "1",TenMatHang = "Mì cay", LoaiThucDon = "Thức ăn", Gia = 25000, GhiChu = "Cay"};
            thucDonList.Add(_thucDon);

            _thucDon = new ThucDon() { MaMatHang = "2", TenMatHang = "Bún bò", LoaiThucDon = "Thức ăn", Gia = 25000, GhiChu = "Ngon" };
            thucDonList.Add(_thucDon);

            _thucDon = new ThucDon() { MaMatHang = "3", TenMatHang = "Cơm tấm", LoaiThucDon = "Thức ăn", Gia = 25000, GhiChu = "Đầy đủ" };
            thucDonList.Add(_thucDon);

            _thucDon = new ThucDon() { MaMatHang = "4", TenMatHang = "Bia", LoaiThucDon = "Đồ uống", Gia = 25000, GhiChu = "Nhẹ" };
            thucDonList.Add(_thucDon);

            _thucDon = new ThucDon() { MaMatHang = "5", TenMatHang = "Coca cola", LoaiThucDon = "Đồ uống", Gia = 25000, GhiChu = "Có gas" };
            thucDonList.Add(_thucDon);

            dgvThucDon.DataSource = thucDonList;         
        }
    }
}
