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
    public partial class ThemCa : Form
    {
        public ThemCa()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.CATableAdapter ListCa = new DataDichVuTableAdapters.CATableAdapter();
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tenCa.Text == "Nhập tên ca")
            {
                MessageBox.Show("Vui lòng nhập tên ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (thoiGianCa.Text == "Nhập thời gian ca (vd: 9H00 - 12H00)")
            {
                MessageBox.Show("Vui lòng nhập thời gian ca", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ListCa.InsertCa(tenCa.Text, thoiGianCa.Text);
                MessageBox.Show("Thêm " + tenCa.Text + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
