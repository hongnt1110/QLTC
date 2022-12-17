using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class SuaThucDon : Form
    {
        private string _ma;        
        private string _ten;
        private string _donGia;

        public SuaThucDon()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.MONANTableAdapter DanhSachMonAn = new DataDichVuTableAdapters.MONANTableAdapter();
        public SuaThucDon(string ma, string ten, string gia): this()
        {
            _ma = ma;
            _ten = ten;
            _donGia = gia;
            maMonAn.Text = _ma;
            tenMonAn.Text = _ten;
            donGiaMonAn.Text = _donGia;
            maMonAn.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Có muốn lưu thay đổi món ăn không?", "Xác nhận lưu món ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                int gia = (int)Math.Round(float.Parse(donGiaMonAn.Text, CultureInfo.InvariantCulture.NumberFormat));
                DanhSachMonAn.UpdateThucDon(tenMonAn.Text, gia, int.Parse(maMonAn.Text));
                MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
