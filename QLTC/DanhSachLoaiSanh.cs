using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        DataDichVuTableAdapters.LOAISANHTableAdapter DanhSachLSanh = new DataDichVuTableAdapters.LOAISANHTableAdapter();
        private void btnHienThiLoaiSanh_Click(object sender, EventArgs e)
        {
            DataTable listLoaiSanh = new DataTable();
            SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH");
            ShowData(listLoaiSanh, danhSachLSanh);
        }

        private void btnTimLoaiSanh_Click(object sender, EventArgs e)
        {
            if (timLoaiSanh.Text == "Tìm kiếm theo tên loại sảnh")
            {
                MessageBox.Show("Vui lòng nhập tên loại sảnh để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DataTable listLoaiSanh = new DataTable();
                SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH WHERE LoaiSanh LIKE '%" + timLoaiSanh.Text + "%'");
                ShowData(listLoaiSanh, danhSachLSanh);
            }
        }

        private void btnThemLoaiSanh_Click(object sender, EventArgs e)
        {
            ThemLoaiSanh loaiSanh = new ThemLoaiSanh();
            loaiSanh.ShowDialog();
            DataTable listLoaiSanh = new DataTable();
            SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH");
            ShowData(listLoaiSanh, danhSachLSanh);
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
                DataTable listLoaiSanh = new DataTable();
                SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH");
                ShowData(listLoaiSanh, danhSachLSanh);
            }
            else
            {
                int loaiSanh = int.Parse(danhSachLSanh.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa loại sảnh không?", "Xác nhận xóa loại sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    DanhSachLSanh.DeleteLoaiSanh(loaiSanh);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    DataTable listLoaiSanh = new DataTable();
                    SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH");
                    ShowData(listLoaiSanh, danhSachLSanh);
                }
            }
            
        }

        private void btnSuaLoaiSanh_Click(object sender, EventArgs e)
        {
            if(danhSachLSanh.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn loại sảnh để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DataTable listLoaiSanh = new DataTable();
                SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH");
                ShowData(listLoaiSanh, danhSachLSanh);
            }
            else
            {
                string ma = danhSachLSanh.CurrentRow.Cells[0].Value.ToString();
                string ten = danhSachLSanh.CurrentRow.Cells[1].Value.ToString();
                string donGia = danhSachLSanh.CurrentRow.Cells[2].Value.ToString();
                SuaLoaiSanh suaLSanh = new SuaLoaiSanh(ma, ten, donGia);
                suaLSanh.ShowDialog();
                DataTable listLoaiSanh = new DataTable();
                SelectList(listLoaiSanh, "SELECT MaLoaiSanh AS N'MÃ LOẠI SẢNH', LoaiSanh AS N'LOẠI SẢNH', DonGia AS N'DonGia' FROM LOAISANH");
                ShowData(listLoaiSanh, danhSachLSanh);
            }
            
        }
    }
}
