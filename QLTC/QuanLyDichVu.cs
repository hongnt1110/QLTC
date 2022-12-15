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
    public partial class QuanLyDichVu : Form
    {
        public QuanLyDichVu()
        {
            InitializeComponent();
        }
        private void QuanLyDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDichVu.SANH' table. You can move, or remove it, as needed.
            this.sANHTableAdapter.Fill(this.dataDichVu.SANH);
            // TODO: This line of code loads data into the 'dataDichVu.MONAN' table. You can move, or remove it, as needed.
            this.mONANTableAdapter.Fill(this.dataDichVu.MONAN);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(xacNhan == DialogResult.Yes)
            {
            this.Hide();
            ManHinhChinh main = new ManHinhChinh();
            main.ShowDialog();
            }
        } 
        // Thực Đơn
        DataDichVuTableAdapters.MONANTableAdapter DanhSachMonAn = new DataDichVuTableAdapters.MONANTableAdapter();
        private void btnHienThiThucDon_Click(object sender, EventArgs e)
        {
            danhSachThucDon.DataSource = DanhSachMonAn.ListThucDon();
        }
        private void btnThemThucDon_Click(object sender, EventArgs e)
        {
            ThemThucDon themThucDon = new ThemThucDon();
            themThucDon.ShowDialog();
            danhSachThucDon.DataSource = DanhSachMonAn.ListThucDon();
        }
        private void btnSuaThucDon_Click(object sender, EventArgs e)
        {
            SuaThucDon suaThucDon = new SuaThucDon();
            suaThucDon.ShowDialog();
        }
        private void btnXoaThucDon_Click(object sender, EventArgs e)
        {
            int monAn = int.Parse(danhSachThucDon.CurrentRow.Cells[0].Value.ToString());
            DialogResult xacNhan = MessageBox.Show("Có muốn xóa món ăn không?", "Xác nhận xóa món ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(xacNhan == DialogResult.Yes)
            {
            DanhSachMonAn.DeleteThucDon(monAn);
            MessageBox.Show("Xóa thành công","Thông Báo",MessageBoxButtons.OK);
            danhSachThucDon.DataSource = DanhSachMonAn.ListThucDon();
            }
        }
        private void btnTimThucDon_Click(object sender, EventArgs e)
        {
            if(timThucDon.Text == "Tìm kiếm theo tên món ăn")
            {
                MessageBox.Show("Vui lòng nhập tên món ăn để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                danhSachThucDon.DataSource = DanhSachMonAn.SearchThucDon('%'+timThucDon.Text+'%');
            }
        }
        // Dịch Vụ
        DataDichVuTableAdapters.DICHVUTableAdapter DanhSachDichVu = new DataDichVuTableAdapters.DICHVUTableAdapter();
        private void btnHienThiDichVu_Click(object sender, EventArgs e)
        {
            danhSachDichVu.DataSource = DanhSachDichVu.ListDichVu();
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVu = new ThemDichVu();
            themDichVu.ShowDialog();
            danhSachDichVu.DataSource = DanhSachDichVu.ListDichVu();
        }
        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            SuaDichVu suaDichVu = new SuaDichVu();
            suaDichVu.ShowDialog();
        }
        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            int dichVu = int.Parse(danhSachDichVu.CurrentRow.Cells[0].Value.ToString());
            DialogResult xacNhan = MessageBox.Show("Có muốn xóa dịch vụ không?", "Xác nhận xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                DanhSachDichVu.DeleteDichVu(dichVu);
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                danhSachDichVu.DataSource = DanhSachDichVu.ListDichVu();
            }
        }
        private void btnTimDichVu_Click(object sender, EventArgs e)
        {
            if (timDichVu.Text == "Tìm kiếm theo tên dịch vụ")
            {
                MessageBox.Show("Vui lòng nhập tên dịch vụ để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                danhSachDichVu.DataSource = DanhSachDichVu.SearchDichVu('%' + timDichVu.Text + '%');
            }
        }
        // Sảnh
        DataDichVuTableAdapters.SANHTableAdapter DanhSachSanh = new DataDichVuTableAdapters.SANHTableAdapter();
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLoaiSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        private void btnHienThiSanh_Click(object sender, EventArgs e)
        {
            danhSachSanh.DataSource = DanhSachSanh.ListSanh();
        }
        private void btnThemSanh_Click(object sender, EventArgs e)
        {
            ThemSanh themSanh = new ThemSanh();
            themSanh.ShowDialog();
            danhSachSanh.DataSource = DanhSachSanh.ListSanh();
        }
        private void btnXoaSanh_Click(object sender, EventArgs e)
        {
            int sanh = int.Parse(danhSachSanh.CurrentRow.Cells[0].Value.ToString());
            DialogResult xacNhan = MessageBox.Show("Có muốn xóa sảnh không?", "Xác nhận xóa sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                DanhSachSanh.DeleteSanh(sanh);
                MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                danhSachSanh.DataSource = DanhSachSanh.ListSanh();
            }
        }

        private void btnTimSanh_Click(object sender, EventArgs e)
        {
            if (timSanh.Text == "Tìm kiếm theo tên sảnh")
            {
                MessageBox.Show("Vui lòng nhập tên sảnh để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                danhSachSanh.DataSource = DanhSachSanh.SearchSanh('%' + timSanh.Text + '%');
            }
        }
    }
}
