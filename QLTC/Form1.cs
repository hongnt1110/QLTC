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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatkhau quenMatkhau = new QuenMatkhau();
            quenMatkhau.ShowDialog();
        }
        Modify modify = new Modify();
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tentk = textTenTaiKhoan.Text;
            string matkhau = textMatKhau.Text;
            if(tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '" + tentk + "' and MatKhau = '"+matkhau+"'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }   
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }    
        
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
