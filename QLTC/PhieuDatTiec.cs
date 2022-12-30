using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace QLTC
{
    public partial class PhieuDatTiec : Form
    {
        public PhieuDatTiec()
        {
            InitializeComponent();
            btnInPhieu.Enabled = false;
            txbChuRe.Text = "";
            txbCodau.Text = "";
            cbbMaCa.Text = "";
            txbGiaBan.Text = "";
            cbbSanh.Text = "";
            txbSLBan.Text = "";
            txbTienCoc.Text = "";
        }
        #region Lưu phiếu đặt tiệc
        DataDichVuTableAdapters.PHIEUDATTIECTableAdapter Phieu = new DataDichVuTableAdapters.PHIEUDATTIECTableAdapter();
        private void AddPartyBooking()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            int maSanh = int.Parse(cbbSanh.SelectedValue.ToString());
            int maCa = int.Parse(cbbMaCa.SelectedValue.ToString());
            int sl = int.Parse(txbSLBan.Text);
            decimal tien = decimal.Parse(tienCoc.Text);
            connection.Close();
            connection.Open();
            Phieu.InsertPhieuDT(dateTimePicker1.Value.ToString(), txbChuRe.Text, txbCodau.Text, maSanh, tien, sl, maCa);
        }
        private void AddingIntoCT_MonAn()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Select MAX(MaPhieuDT) FROM PHIEUDATTIEC";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader rd = command.ExecuteReader();
            rd.Read();
            int maPhieuDT = int.Parse(rd[0].ToString());
            string maMonAn;
                 for (int i = 0; i < listMonAn.Items.Count - 1; i++)
                 {
                    
                    connection.Close();
                    if (listMonAn.Items[i].Checked)
                        {
                             maMonAn = listMonAn.Items[i].SubItems[2].Text;
                             connection.Open();
                             query = "insert into CT_MONAN (MaMonAn, MaPhieuDT) values (" + maMonAn + ","+ maPhieuDT+")";
                             command = new SqlCommand(query, connection);
                             command.ExecuteNonQuery();
                             connection.Close();
                        }
             }
        }

        private void AddingIntoCT_DichVu()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Select MAX(MaPhieuDT) FROM PHIEUDATTIEC";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader rd = command.ExecuteReader();
            rd.Read();
            int maPhieuDT = int.Parse(rd[0].ToString());
            string maDichVu;
            for (int i = 0; i < listDichVu.Items.Count - 1; i++)
            {

                connection.Close();
                if (listDichVu.Items[i].Checked)
                {
                    maDichVu = listDichVu.Items[i].SubItems[2].Text;
                    connection.Open();
                    query = "insert into CT_DICHVU (MaDichVu, MaPhieuDT) values (" + maDichVu + "," + maPhieuDT + ")";
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
        #endregion


        #region Hiển thị thông tin phiếu đặt
        private void IndicateServiceDetail()
        {
            //DataTable billList = new DataTable();
            //string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("select DICHVU.MaDichVu, DICHVU.TenDichVu, SoLuong from DICHVU, CT_DICHVU where CT_DICHVU.MaPhieuDT = '" + txbMaPhieu.Text + "' and CT_DICHVU.MaDichVu = DICHVU.MaDichVu", connection))
            //    {
            //        connection.Open();
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        billList.Load(reader);
            //        connection.Close();
            //    }

            //}
            //dgvDichVu.DataSource = billList;


        }

        private void IndicateFoodDetail()
        {

            //DataTable billList = new DataTable();
            //string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("select MONAN.MaMonAn, MONAN.TenMonAn, DonGia from MONAN, CT_MONAN where CT_MONAN.MaPhieuDT = '" + txbMaPhieu.Text + "' and CT_MONAN.MaMonAn = MONAN.MaMonAn", connection))
            //    {
            //        connection.Open();
            //        SqlDataReader reader = cmd.ExecuteReader();
            //        billList.Load(reader);
            //        connection.Close();
            //    }

            //}          
            //dgvThucAn.DataSource = billList;

        }

        private void DisableInforEdition()
        {
            dateTimePicker1.Enabled = false;
            txbChuRe.Enabled = false;
            txbCodau.Enabled = false;
            cbbSanh.Enabled = false;
            txbTienCoc.Enabled = false;
            txbSLBan.Enabled = false;
            cbbMaCa.Enabled = false;
        }
        #endregion
        private void cbbSanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        DataDichVuTableAdapters.MONANTableAdapter monAn = new DataDichVuTableAdapters.MONANTableAdapter();
        private void PhieuDatTiec_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDichVu.DICHVU' table. You can move, or remove it, as needed.
            this.dICHVUTableAdapter.Fill(this.dataDichVu.DICHVU);
            // TODO: This line of code loads data into the 'dataDichVu.MONAN' table. You can move, or remove it, as needed.
            this.mONANTableAdapter.Fill(this.dataDichVu.MONAN);
            // TODO: This line of code loads data into the 'dataDichVu.CA' table. You can move, or remove it, as needed.
            this.cATableAdapter.Fill(this.dataDichVu.CA);
            // TODO: This line of code loads data into the 'dataDichVu.SANH' table. You can move, or remove it, as needed.
            this.sANHTableAdapter.Fill(this.dataDichVu.SANH);

            DataTable billList = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select TenMonAn,DonGia,MaMonAn from MONAN", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader[0].ToString());
                        lv.SubItems.Add(reader[1].ToString());
                        lv.SubItems.Add(reader[2].ToString());
                        listMonAn.Items.Add(lv);
                    }
                    connection.Close();
                }
                using (SqlCommand cmd = new SqlCommand("select TenDichVu,DonGia,MaDichVu from DICHVU", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ListViewItem lv = new ListViewItem(reader[0].ToString());
                        lv.SubItems.Add(reader[1].ToString());
                        lv.SubItems.Add(reader[2].ToString());
                        listDichVu.Items.Add(lv);
                    }
                    connection.Close();
                }
            }
        }

        private void listToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mONANTableAdapter.List(this.dataDichVu.MONAN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnInPhieu_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "Select MAX(MaPhieuDT) AS MaPhieu FROM PHIEUDATTIEC";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader rd = command.ExecuteReader();
            rd.Read();
            string maPhieuDT = rd[0].ToString();
            InPhieuDatTiec inPhieu = new InPhieuDatTiec(maPhieuDT,txbChuRe.Text, txbCodau.Text, cbbSanh.Text, txbSLBan.Text, txbTienCoc.Text, dateTimePicker1.Text, cbbMaCa.Text);
            inPhieu.ShowDialog();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            int tempMonAn = 0;
            for (int i = 0; i < listMonAn.Items.Count - 1; i++)
            {
                if (listMonAn.Items[i].Checked)
                {
                    tempMonAn++;
                }
            }
            if (txbChuRe.Text == string.Empty || txbCodau.Text == string.Empty || tienCoc.Text == string.Empty || txbSLBan.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để đặt tiệc");
            }
            else if (tempMonAn < 1)
            {
                MessageBox.Show("Hãy chọn món ăn !!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                //string test;
                //string query = "Select * FROM PHIEUDATTIEC WHERE NgayDaiTiec = '" + dateTimePicker1.Text.ToString() + "' AND MaSanh = " + cbbSanh.SelectedValue.ToString() + "AND MaCa = " + cbbMaCa.SelectedValue.ToString();
                //string connectionString = @"Data Source=LUAN-LENOVO\LUANNGUYEN;Initial Catalog=QLTC;Integrated Security=True";
                //SqlConnection connection = new SqlConnection(connectionString);
                //SqlCommand cmd = new SqlCommand(query, connection);
                //connection.Open();
                //SqlDataReader reader = cmd.ExecuteReader();
                //reader.Read();
                //if(reader[0].ToString() != null)
                //{
                //    test = null;
                //}
                //else
                //{
                //    test = reader[0].ToString();
                //}

                //connection.Close();
                //if (test != null)
                //{
                //    MessageBox.Show("Lịch đã tồn tại !!!", "Phiếu đặt tiệc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                
                var informMessage = MessageBox.Show("Bạn muốn lưu phiếu đặt tiệc với các thông tin ?", "Phiếu đặt tiệc", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (informMessage == DialogResult.Yes)
                {

                    AddPartyBooking();
                    AddingIntoCT_MonAn();
                    AddingIntoCT_DichVu();
                    MessageBox.Show("Đã lưu thành công!", "Thành Công", MessageBoxButtons.OK);
                    btnInPhieu.Enabled = true;
                }
                
               }
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

        private void txbSLBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void tienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }

        private void soDienThoaiKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Vui lòng chỉ nhập số", "THÔNG BÁO", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
