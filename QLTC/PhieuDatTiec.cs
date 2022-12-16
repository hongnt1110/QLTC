using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLTC
{
    public partial class PhieuDatTiec : Form
    {
        public PhieuDatTiec()
        {
            InitializeComponent();
            txbChuRe.Text = "";
            txbCoDau.Text = "";
            txbMaCa.Text = "";
            txbMaKhachHang.Text = "";
            txbMaPhieu.Text = "";
            txbSanh.Text = "";
            txbSLBan.Text = "";
            txbTienCoc.Text = "";
        }

        
        private void PhieuDatTiec_Load(object sender, EventArgs e)
        {
            dgvPhieuDacTiec.DataSource = GetPartyBookingFormList();
        }

        private DataTable GetPartyBookingFormList()
        {
            DataTable  partyBooking = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select *from PHIEUDATTIEC", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    partyBooking.Load(reader);
                }    
            }    
            return partyBooking;
        }

        private void Reset()
        {
            txbChuRe.Text = string.Empty;
            txbCoDau.Text = string.Empty;
            txbMaCa.Text = string.Empty;
            txbMaKhachHang.Text = string.Empty;
            txbMaPhieu.Text = string.Empty;
            txbSanh.Text = string.Empty;
            txbSLBan.Text = string.Empty;
            txbTienCoc.Text = string.Empty;
        }

        private void dgvPhieuDacTiec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0)
            {
                txbMaPhieu.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[0].Value.ToString();
                txbMaKhachHang.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[1].Value.ToString();
                txbNgayDaiTiec.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[2].Value.ToString();
                txbChuRe.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[3].Value.ToString();
                txbCoDau.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[4].Value.ToString();
                txbSanh.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[5].Value.ToString();
                txbTienCoc.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[6].Value.ToString();
                txbSLBan.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[7].Value.ToString();
                txbMaCa.Text = dgvPhieuDacTiec.SelectedRows[0].Cells[8].Value.ToString();
            }    
        }
    }
}
