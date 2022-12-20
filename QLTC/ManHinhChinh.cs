﻿using System;
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

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuanLyDichVu quanLyDichVu = new QuanLyDichVu();
            quanLyDichVu.ShowDialog();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu add = new BaoCaoDoanhThu();
            add.ShowDialog();
        }

        private void sảnhCướiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //QuanLyDichVu quanLyDichVu = new QuanLyDichVu(2);
            //quanLyDichVu.ShowDialog();
        }

        private void ManHinhChinh_Load(object sender, EventArgs e)
        {

        }

        private void lậpBáoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu add = new BaoCaoDoanhThu();
            add.ShowDialog();
        }
    }
}
