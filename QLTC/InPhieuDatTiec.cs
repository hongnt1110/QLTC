using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTC
{
    public partial class InPhieuDatTiec : Form
    {
        public string MaKH, ChuRe, CoDau, Sanh, MaPhieu, SoBan, TienCoc, NgayDat, MaCa;

        private void btnXuat_Click(object sender, EventArgs e)
        {
            Print(panelPrint);
        }

        public InPhieuDatTiec()
        {
            InitializeComponent();
        }
        public InPhieuDatTiec(string maphieu, string re, string dau, string sanh, string so, string tien, string ngay, string ca): this()
        {
            lbTenChuRe.Text = re;
            lbTenCoDau.Text = dau;
            lbSanh.Text = sanh;
            lbSLBan.Text = so;
            lbNgayDat.Text = ngay;
            lbMaCa.Text = ca;
            MaPhieu = maphieu;
            IndicateFoodDetail();
            IndicateServiceDetail();
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
        private  void GetPrintArea(Panel panel)
        {
            memoryIMG = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryIMG, new Rectangle(0, 0, panel.Width, panel.Height));
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryIMG, (pageArea.Width/2)-(this.panelPrint.Width/2),this.panelPrint.Location.Y);
        }

        private void InPhieuDatTiec_Load(object sender, EventArgs e)
        {
        }

        private void IndicateServiceDetail()
        {
            DataTable billList = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select DICHVU.MaDichVu, DICHVU.TenDichVu, SoLuong from DICHVU, CT_DICHVU where CT_DICHVU.MaPhieuDT = '" + MaPhieu + "' and CT_DICHVU.MaDichVu = DICHVU.MaDichVu", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    billList.Load(reader);
                    connection.Close();
                }

            }
            dgvCTDV.DataSource = billList;
            dgvCTDV.Enabled = false;
        }

        private void IndicateFoodDetail()
        {
            DataTable billList = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["QLTC.Properties.Settings.QLTCConnectionString"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select MONAN.MaMonAn, MONAN.TenMonAn, DonGia from MONAN, CT_MONAN where CT_MONAN.MaPhieuDT = '" + MaPhieu + "' and CT_MONAN.MaMonAn = MONAN.MaMonAn", connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    billList.Load(reader);
                    connection.Close();
                }

            }
            dgvCTMA.DataSource = billList;
            dgvCTMA.Enabled = false;

        }
    }
}
