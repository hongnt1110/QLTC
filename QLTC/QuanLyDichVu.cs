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
        public QuanLyDichVu(int a):this()
        {
            tabDichVu.SelectedTab = tabDichVu.TabPages[a];
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
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if (danhSachThucDon.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn món ăn để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachThucDon.DataSource = DanhSachMonAn.ListThucDon();
            }
            else
            {
                string ma = danhSachThucDon.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachThucDon.CurrentRow.Cells[1].Value.ToString();
                string donGia = danhSachThucDon.CurrentRow.Cells[2].Value.ToString();
                SuaThucDon suaThucDon = new SuaThucDon(ma, ten, donGia);
                suaThucDon.ShowDialog();
                danhSachThucDon.DataSource = DanhSachMonAn.ListThucDon();
            }
        }
        private void btnXoaThucDon_Click(object sender, EventArgs e)
        {
            if (danhSachThucDon.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn món ăn để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachThucDon.DataSource = DanhSachMonAn.ListThucDon();
            }
            else
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
            if (danhSachDichVu.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn dịch vụ để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachDichVu.DataSource = DanhSachDichVu.ListDichVu();
            }
            else
            {
                string ma = danhSachDichVu.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachDichVu.CurrentRow.Cells[1].Value.ToString();
                string donGia = danhSachDichVu.CurrentRow.Cells[2].Value.ToString();
                SuaDichVu suaDichVu = new SuaDichVu(ma, ten, donGia);
                suaDichVu.ShowDialog();
                danhSachDichVu.DataSource = DanhSachDichVu.ListDichVu();
            }
        }
        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (danhSachDichVu.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn dịch vụ để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachDichVu.DataSource = DanhSachDichVu.ListDichVu();
            }
            else
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
            if (danhSachSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn sảnh để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachSanh.DataSource = DanhSachSanh.ListSanh();
            }
            else
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
        private void btnSuaSanh_Click(object sender, EventArgs e)
        {
            if (danhSachSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn sảnh để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                danhSachSanh.DataSource = DanhSachSanh.ListSanh();
            }
            else
            {
                string ma = danhSachSanh.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachSanh.CurrentRow.Cells[1].Value.ToString();
                string loai = danhSachSanh.CurrentRow.Cells[2].Value.ToString();
                string soLuong = danhSachSanh.CurrentRow.Cells[3].Value.ToString();
                string donGiaBan = danhSachSanh.CurrentRow.Cells[4].Value.ToString();
                string ghi = danhSachSanh.CurrentRow.Cells[5].Value.ToString();
                SuaSanh suaSanh = new SuaSanh(ma, ten, loai,soLuong, donGiaBan,ghi);
                suaSanh.ShowDialog();
                danhSachSanh.DataSource = DanhSachSanh.ListSanh();
            }
        }
        private void btnLoaiSanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachLoaiSanh loaiSanh = new DanhSachLoaiSanh();
            loaiSanh.ShowDialog();
        }
    }
}
