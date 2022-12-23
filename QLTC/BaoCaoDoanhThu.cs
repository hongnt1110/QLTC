using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace QLTC
{
    public partial class BaoCaoDoanhThu : Form
    {
        public string connectionString = @"Data Source=LUAN-LENOVO\LUANNGUYEN;Initial Catalog=QLTC;Integrated Security=True";
        
        BindingSource binding;
        List<BaoCaoNgay> BaoCaoNgayS;
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            ShowBaoCaoNgay();

        }
        private void ShowBaoCaoNgay()
        {
             string BaoCaoNgayCmd = $@"SELECT DISTINCT NgayThanhToan,COUNT(NgayThanhToan) AS N'Số Lượng Tiệc', CAST( SUM(TongTienHD)AS INT) AS N'Doanh Thu'
                                            FROM HOADON
                                            WHERE MONTH(NgayThanhToan)={dateTimePicker1.Value.Month} AND YEAR(NgayThanhToan)={dateTimePicker1.Value.Year}
                                            GROUP BY NgayThanhToan";
        int TongDoanhThu = 0;
            int STT = 0;
            binding = new BindingSource();
            BaoCaoNgayS = new List<BaoCaoNgay>();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(BaoCaoNgayCmd, conn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    STT++;
                    TongDoanhThu += reader.GetInt32(2);
                    BaoCaoNgayS.Add(new BaoCaoNgay(STT,reader.GetDateTime(0).ToString("dd/MM/yyyy"), reader.GetInt32(1), reader.GetInt32(2)));
                   


                }
            }
            foreach(BaoCaoNgay s in BaoCaoNgayS)
            {
                s.TiLe = (Math.Round(((float)s.DoanhThu / (float)TongDoanhThu),2)).ToString();
            }
            label4.Text = TongDoanhThu.ToString();
            binding.DataSource = BaoCaoNgayS;
            dgv1.DataSource = binding;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void doanhthu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgv1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = $@"BaoCaoDoanhThuThang{dateTimePicker1.Value.Month}";
                saveFile.Filter = "Excel File|*.xlsx";
                DialogResult dgResult = saveFile.ShowDialog();
                if (dgResult == DialogResult.OK)
                {
                    //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                    ToExcel(dgv1, saveFile.FileName);
                }
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            string sheetName = "Báo Cáo Doanh Thu Tháng";
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = sheetName;

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch
            {
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowBaoCaoNgay();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string LuuButton = $@"insert into DOANHSO values('{DateTime.Now.ToString("MM/dd/yyyy")}',{dateTimePicker1.Value.Month},{int.Parse(label4.Text)}) ";
            //string LuuButton = $@"insert into DOANHSO values ('12/18/2022',12,5000)";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(LuuButton, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Lưu Thành Công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult xacNhan = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (xacNhan == DialogResult.Yes)
            {
                this.Hide();
                ManHinhChinh main = new ManHinhChinh();
                main.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DanhSachDoanhSo ds = new DanhSachDoanhSo();
            ds.ShowDialog();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
