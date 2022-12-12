using FontAwesome.Sharp;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using System.Drawing;
using Color = System.Drawing.Color;
using System;
using QLTC.AdminChildForm;

namespace QLTC
{
    public partial class AdminDashboard : Form
    {
        private IconButton currentButton;
        private Panel leftBorderButton;
        private Form currentChildForm;
        public AdminDashboard()
        {
            InitializeComponent();
            leftBorderButton = new Panel();
            leftBorderButton.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderButton);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null) 
            {
                DisableButton();
                

                // chọn một nút được chọn bên thanh menu
                currentButton = (IconButton) senderBtn;
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign= ContentAlignment.MiddleRight;          

                // cột thể hiện nút đang chọn (bên trái cùng của nút)
                leftBorderButton.BackColor = color;
                leftBorderButton.Location = new Point(0, currentButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void OpenChildForm(object childForm)
        {
            panelChildForm.Controls.Clear();
            
            Form currentChildForm = childForm as Form;
            currentChildForm.TopLevel = false;
            currentChildForm.FormBorderStyle= FormBorderStyle.None;
            currentChildForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(currentChildForm);
            panelChildForm.Tag= currentChildForm;
            currentChildForm.Show();
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.MidnightBlue;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.MidnightBlue;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


        private void btnTrangChu_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.DarkCyan);
            OpenChildForm(new TrangChuForm());
        }

        private void btnTiecCuoi_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.DarkKhaki);
            OpenChildForm(new TiecCuoiForm());
        }

        private void bthSanh_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.DarkGreen);
            OpenChildForm(new SanhForm());
        }

        private void btnNhanVien_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.DarkMagenta);
            OpenChildForm(new NhanVienForm());
        }

        private void btnKhachHang_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.DarkRed);
            OpenChildForm(new KhachHangForm());
        }

        private void btnHoaDon_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.DarkSlateGray);
            OpenChildForm(new HoaDonForm());
        }

        private void btnReset_Click(object sender, System.EventArgs e)
        {
            ResetAllButton();
        }

        private void ResetAllButton()
        {
            DisableButton();
            leftBorderButton.Visible = false;
        }
    }
}
