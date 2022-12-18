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
            dgvThucAn.AutoGenerateColumns = false;
            dgvDichVu.AutoGenerateColumns=false;
            txbChuRe.Text = "";
            txbCodau.Text = "";
            cbbMaCa.Text = "";
            txbMaKhachHang.Text = "";
            txbGiaBan.Text = "";
            cbbSanh.Text = "";
            txbSLBan.Text = "";
            txbTienCoc.Text = "";
        }
        #region Sự kiện các button
        private void btnLuu_Click(object sender, EventArgs e) // lưu thông tin xuống db
        {
            if (dgvDichVu.Rows.Count <=1 || dgvThucAn.Rows.Count <= 1 
                ||txbChuRe.Text == string.Empty || txbCodau.Text == string.Empty
                || txbGiaBan.Text == string.Empty || txbMaKhachHang.Text == string.Empty
                || txbGiaBan.Text == string.Empty || txbSLBan.Text == string.Empty || txbTienCoc.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đặt tiện");
            }    
            else
            {
                var informMessage = MessageBox.Show("Bạn muốn lưu phiếu đặt tiệc với các thông tin này chứ","Phiếu đặt tiệc",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (informMessage == DialogResult.Yes)
                {

                    AddPartyBooking();
                    AddingIntoCT_MonAn();
                    AddingIntoCT_DichVu();
                    MessageBox.Show("Đã lưu thành công!");
                    // Sau khi nhấn ok của message box sẽ hiển thị thông tin phiếu đặt tiệc ra màn hình
                    DisableInforEdition(); // hiển thị thông tin cá nhân
                    IndicateFoodDetail(); // hiển thị chi tiết món ăn
                    IndicateServiceDetail(); // hiển thị chi tiết dịch vụ
                    //Reset();
                }               
                
            }    
            
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
        #endregion




        #region Lưu phiếu đặt tiệc
        private void AddPartyBooking()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            // thêm phiết đặt tiệc
            string query = "insert into PHIEUDATTIEC values (" + txbMaKhachHang.Text + ",'" + dateTimePicker1.Value + "', N'" + txbChuRe.Text + "',N'" + txbCodau.Text + "', " + ChangeNameHallToHallID(cbbSanh.Text) + ", " + txbTienCoc.Text + ", "+txbSLBan.Text+","+cbbMaCa.Text+","+txbGiaBan.Text+")";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();

            // hiện mã phiếu
            connection.Open();
            string queryShow = "select MaPhieuDT from PHIEUDATTIEC where MaKH = '" + txbMaKhachHang.Text + "' and NgayDaiTiec = '" + dateTimePicker1.Value + "' and TenChuRe = '" + txbChuRe.Text + "' and TenCoDau = '" + txbCodau.Text + "' and MaSanh = '" + ChangeNameHallToHallID(cbbSanh.Text) + "' and TienCoc = " + txbTienCoc.Text + " and SoLuongBan = '" + txbSLBan.Text + "' and MaCa = '" + cbbMaCa.Text + "' and GiaBan = '" + txbGiaBan.Text + "'";
            SqlCommand commandShow = new SqlCommand(queryShow, connection);
            SqlDataReader dr = commandShow.ExecuteReader();
            while (dr.Read())
            {
                txbMaPhieu.Text = dr.GetValue(0).ToString();
                
            }
            dr.Close();
            commandShow.ExecuteNonQuery();
            connection.Close();
        }
        private void AddingIntoCT_MonAn()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = null;
            
            // Thêm vào chi tiết món ăn
            if (dgvThucAn.Rows.Count > 0) 
            {
       
                for (int i = 0; i < dgvThucAn.Rows.Count - 1;i++)
                {
                   connection.Open();
                   query = "insert into CT_MONAN (MaMonAn, MaPhieuDT) values (" + int.Parse(dgvThucAn.Rows[i].Cells[0].Value.ToString()) + ","+ int.Parse(txbMaPhieu.Text)+")";
                   SqlCommand command = new SqlCommand(query, connection);
                   command.ExecuteNonQuery();
                   connection.Close();
                } 
            }
        }

        private void AddingIntoCT_DichVu()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string query = null;
            
            // Thêm vào chi tiết dịch vụ
            if (dgvDichVu.Rows.Count > 0)
            {

                for (int i = 0; i < dgvDichVu.Rows.Count - 1; i++)
                {
                    connection.Open();
                    query = "insert into CT_DICHVU (MaDichVu,SoLuong, MaPhieuDT) values (" + int.Parse(dgvDichVu.Rows[i].Cells[0].Value.ToString()) + ","+int.Parse(dgvDichVu.Rows[i].Cells[2].Value.ToString())+"," + int.Parse(txbMaPhieu.Text) + ")";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        #endregion


        #region Hiển thị thông tin phiếu đặt
        private void IndicateServiceDetail()
        {
            DataTable billList = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select DICHVU.MaDichVu, DICHVU.TenDichVu, SoLuong from DICHVU, CT_DICHVU where CT_DICHVU.MaPhieuDT = '" + txbMaPhieu.Text + "' and CT_DICHVU.MaDichVu = DICHVU.MaDichVu", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    billList.Load(reader);
                    connection.Close();
                }

            }
            dgvDichVu.DataSource = billList;
            dgvDichVu.Enabled = false;
        }

        private void IndicateFoodDetail()
        {
            DataTable billList = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select MONAN.MaMonAn, MONAN.TenMonAn, DonGia from MONAN, CT_MONAN where CT_MONAN.MaPhieuDT = '" + txbMaPhieu.Text + "' and CT_MONAN.MaMonAn = MONAN.MaMonAn", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    billList.Load(reader);
                    connection.Close();
                }

            }          
            dgvThucAn.DataSource = billList;
            dgvThucAn.Enabled = false;

        }

        private void DisableInforEdition()
        {
  
             txbMaKhachHang.Enabled = false; 
             dateTimePicker1.Enabled = false; 
             txbChuRe.Enabled = false; 
             txbCodau.Enabled = false;
             cbbSanh.Enabled = false; 
             txbTienCoc.Enabled = false; 
             txbSLBan.Enabled = false; 
             cbbMaCa.Enabled = false;
             txbGiaBan.Enabled = false; 
       
            
        }
        #endregion

        #region In phiếu đặt tiệc
        #endregion
        #region Hàm thành phàn
        private static string ChangeNameHallToHallID(string hallName)
        {
            switch (hallName)
            {
                case "Rose":
                    return "1";
                case "Tulip":
                    return "2";
                case "Purple":
                    return "3";
                case "Pink":
                    return "4";
                case "Red":
                    return "5";
                default:
                    MessageBox.Show("Khong hop le");
                    return "0";
            }
            
        }
        private void Reset()
        {
            ClearTool();
            SetEnable();
            // clear dgvDichvu
            var ddv = dgvDichVu.DataSource as DataTable;
            ddv.Rows.Clear();
            dgvDichVu.DataSource = ddv;

            //clear dgcThucAn
            var dma = dgvThucAn.DataSource as DataTable;
            dma.Rows.Clear();
            dgvDichVu.DataSource = dma;
        }
        private void ClearTool()
        {
            txbChuRe.Text = string.Empty;
            txbCodau.Text = string.Empty;
            cbbMaCa.Text = string.Empty;
            txbMaKhachHang.Text = string.Empty;
            txbGiaBan.Text = string.Empty;
            cbbSanh.Text = string.Empty;
            txbSLBan.Text = string.Empty;
            txbTienCoc.Text = string.Empty;
            txbMaPhieu.Text = string.Empty;
        }
        private void SetEnable()
        {
            txbChuRe.Enabled = true;
            txbCodau.Enabled = true;
            cbbMaCa.Enabled = true;
            txbMaKhachHang.Enabled = true;
            txbGiaBan.Enabled = true;
            cbbSanh.Enabled = true;
            dateTimePicker1.Enabled = true;
            txbSLBan.Enabled = true;
            txbTienCoc.Enabled = true;
            txbMaPhieu.Enabled = true;
        }
        #endregion


    }
}
