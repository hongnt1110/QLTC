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
    public partial class DanhSachCa : Form
    {
        public DanhSachCa()
        {
            InitializeComponent();
        }
        DataDichVuTableAdapters.CATableAdapter ListCa = new DataDichVuTableAdapters.CATableAdapter();
        private void btnTimCa_Click(object sender, EventArgs e)
        {
            if (timCa.Text == "Tìm kiếm theo tên ca")
            {
                MessageBox.Show("Vui lòng nhập tên ca để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                listCa.DataSource = ListCa.SearchCa('%' + timCa.Text + '%');
            }
        }
        private void btnHienThiCa_Click(object sender, EventArgs e)
        {
            listCa.DataSource = ListCa.ListCa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                this.Hide();
                PhieuDatTiec ql = new PhieuDatTiec();
                ql.ShowDialog();
            }
        }

        private void btnThemCa_Click(object sender, EventArgs e)
        {
            ThemCa ca = new ThemCa();
            ca.ShowDialog();
            listCa.DataSource = ListCa.ListCa();
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if (listCa.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn ca để xóa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listCa.DataSource = ListCa.ListCa();
            }
            else
            {
                int ca = int.Parse(listCa.CurrentRow.Cells[0].Value.ToString());
                DialogResult xacNhan = MessageBox.Show("Có muốn xóa ca không?", "Xác nhận xóa ca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (xacNhan == DialogResult.Yes)
                {
                    ListCa.DeleteCa(ca);
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                    listCa.DataSource = ListCa.ListCa();
                }
            }
        }

        private void btnSuaCa_Click(object sender, EventArgs e)
        {
            if (listCa.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn ca để sửa?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listCa.DataSource = ListCa.ListCa();
            }
            else
            {
                string ma = listCa.CurrentRow.Cells[0].Value.ToString();
                string ten = listCa.CurrentRow.Cells[1].Value.ToString();
                string tg = listCa.CurrentRow.Cells[2].Value.ToString();
                SuaCa suaCa = new SuaCa(ma, ten, tg);
                suaCa.ShowDialog();
                listCa.DataSource = ListCa.ListCa();
            }
        }
    }
}
