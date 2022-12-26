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
    public partial class SuaLoaiSanh : Form
    {
        private string _ma;
        private string _ten;
        private string _donGia;
        public SuaLoaiSanh()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        public SuaLoaiSanh(string ma, string ten, string gia): this()
        {
            _ma = ma;
            _ten = ten;
            _donGia = gia;
            maLoaiSanh.Text = _ma;
            tenLoaiSanh.Text = _ten;
            donGiaLoaiSanh.Text = _donGia;
            maLoaiSanh.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tenLoaiSanh.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập tên loại sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (donGiaLoaiSanh.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá loại sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult xacNhan = MessageBox.Show("Có muốn lưu thay đổi loại sảnh không?", "Xác nhận lưu loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                int gia = (int)Math.Round(float.Parse(donGiaLoaiSanh.Text, CultureInfo.InvariantCulture.NumberFormat));
                DanhSachLSanh.UpdateLoaiSanh(tenLoaiSanh.Text, gia, int.Parse(maLoaiSanh.Text));
                MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                this.Hide();
                }
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void donGiaLoaiSanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
