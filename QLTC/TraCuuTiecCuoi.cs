﻿using QLTC.AdminChildForm;
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
            this.Hide();
            Form frm = new ManHinhChinh();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string valueFilter = textBoxTiecCuoi.Text.ToString().Trim();
            string fieldFilter = "MaKhachHang";
            if (radioButtonMaDatTiec.Checked)
            {
                fieldFilter = "TenKhachHang";
            }

            string query1 = "Select a.*, p.*from ThongTinDatTiec a inner join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang where " + fieldFilter + " like '%" + valueFilter + "%'";
            Console.Write(query1);
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuTiecCuoi.DataSource = provider.ExecuteQuery(query1);
      
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuTiecCuoi.CurrentCell.RowIndex;
                string a = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[0].Value.ToString());
                string deletedStr1 = "Delete from ThongTinDatTiec where ThongTinDatTiec.id='" + a + "'";
                provider.ExecuteDelete(deletedStr1);
                string deletedStr2 = "Delete from ThongTinKhachHang where ThongTinKhachHang.id='" + a + "'";
                Console.Write(deletedStr1);
                Console.Write(deletedStr1);
                provider.ExecuteDelete(deletedStr2);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                string query = "Select a.*, p.*from ThongTinDatTiec a inner join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang";
                dataGridViewTraCuuTiecCuoi.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã xóa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            catch
            {
                MessageBox.Show("Lỗi, không xóa được");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {

                DataProvider provider = new DataProvider();
                int CurrentIndex = dataGridViewTraCuuTiecCuoi.CurrentCell.RowIndex;
                string ID = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[0].Value.ToString().Trim());
                string madattiec = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[1].Value.ToString().Trim().Trim());
                string idNhanVien = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[2].Value.ToString().Trim().Trim());
                string idThongTinKhachHang = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[3].Value.ToString().Trim().Trim());
                string IdLoaiSanh = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[4].Value.ToString().Trim().Trim());
                string IdDichVu = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[5].Value.ToString().Trim());
                string IdThucDon = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[6].Value.ToString().Trim());
                string soluongnhanvien = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[7].Value.ToString().Trim());
                string soluongban = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[8].Value.ToString().Trim());
                //string trangthai = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[9].Value.ToString().Trim());
                string ca = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[9].Value.ToString().Trim());


                string id = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[10].Value.ToString().Trim());
                string makhachhang = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[11].Value.ToString().Trim());
                string ngaylap = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[12].Value.ToString().Trim());
                string tenkhachhang = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[13].Value.ToString().Trim());
                string tenchure = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[14].Value.ToString().Trim());
                string tencodau = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[15].Value.ToString().Trim());
                string diachi = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[16].Value.ToString().Trim());
                string dienthoai = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[17].Value.ToString().Trim());
                string email = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[18].Value.ToString().Trim());
                string ngaytochuc = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[19].Value.ToString().Trim());
                string tiencoc = Convert.ToString(dataGridViewTraCuuTiecCuoi.Rows[CurrentIndex].Cells[20].Value.ToString().Trim());

                string updateStr1 = "Update ThongTinKhachHang set NgayLap='"
                   + ngaylap + "',TenKhachHang='"
                   + tenkhachhang + "',TenChuRe='"
                   + tenchure + "', TenCoDau='"
                   + tencodau + "', DiaChi='"
                   + diachi + "',DienThoai='"
                   + dienthoai + "', Email='"
                   + email + "', NgayToChuc='"
                   + ngaytochuc + "', TienCoc='"
                   + tiencoc+"'where ThongTinKhachHang.id = '" + id + "'";
                provider.ExecuteUpdate(updateStr1);

                string updateStr2 = "Update ThongTinDatTiec set SoLuongNhanVien='"
                   + soluongnhanvien + "',SoLuongBan='"
                   + soluongban + "', Ca='"
                   + ca +"' where ThongTinDatTiec.id = '" + ID + "'";
                //Console.WriteLine(updateStr2);
                provider.ExecuteUpdate(updateStr2);
               // string query = "Select a.*, p.*from ThongTinDatTiec a inner join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang";
                //dataGridViewTraCuuHopDong.DataSource = provider.ExecuteQuery(query);
                MessageBox.Show("Bạn đã sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
            catch(Exception err)
            {
                Console.WriteLine(err.ToString());
                MessageBox.Show("Lỗi, không sửa được");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "Select a.*, p.*from ThongTinDatTiec a left join ThongTinKhachHang p on p.id = a.IDThongTinKhachHang";
            DataProvider provider = new DataProvider();
            dataGridViewTraCuuTiecCuoi.DataSource = provider.ExecuteQuery(query);
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
    }
}
