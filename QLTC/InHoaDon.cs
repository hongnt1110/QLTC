using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class InHoaDon : Form
    {

        public string MaHD, MaPhieu, TongTien, DaDatCoc,TongThu, NgayThanhToan;


        public InHoaDon()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Print(panelPrint);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = panel;
            GetPrintArea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryIMG;
        private void GetPrintArea(Panel panel)
        {
            memoryIMG = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryIMG, new Rectangle(0, 0, panel.Width, panel.Height));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryIMG, (pageArea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }
        private void InHoaDon_Load(object sender, EventArgs e)
        {
            txbMaHD.Text = MaHD;
            txbMaPhieu.Text = MaPhieu;
            txbTongTien.Text = TongTien;
            txbDaDatCoc.Text = DaDatCoc;
            txbTongThu.Text = TongThu;
            lbNgayThanhToan.Text = NgayThanhToan;
        }

    }
}
