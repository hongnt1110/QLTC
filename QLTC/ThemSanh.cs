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
            if (tenSanh.Text == "Nhập tên sảnh")
            {
                MessageBox.Show("Vui lòng nhập tên sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (soLuongBan.Text == "Nhập số lượng")
            {
                MessageBox.Show("Vui lòng nhập số lượng bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(donGiaBan.Text == "Nhập đơn giá bàn")
            {
                MessageBox.Show("Vui lòng nhập đơn giá bàn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (ghiChu.Text == "Nhập ghi chú")
            {
                MessageBox.Show("Vui lòng ghi chú", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
