using QLTC.AdminChildForm;
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
    public partial class TraCuuTiecCuoi : Form
    {
        public TraCuuTiecCuoi()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                dataGridViewTraCuuTiecCuoi.DataSource = dsPhieu.SearchChuRe(textBoxTiecCuoi.Text);
            }
            else if (radioButton1.Checked)
            {
                dataGridViewTraCuuTiecCuoi.DataSource = dsPhieu.SearchCoDau(textBoxTiecCuoi.Text);
            }
            else if (radioButtonMaDatTiec.Checked)
            {
                dataGridViewTraCuuTiecCuoi.DataSource = dsPhieu.SearchNgayDaiTiec(textBoxTiecCuoi.Text);
            }
            else
            {
                MessageBox.Show("Hãy chọn kiểu tra cứu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //string query1 = "Select a.*, p.*from ThongTinDatTiec a inner join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang where " + fieldFilter + " like '%" + valueFilter + "%'";
            //Console.Write(query1);
            //DataProvider provider = new DataProvider();
            //dataGridViewTraCuuTiecCuoi.DataSource = provider.ExecuteQuery(query1);
        }
        DataDichVuTableAdapters.PHIEUDATTIECTableAdapter dsPhieu = new DataDichVuTableAdapters.PHIEUDATTIECTableAdapter();
        private void button1_Click_1(object sender, EventArgs e)
        {
            //string query = "Select a.*, p.*from ThongTinDatTiec a left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang";
            //DataProvider provider = new DataProvider();
            //dataGridViewTraCuuTiecCuoi.DataSource = provider.ExecuteQuery(query);
            dataGridViewTraCuuTiecCuoi.DataSource = dsPhieu.ListPhieuDT();
        }

        private void radioButtonMaKH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form frm = new PhieuDatTiec();
            frm.ShowDialog();
        }

        private void radioButtonMaDatTiec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TraCuuTiecCuoi_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridViewTraCuuHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
