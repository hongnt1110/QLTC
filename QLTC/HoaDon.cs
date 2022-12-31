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



        private void btnIn_Click(object sender, EventArgs e)
        {
            InHoaDon inHoaDon= new InHoaDon();
            inHoaDon.Enabled= true;
           
            inHoaDon.MaPhieu = txbSLB.Text;
            inHoaDon.TongTien = txbDonGiaBan.Text;
            inHoaDon.DaDatCoc = txbTienSanh.Text;
            inHoaDon.TongThu = txbTienHoaDon.Text;
            inHoaDon.NgayThanhToan = dtpNgayThanhToan.Text;
            inHoaDon.ShowDialog();
           
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                this.Hide();
                ManHinhChinh main = new ManHinhChinh();
                main.ShowDialog();
            }
        }
        private void IndicateFood()
        {
            if (txbMaPhieu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt tiệc!");
            }    
            else
            {
                // hiện thức ăn
                DataTable foodList = new DataTable();
                string foodConnectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(foodConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select MONAN.TenMonAn, MONAN.DonGia from CT_MONAN, MONAN, PHIEUDATTIEC where CT_MONAN.MaPhieuDT = PHIEUDATTIEC.MaPhieuDT and CT_MONAN.MaMonAn=MONAN.MaMonAn and PHIEUDATTIEC.MaPhieuDT=" + txbMaPhieu.Text + "", connection))
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        foodList.Load(reader);
                        connection.Close();
                    }
                }
                dgvHDMonAn.DataSource= foodList;
         
               
            }
 
           
        }
        private void IndicateService()
        {
            if (txbMaPhieu.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đặt tiệc!");
            }
            else
            {
                DataTable serviceList = new DataTable();
                string serviceConnectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(serviceConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select DICHVU.TenDichVu, DICHVU.DonGia from CT_DICHVU, MONAN, PHIEUDATTIEC,DICHVU where CT_DICHVU.MaPhieuDT = PHIEUDATTIEC.MaPhieuDT and CT_DICHVU.MaDichVu=DICHVU.MaDichVu and PHIEUDATTIEC.MaPhieuDT=" + txbMaPhieu.Text + "", connection))
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        serviceList.Load(reader);
                        connection.Close();
                    }
                }
                dgvDichVu.DataSource = serviceList;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IndicateFood();
            IndicateService();
            CalculateFoodTotalPrice();
            // CalculateServiceTotalPrice();
            GetInformationOfPHIEUDATTIEC();
            int sum = TinhTongTienBan();
            txbTongTienBan.Text = sum.ToString();

            
        }
        private void CalculateFoodTotalPrice()
        {
            if (dgvHDMonAn.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < dgvHDMonAn.Rows.Count; i++)
                {
                    sum = sum+ double.Parse(dgvHDMonAn.Rows[i].Cells[1].Value.ToString());
                }
                lbTongTienMA.Text = sum.ToString();
            }
        }
        private void CalculateServiceTotalPrice()
        {
            if (dgvDichVu.DataSource == null)
            {
                MessageBox.Show("Chưa có dữ liệu");
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < dgvDichVu.Rows.Count; i++)

                {
                    sum = sum + double.Parse(dgvDichVu.Rows[i].Cells[2].Value.ToString());
                }
                lbTTDV.Text = sum.ToString();
            }
        }

        private void txbSLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txbDonGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txbTongTienBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void txbMaPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void GetInformationOfPHIEUDATTIEC()
        {
            DataTable serviceList = new DataTable();
            string serviceConnectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(serviceConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select *from PHIEUDATTIEC where PHIEUDATTIEC.MaPhieuDT=" + txbMaPhieu.Text + "", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while(reader.Read())
                    {
                        txbChuRe.Text = reader.GetString(2);
                        txbCoDau.Text = reader.GetString(3);
                        txbSLB.Text = reader.GetValue(6).ToString();
                        txbTienCoc.Text = reader.GetValue(5).ToString();
                    }
                    connection.Close();
                }
            }

        }

        private int TinhTongTienBan()
        {
            int sum = 0;
            sum = int.Parse(txbSLB.Text) * int.Parse(txbDonGiaBan.Text);
            if( int.Parse(txbDonGiaBan.Text) == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số lượng bàn và giá bàn!");
                sum = int.Parse(txbSLB.Text) * int.Parse(txbDonGiaBan.Text);
            }
            return sum;
        }
        private int TinhTongTienHoaDon()
        {
            int tienban = TinhTongTienBan();
            int tienSanh = int.Parse(txbTienSanh.Text);
            int tienMonAn = int.Parse(lbTongTienMA.Text);
            int tienDichVu = int.Parse(lbTTDV.Text);
            return tienban + tienSanh + tienMonAn + tienDichVu;
        }
        private double TienCoc()
        {
            return double.Parse(txbTienCoc.Text);
        }
      

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TinhTienConLai();
        }
        private double TienPhat()
        {
            return double.Parse(txbTienPhat.Text);
        }
        private void rbtnCo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCo.Checked == false)
            {
                txbTienPhat.Text = "0";
            }
            else
            {
                int tienGoc = TinhTongTienHoaDon();
                tienGoc = tienGoc / 100;
                txbTienPhat.Text = tienGoc.ToString();
            }
        }
        private void TinhTienConLai()
        {
            txbTienHoaDon.Text = TinhTongTienHoaDon().ToString();
            txbTienPhat.Text = TienPhat().ToString();
            double tienConLai = TinhTongTienHoaDon() - TienPhat() - TienCoc();
            txbConLai.Text = tienConLai.ToString();
        }
    }
}
