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
    public partial class ThemLoaiSanh : Form
    {
        public ThemLoaiSanh()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tenLoaiSanh.Text == "Nhập tên loại sảnh")
            {
                MessageBox.Show("Vui lòng nhập tên loại sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (donGiaLoaiSanh.Text == "Nhập đơn giá loại sảnh")
            {
                MessageBox.Show("Vui lòng nhập đơn giá loại sảnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int donGia = int.Parse(donGiaLoaiSanh.Text);
                string loaiSanh = tenLoaiSanh.Text;
                DanhSachLSanh.InsertLoaiSanh(loaiSanh, donGia);
                MessageBox.Show("Thêm " + loaiSanh + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
