namespace QLTC.AdminChildForm
{
    partial class SanhForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnThem;
            System.Windows.Forms.Button btnXoa;
            System.Windows.Forms.Button btnSửa;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTenSanh = new System.Windows.Forms.TextBox();
            this.txbSLBanToiDa = new System.Windows.Forms.TextBox();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.cbLoaiSanh = new System.Windows.Forms.ComboBox();
            this.cbDGToiThieu = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnSửa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 47);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sảnh cưới";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(btnSửa);
            this.panel2.Controls.Add(btnXoa);
            this.panel2.Controls.Add(btnThem);
            this.panel2.Controls.Add(this.cbDGToiThieu);
            this.panel2.Controls.Add(this.cbLoaiSanh);
            this.panel2.Controls.Add(this.txbGhiChu);
            this.panel2.Controls.Add(this.txbSLBanToiDa);
            this.panel2.Controls.Add(this.txbTenSanh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 123);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sảnh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(12, 44);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại sảnh";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(388, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số lượng bàn tối đa";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label5.Location = new System.Drawing.Point(388, 44);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(162, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Đơn giá bàn tối thiểu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label6.Location = new System.Drawing.Point(12, 79);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ghi chú";
            // 
            // txbTenSanh
            // 
            this.txbTenSanh.Location = new System.Drawing.Point(113, 13);
            this.txbTenSanh.Name = "txbTenSanh";
            this.txbTenSanh.Size = new System.Drawing.Size(174, 22);
            this.txbTenSanh.TabIndex = 5;
            // 
            // txbSLBanToiDa
            // 
            this.txbSLBanToiDa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSLBanToiDa.Location = new System.Drawing.Point(572, 9);
            this.txbSLBanToiDa.Name = "txbSLBanToiDa";
            this.txbSLBanToiDa.Size = new System.Drawing.Size(216, 22);
            this.txbSLBanToiDa.TabIndex = 6;
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(113, 79);
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(174, 22);
            this.txbGhiChu.TabIndex = 8;
            // 
            // cbLoaiSanh
            // 
            this.cbLoaiSanh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbLoaiSanh.FormattingEnabled = true;
            this.cbLoaiSanh.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.cbLoaiSanh.Location = new System.Drawing.Point(113, 44);
            this.cbLoaiSanh.Name = "cbLoaiSanh";
            this.cbLoaiSanh.Size = new System.Drawing.Size(174, 24);
            this.cbLoaiSanh.TabIndex = 9;
            this.cbLoaiSanh.Text = "Chọn loại sảnh";
            // 
            // cbDGToiThieu
            // 
            this.cbDGToiThieu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDGToiThieu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbDGToiThieu.FormattingEnabled = true;
            this.cbDGToiThieu.Items.AddRange(new object[] {
            "1.000.000",
            "1.100.000",
            "1.200.000",
            "1.400.000",
            "1.600.000"});
            this.cbDGToiThieu.Location = new System.Drawing.Point(572, 48);
            this.cbDGToiThieu.Name = "cbDGToiThieu";
            this.cbDGToiThieu.Size = new System.Drawing.Size(216, 24);
            this.cbDGToiThieu.TabIndex = 10;
            this.cbDGToiThieu.Text = "Chọn đơn giá";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 280);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(740, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 280);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(60, 414);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(680, 36);
            this.panel5.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(60, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(680, 244);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnThem
            // 
            btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnThem.Location = new System.Drawing.Point(560, 94);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(64, 23);
            btnThem.TabIndex = 11;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnXoa.Location = new System.Drawing.Point(630, 94);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(64, 23);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSửa
            // 
            btnSửa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            btnSửa.Location = new System.Drawing.Point(700, 94);
            btnSửa.Name = "btnSửa";
            btnSửa.Size = new System.Drawing.Size(64, 23);
            btnSửa.TabIndex = 13;
            btnSửa.Text = "Sửa";
            btnSửa.UseVisualStyleBackColor = true;
            // 
            // SanhForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SanhForm";
            this.Text = "SanhForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbDGToiThieu;
        private System.Windows.Forms.ComboBox cbLoaiSanh;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.TextBox txbSLBanToiDa;
        private System.Windows.Forms.TextBox txbTenSanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}