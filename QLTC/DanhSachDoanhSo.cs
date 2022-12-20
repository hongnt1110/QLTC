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
    public partial class DanhSachDoanhSo : Form
    {
        public DanhSachDoanhSo()
        {
            InitializeComponent();
        }

        private void DanhSachDoanhSo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDichVu.DOANHSO' table. You can move, or remove it, as needed.
            this.dOANHSOTableAdapter.Fill(this.dataDichVu.DOANHSO);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                this.Hide();
                BaoCaoDoanhThu bc = new BaoCaoDoanhThu();
                bc.ShowDialog();
            }
        }
    }
}
