using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class ThemSanh : Form
    {
        public ThemSanh()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.SANHTableAdapter DanhSachSanh = new DataDichVuTableAdapters.SANHTableAdapter();
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLoaiSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tenSanh.Text == "Nhập tên sảnh" || tenSanh.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập tên sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (soLuongBan.Text == "Nhập số lượng" || soLuongBan.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập số lượng bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(donGiaBan.Text == "Nhập đơn giá bàn" || donGiaBan.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Vui lòng nhập đơn giá bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (ghiChu.Text == "Nhập ghi chú" || ghiChu.Text.Replace(" ","") == "")
            {
                MessageBox.Show("Vui lòng nhập ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (DanhSachSanh.KiemTraSanh(tenSanh.Text).Count != 0)
            {
                MessageBox.Show("Sảnh đã tồn tại !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string ten = tenSanh.Text;
                int soLuong = int.Parse(soLuongBan.Text);
                int donGia = int.Parse(donGiaBan.Text);
                string ghi = ghiChu.Text;
                int loai = int.Parse(loaiSanh.SelectedValue.ToString());
                DanhSachSanh.InsertSanh(ten,loai,soLuong,donGia,ghi);
                MessageBox.Show("Thêm " + ten + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void ThemSanh_Load(object sender, EventArgs e)
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
