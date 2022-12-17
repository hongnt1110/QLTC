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
    public partial class ThemDichVu : Form
    {
        public ThemDichVu()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.DICHVUTableAdapter DanhSachDichVu = new DataDichVuTableAdapters.DICHVUTableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tenDichVu.Text == "Nhập tên dịch vụ")
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (donGiaDichVu.Text == "Nhập đơn giá dịch vụ")
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int donGia = int.Parse(donGiaDichVu.Text);
                string dichVu = tenDichVu.Text;
                DanhSachDichVu.InsertDichVu(dichVu, donGia);
                MessageBox.Show("Thêm dịch vụ " + dichVu + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
