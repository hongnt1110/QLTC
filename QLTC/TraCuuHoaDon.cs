using QLTC.AdminChildForm;
using System;
using System.Collections;
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
    public partial class TraCuuHoaDon : Form
    {
        public TraCuuHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                this.Hide();
                Form frm = new ManHinhChinh();
                frm.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuHoaDon.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewTraCuuHoaDon.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr3 = "Delete from HoaDon where HoaDon.id='" + a + "'";
                provider.ExecuteDelete(deletedStr3);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = @"Select h.id, h.MaHoaDon,t.MaDatTiec,p.MaKhachhang, p.TenKhachHang, s.DonGiaToiThieu as TienSanh, dv.GiaDichVu, td.GiaThucDon, h.TienPhat, h.TienCoc, h.TongTienHoaDon ,h.TienConLai
              from HoaDon h left join ThongTinKhachHang p on p.id = h.IDThongTinKhachHang
              left join ThongTinDatTiec t on t.id = h.IdMaDatTiec
              left join ThongTinSanh s on s.id = h.IdLoaiSanh
              left join DichVu dv on dv.id = h.IdDichVu
              left join ThucDon td on td.id = h.IdThucDon";
                dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            if (radioButtonMaHD.Checked)
            {

                dataGridViewTraCuuHoaDon.DataSource = hoaDon.SearchMaHD(int.Parse(textBoxTimHoaDon.Text));
            }
            else if (radioButtonNgay.Checked)
            {
                dataGridViewTraCuuHoaDon.DataSource = hoaDon.SearchNgay(textBoxTimHoaDon.Text);
            }
            else
            {
                MessageBox.Show("Hãy chọn kiểu tra cứu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        DataDichVuTableAdapters.HOADONTableAdapter hoaDon = new DataDichVuTableAdapters.HOADONTableAdapter();
        private void buttonXem_Click(object sender, EventArgs e)
        {
            //string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    using (SqlCommand cmd = new SqlCommand("select HOADON.MaHoaDon, HOADON.MaPhieuDT,HOADON.NgayThanhToan, HOADON.TienConLai,HOADON.TongTienHD,PHIEUDATTIEC.TienCoc from PHIEUDATTIEC, HOADON where PHIEUDATTIEC.MaPhieuDT = HOADON.MaPhieuDT", connection))
            //    {
            //        connection.Open();
            //        DataProvider provider = new DataProvider();
            //        dataGridViewTraCuuHoaDon.DataSource = provider.ExecuteQuery(connectionString);
            //        SqlDataReader rd = cmd.ExecuteReader();
            //        connection.Close();
            //    }
            //}
            dataGridViewTraCuuHoaDon.DataSource = hoaDon.ListHoaDon();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {

        }

        private void TraCuuHoaDon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTraCuuHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewTraCuuHoaDon_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonTenKH_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
