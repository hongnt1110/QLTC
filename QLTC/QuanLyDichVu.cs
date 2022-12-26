using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
        private void SelectList(DataTable list, string query)
        {
            string connectionString = @"Data Source=LUAN-LENOVO\LUANNGUYEN;Initial Catalog=QLTC;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            list.Load(reader);
            connection.Close();
        }
        private void ShowData(DataTable list, DataGridView gridView)
        {
            gridView.DataSource = list;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 9, FontStyle.Bold);
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
            DataTable listMonAn = new DataTable();
            SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN");
            ShowData(listMonAn, danhSachThucDon);
        }
        private void btnThemThucDon_Click(object sender, EventArgs e)
        {
            ThemThucDon themThucDon = new ThemThucDon();
            themThucDon.ShowDialog();
            DataTable listMonAn = new DataTable();
            SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN");
            ShowData(listMonAn, danhSachThucDon);
        }
        private void btnSuaThucDon_Click(object sender, EventArgs e)
        {
            if (danhSachThucDon.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn món ăn để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listMonAn = new DataTable();
                SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN");
                ShowData(listMonAn, danhSachThucDon);
            }
            else
            {
                string ma = danhSachThucDon.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachThucDon.CurrentRow.Cells[1].Value.ToString();
                string donGia = danhSachThucDon.CurrentRow.Cells[2].Value.ToString();
                SuaThucDon suaThucDon = new SuaThucDon(ma, ten, donGia);
                suaThucDon.ShowDialog();
                DataTable listMonAn = new DataTable();
                SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN");
                ShowData(listMonAn, danhSachThucDon);
            }
        }
        private void btnXoaThucDon_Click(object sender, EventArgs e)
        {
            if (danhSachThucDon.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn món ăn để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listMonAn = new DataTable();
                SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN");
                ShowData(listMonAn, danhSachThucDon);
            }
            else
            {
                int monAn = int.Parse(danhSachThucDon.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa món ăn không?", "Xác nhận xóa món ăn", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(xacNhan == DialogResult.Yes)
                {
                DanhSachMonAn.DeleteThucDon(monAn);
                MessageBox.Show("Xóa thành công","Thông Báo",MessageBoxButtons.OK);
                DataTable listMonAn = new DataTable();
                SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN");
                ShowData(listMonAn, danhSachThucDon);
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
                DataTable listMonAn = new DataTable();
                SelectList(listMonAn, "SELECT MaMonAn AS N'MÃ MÓN ĂN', TenMonAn AS N'TÊN MÓN ĂN', DonGia AS N'ĐƠN GIÁ' FROM MONAN WHERE TenMonAN LIKE '%" + timThucDon.Text + "%'");
                ShowData(listMonAn, danhSachThucDon);
            }
        }
        // Dịch Vụ
        DataDichVuTableAdapters.DICHVUTableAdapter DanhSachDichVu = new DataDichVuTableAdapters.DICHVUTableAdapter();
        private void btnHienThiDichVu_Click(object sender, EventArgs e)
        {
            DataTable listDichVu = new DataTable();
            SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU");
            ShowData(listDichVu, danhSachDichVu);
        }
        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            ThemDichVu themDichVu = new ThemDichVu();
            themDichVu.ShowDialog();
            DataTable listDichVu = new DataTable();
            SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU");
            ShowData(listDichVu, danhSachDichVu);
        }
        private void btnSuaDichVu_Click(object sender, EventArgs e)
        {
            if (danhSachDichVu.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn dịch vụ để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listDichVu = new DataTable();
                SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU");
                ShowData(listDichVu, danhSachDichVu);
            }
            else
            {
                string ma = danhSachDichVu.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachDichVu.CurrentRow.Cells[1].Value.ToString();
                string donGia = danhSachDichVu.CurrentRow.Cells[2].Value.ToString();
                SuaDichVu suaDichVu = new SuaDichVu(ma, ten, donGia);
                suaDichVu.ShowDialog();
                DataTable listDichVu = new DataTable();
                SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU");
                ShowData(listDichVu, danhSachDichVu);
            }
        }
        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            if (danhSachDichVu.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn dịch vụ để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listDichVu = new DataTable();
                SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU");
                ShowData(listDichVu, danhSachDichVu);
            }
            else
            {
                int dichVu = int.Parse(danhSachDichVu.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa dịch vụ không?", "Xác nhận xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    DanhSachDichVu.DeleteDichVu(dichVu);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    DataTable listDichVu = new DataTable();
                    SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU");
                    ShowData(listDichVu, danhSachDichVu);
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
                DataTable listDichVu = new DataTable();
                SelectList(listDichVu, "SELECT MaDichVu AS N'MÃ DỊCH VỤ', TenDichVu AS N'TÊN DỊCH VỤ', DonGia AS N'ĐƠN GIÁ' FROM DICHVU WHERE TenDichVu LIKE '%" + timDichVu.Text + "%'");
                ShowData(listDichVu, danhSachDichVu);
            }
        }
        // Sảnh
       
        DataDichVuTableAdapters.SANHTableAdapter DanhSachSanh = new DataDichVuTableAdapters.SANHTableAdapter();
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLoaiSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        private void btnHienThiSanh_Click(object sender, EventArgs e)
        {
            DataTable listSanh = new DataTable();
            SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh");
            ShowData(listSanh, danhSachSanh);
        }
        private void btnThemSanh_Click(object sender, EventArgs e)
        {
            ThemSanh themSanh = new ThemSanh();
            themSanh.ShowDialog();
            DataTable listSanh = new DataTable();
            SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh");
            ShowData(listSanh, danhSachSanh);
        }
        private void btnXoaSanh_Click(object sender, EventArgs e)
        {
            if (danhSachSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn sảnh để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listSanh = new DataTable();
                SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh");
                ShowData(listSanh, danhSachSanh);
            }
            else
            {
                int sanh = int.Parse(danhSachSanh.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa sảnh không?", "Xác nhận xóa sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    DanhSachSanh.DeleteSanh(sanh);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    DataTable listSanh = new DataTable();
                    SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh");
                    ShowData(listSanh, danhSachSanh);
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
                DataTable listSanh = new DataTable();
                SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh AND s.TenSanh LIKE '%" + timSanh.Text + "%'");
                ShowData(listSanh, danhSachSanh);
            }
        }
        private void btnSuaSanh_Click(object sender, EventArgs e)
        {
            if (danhSachSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn sảnh để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listSanh = new DataTable();
                SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh");
                ShowData(listSanh, danhSachSanh);
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
                DataTable listSanh = new DataTable();
                SelectList(listSanh, "SELECT s.MaSanh AS N'MÃ SẢNH', s.TenSanh AS N'TÊN SẢNH', ls.LoaiSanh AS N'LOẠI SẢNH', s.SoLuongBanToiDa AS N'SỐ LƯỢNG BÀN TỐI ĐA', s.DonGiaBanToiThieu AS N'ĐƠN GIÁ BÀN TỐI THIỂU', s.Ghichu AS 'GHI CHÚ'FROM SANH s, LOAISANH ls WHERE s.MaLoaiSanh = ls.MaLoaiSanh");
                ShowData(listSanh, danhSachSanh);
            }
        }
        private void btnLoaiSanh_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachLoaiSanh loaiSanh = new DanhSachLoaiSanh();
            loaiSanh.ShowDialog();
        }

        private void listToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sANHTableAdapter.List(this.dataDichVu.SANH);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        DataDichVuTableAdapters.CATableAdapter DanhSachCa = new DataDichVuTableAdapters.CATableAdapter();
        private void btnHienThiCa_Click(object sender, EventArgs e)
        {
            DataTable listCa = new DataTable();
            SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA");
            ShowData(listCa, danhSachCa);
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            ThemCa themCa = new ThemCa();
            themCa.ShowDialog();
            DataTable listCa = new DataTable();
            SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA");
            ShowData(listCa, danhSachCa);
        }

        private void btnSuaCa_Click(object sender, EventArgs e)
        {
            if (danhSachCa.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn ca để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listCa = new DataTable();
                SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA");
                ShowData(listCa, danhSachCa);
            }
            else
            {
                string ma = danhSachCa.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachCa.CurrentRow.Cells[1].Value.ToString();
                string tg = danhSachCa.CurrentRow.Cells[2].Value.ToString();
                SuaCa suaCa = new SuaCa(ma, ten, tg);
                suaCa.ShowDialog();
                DataTable listCa = new DataTable();
                SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA");
                ShowData(listCa, danhSachCa);
            }
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if (danhSachCa.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn ca để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listCa = new DataTable();
                SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA");
                ShowData(listCa, danhSachCa);
            }
            else
            {
                int ca = int.Parse(danhSachCa.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa ca không?", "Xác nhận xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    DanhSachCa.DeleteCa(ca);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    DataTable listCa = new DataTable();
                    SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA");
                    ShowData(listCa, danhSachCa);
                }
            }
        }

        private void btnTimCa_Click(object sender, EventArgs e)
        {
            if (timCa.Text == "Tìm kiếm theo tên ca")
            {
                MessageBox.Show("Vui lòng nhập tên ca để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable listCa = new DataTable();
                SelectList(listCa, "SELECT MaCa AS N'MÃ CA', LoaiCa AS N'LOẠI CA', ThoiGian AS N'THỜI GIAN' FROM CA WHERE LoaiCa LIKE '%" + timCa.Text + "%'");
                ShowData(listCa, danhSachCa);
            }
        }
    }
}
