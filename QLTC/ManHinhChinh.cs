using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class ManHinhChinh : Form
    {
        public ManHinhChinh()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog ();
            }
        }
        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BaoCaoDoanhThu add = new BaoCaoDoanhThu();
            add.ShowDialog();
        }
        private void ManHinhChinh_Load(object sender, EventArgs e)
        {

        }
        private void sảnhCướiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDichVu quanLyDichVu = new QuanLyDichVu(0);
            quanLyDichVu.ShowDialog();
        }
        private void thựcĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDichVu quanLyDichVu = new QuanLyDichVu(1);
            quanLyDichVu.ShowDialog();
        }

        private void dịchVụKhácToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDichVu quanLyDichVu = new QuanLyDichVu(2);
            quanLyDichVu.ShowDialog();
        }

        private void đặtTiệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuDatTiec pdt = new PhieuDatTiec();
            pdt.ShowDialog();
        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon hoaDon = new HoaDon();
            hoaDon.ShowDialog();
        }
        private void traCứuHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuHoaDon tc = new TraCuuHoaDon();
            tc.ShowDialog();
        }

        private void traCứuTiệcCướiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            TraCuuTiecCuoi tc = new TraCuuTiecCuoi();
            tc.ShowDialog();
        }

        private void caToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDichVu quanLyDichVu = new QuanLyDichVu(3);
            quanLyDichVu.ShowDialog();
        }
    }
}
