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
    public partial class SuaSanh : Form
    {
        private string _ma;
        private string _ten;
        private string _loai;
        private string _soLuongBan;
        private string _donGia;
        private string _ghiChu;
        public SuaSanh()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.SANHTableAdapter DanhSachSanh = new DataDichVuTableAdapters.SANHTableAdapter();
        public SuaSanh(string ma, string ten, string loai, string soLuong, string donGia, string ghi):this()
        {
            _ma = ma;
            _ten = ten;
            _loai = loai;
            _soLuongBan = soLuong;
            _donGia = donGia;
            _ghiChu = ghi;
            maSanh.Text = _ma;
            tenSanh.Text = _ten;
            loaiSanh.DisplayMember = loai;
            soLuongBan.Text = soLuong;
            donGiaBan.Text = donGia;
            ghiChu.Text = ghi;
            maSanh.Enabled = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (tenSanh.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập tên sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (soLuongBan.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (donGiaBan.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (ghiChu.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult xacNhan = MessageBox.Show("Có muốn lưu thay đổi sảnh không?", "Xác nhận lưu sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    int gia = (int)Math.Round(float.Parse(donGiaBan.Text, CultureInfo.InvariantCulture.NumberFormat));
                    DanhSachSanh.UpdateSanh(tenSanh.Text, int.Parse(loaiSanh.SelectedValue.ToString()), int.Parse(soLuongBan.Text),gia,ghiChu.Text, int.Parse(maSanh.Text));
                    MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                    this.Hide();
                }
            }
        }

        private void SuaSanh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDichVu.LOAISANH' table. You can move, or remove it, as needed.
            this.lOAISANHTableAdapter.Fill(this.dataDichVu.LOAISANH);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void soLuongBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;

            }
        }

        private void donGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;

            }
        }
    }
}
