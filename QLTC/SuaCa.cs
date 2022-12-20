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
    public partial class SuaCa : Form
    {
        private string _ma;
        private string _ten;
        private string _tg;
        public SuaCa()
        {
            InitializeComponent();
        }
        public SuaCa(string ma, string ten, string tg) : this()
        {
            _ma = ma;
            _ten = ten;
            _tg = tg;
            maCa.Text = _ma;
            tenCa.Text = _ten;
            thoiGianCa.Text = _tg;
            maCa.Enabled = false;
        }
        DataDichVuTableAdapters.CATableAdapter ListCa = new DataDichVuTableAdapters.CATableAdapter();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Có muốn lưu thay đổi ca không?", "Xác nhận lưu sảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                ListCa.UpdateCa(tenCa.Text, thoiGianCa.Text, int.Parse(maCa.Text));
                MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK);
                this.Hide();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
