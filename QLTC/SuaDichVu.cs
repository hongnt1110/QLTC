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
    public partial class SuaDichVu : Form
    {
        private string _ma;
        private string _ten;
        private string _donGia;
        public SuaDichVu()
        {
            InitializeComponent();
        }
        public SuaDichVu(string ma, string ten, string gia) : this()
        {
            _ma = ma;
            _ten = ten;
            _donGia = gia;
            maDichVu.Text = _ma;
            tenDichVu.Text = _ten;
            donGiaDichVu.Text = _donGia;
            maDichVu.Enabled = false;
        }
        DataDichVuTableAdapters.DICHVUTableAdapter DanhSachDichVu = new DataDichVuTableAdapters.DICHVUTableAdapter();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tenDichVu.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tenDichVu.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult xacNhan = MessageBox.Show("Có muốn lưu thay đổi dịch vụ không?", "Xác nhận lưu dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    int gia = (int)Math.Round(float.Parse(donGiaDichVu.Text, CultureInfo.InvariantCulture.NumberFormat));
                    DanhSachDichVu.UpdateDichVu(tenDichVu.Text, gia, int.Parse(maDichVu.Text));
                    MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                    this.Hide();
                }
            }
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void donGiaDichVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
