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
    public partial class HoaDon : Form
    {
        public event PassDataFromHoaDon passData = null;
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            Display();
        }

        private DataTable GetBiLLList()
        {
            DataTable billList = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select HOADON.MaHoaDon, HOADON.MaPhieuDT,HOADON.NgayThanhToan, HOADON.TienConLai,HOADON.TongTienHD,PHIEUDATTIEC.TienCoc from PHIEUDATTIEC, HOADON where PHIEUDATTIEC.MaPhieuDT = HOADON.MaPhieuDT", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    billList.Load(reader);
                    connection.Close();
                }
            }
            return billList;
        }

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                txbMaHoaDon.Text = dgvHD.SelectedRows[0].Cells[0].Value.ToString();
                txbMaPhieu.Text = dgvHD.SelectedRows[0].Cells[0].Value.ToString();
                txbTienCoc.Text = dgvHD.SelectedRows[0].Cells[1].Value.ToString();
                dtpNgayThanhToan.Text = dgvHD.SelectedRows[0].Cells[2].Value.ToString();
                txbTongTien.Text = dgvHD.SelectedRows[0].Cells[3].Value.ToString();
                txbTienCoc.Text = dgvHD.SelectedRows[0].Cells[4].Value.ToString();
                txbTienPhaiTra.Text = dgvHD.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private void Display()
        {
            dgvHD.DataSource = GetBiLLList();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "update HOADON set NgayThanhToan = '"+ dtpNgayThanhToan.Value + "' where MaHoaDon = '"+txbMaHoaDon.Text+"' ";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            Display();
            MessageBox.Show("Cập nhật thành công!");
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            InHoaDon inHoaDon= new InHoaDon();
            inHoaDon.Enabled= true;
            inHoaDon.MaHD = txbMaHoaDon.Text;
            inHoaDon.MaPhieu = txbMaPhieu.Text;
            inHoaDon.TongTien = txbTongTien.Text;
            inHoaDon.DaDatCoc = txbTienCoc.Text;
            inHoaDon.TongThu = txbTienPhaiTra.Text;
            inHoaDon.NgayThanhToan = dtpNgayThanhToan.Text;
            inHoaDon.ShowDialog();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
