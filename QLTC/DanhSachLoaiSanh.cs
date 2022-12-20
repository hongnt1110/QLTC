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
    public partial class DanhSachLoaiSanh : Form
    {
        public DanhSachLoaiSanh()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        private void btnHienThiLoaiSanh_Click(object sender, EventArgs e)
        {
            danhSachLSanh.DataSource = DanhSachLSanh.ListLoaiSanh();
        }

        private void btnTimLoaiSanh_Click(object sender, EventArgs e)
        {
            if (timLoaiSanh.Text == "Tìm kiếm theo tên loại sảnh")
            {
                MessageBox.Show("Vui lòng nhập tên loại sảnh để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                danhSachLSanh.DataSource = DanhSachLSanh.SearchLoaiSanh('%' + timLoaiSanh.Text + '%');
            }
        }

        private void btnThemLoaiSanh_Click(object sender, EventArgs e)
        {
            ThemLoaiSanh loaiSanh = new ThemLoaiSanh();
            loaiSanh.ShowDialog();
            danhSachLSanh.DataSource = DanhSachLSanh.ListLoaiSanh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                this.Hide();
                QuanLyDichVu ql = new QuanLyDichVu();
                ql.ShowDialog();
            }
        }
        private void btnXoaLoaiSanh_Click(object sender, EventArgs e)
        {
            if (danhSachLSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn loại sảnh để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachLSanh.DataSource = DanhSachLSanh.ListLoaiSanh();
            }
            else
            {
                int loaiSanh = int.Parse(danhSachLSanh.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa loại sảnh không?", "Xác nhận xóa loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    DanhSachLSanh.DeleteLoaiSanh(loaiSanh);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    danhSachLSanh.DataSource = DanhSachLSanh.ListLoaiSanh();
                }
            }
            
        }

        private void btnSuaLoaiSanh_Click(object sender, EventArgs e)
        {
            if(danhSachLSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn loại sảnh để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachLSanh.DataSource = DanhSachLSanh.ListLoaiSanh();
            }
            else
            {
                string ma = danhSachLSanh.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachLSanh.CurrentRow.Cells[1].Value.ToString();
                string donGia = danhSachLSanh.CurrentRow.Cells[2].Value.ToString();
                SuaLoaiSanh suaLSanh = new SuaLoaiSanh(ma, ten, donGia);
                suaLSanh.ShowDialog();
                danhSachLSanh.DataSource = DanhSachLSanh.ListLoaiSanh();
            }
            
        }
    }
}
