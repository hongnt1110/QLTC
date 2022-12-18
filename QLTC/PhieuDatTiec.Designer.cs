namespace QLTC
{
    partial class PhieuDatTiec
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbSanh = new System.Windows.Forms.ComboBox();
            this.txbNgayDaiTiec = new System.Windows.Forms.TextBox();
            this.txbTienCoc = new System.Windows.Forms.TextBox();
            this.txbSLBan = new System.Windows.Forms.TextBox();
            this.txbCoDau = new System.Windows.Forms.TextBox();
            this.txbMaKhachHang = new System.Windows.Forms.TextBox();
            this.txbChuRe = new System.Windows.Forms.TextBox();
            this.txbMaPhieu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataDichVu = new QLTC.DataDichVu();
            this.dataDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDanhSachCa = new System.Windows.Forms.Button();
            this.sANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANHTableAdapter = new QLTC.DataDichVuTableAdapters.SANHTableAdapter();
            this.cbbCa = new System.Windows.Forms.ComboBox();
            this.cABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATableAdapter = new QLTC.DataDichVuTableAdapters.CATableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDanhSachCa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(251, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐẶT TIỆC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbCa);
            this.panel2.Controls.Add(this.cbbSanh);
            this.panel2.Controls.Add(this.txbNgayDaiTiec);
            this.panel2.Controls.Add(this.txbTienCoc);
            this.panel2.Controls.Add(this.txbSLBan);
            this.panel2.Controls.Add(this.txbCoDau);
            this.panel2.Controls.Add(this.txbMaKhachHang);
            this.panel2.Controls.Add(this.txbChuRe);
            this.panel2.Controls.Add(this.txbMaPhieu);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 155);
            this.panel2.TabIndex = 1;
            // 
            // cbbSanh
            // 
            this.cbbSanh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sANHBindingSource, "MaSanh", true));
            this.cbbSanh.DataSource = this.sANHBindingSource;
            this.cbbSanh.DisplayMember = "TenSanh";
            this.cbbSanh.FormattingEnabled = true;
            this.cbbSanh.Location = new System.Drawing.Point(79, 81);
            this.cbbSanh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbbSanh.Name = "cbbSanh";
            this.cbbSanh.Size = new System.Drawing.Size(126, 21);
            this.cbbSanh.TabIndex = 19;
            this.cbbSanh.ValueMember = "MaSanh";
            // 
            // txbNgayDaiTiec
            // 
            this.txbNgayDaiTiec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNgayDaiTiec.Location = new System.Drawing.Point(604, 43);
            this.txbNgayDaiTiec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbNgayDaiTiec.Name = "txbNgayDaiTiec";
            this.txbNgayDaiTiec.Size = new System.Drawing.Size(126, 20);
            this.txbNgayDaiTiec.TabIndex = 18;
            // 
            // txbTienCoc
            // 
            this.txbTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTienCoc.Location = new System.Drawing.Point(604, 84);
            this.txbTienCoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbTienCoc.Name = "txbTienCoc";
            this.txbTienCoc.Size = new System.Drawing.Size(126, 20);
            this.txbTienCoc.TabIndex = 17;
            // 
            // txbSLBan
            // 
            this.txbSLBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSLBan.Location = new System.Drawing.Point(358, 84);
            this.txbSLBan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSLBan.Name = "txbSLBan";
            this.txbSLBan.Size = new System.Drawing.Size(119, 20);
            this.txbSLBan.TabIndex = 14;
            // 
            // txbCoDau
            // 
            this.txbCoDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCoDau.Location = new System.Drawing.Point(358, 46);
            this.txbCoDau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbCoDau.Name = "txbCoDau";
            this.txbCoDau.Size = new System.Drawing.Size(119, 20);
            this.txbCoDau.TabIndex = 13;
            // 
            // txbMaKhachHang
            // 
            this.txbMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMaKhachHang.Location = new System.Drawing.Point(358, 11);
            this.txbMaKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMaKhachHang.Name = "txbMaKhachHang";
            this.txbMaKhachHang.Size = new System.Drawing.Size(119, 20);
            this.txbMaKhachHang.TabIndex = 12;
            // 
            // txbChuRe
            // 
            this.txbChuRe.Location = new System.Drawing.Point(79, 46);
            this.txbChuRe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbChuRe.Name = "txbChuRe";
            this.txbChuRe.Size = new System.Drawing.Size(126, 20);
            this.txbChuRe.TabIndex = 10;
            // 
            // txbMaPhieu
            // 
            this.txbMaPhieu.Location = new System.Drawing.Point(79, 11);
            this.txbMaPhieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbMaPhieu.Name = "txbMaPhieu";
            this.txbMaPhieu.Size = new System.Drawing.Size(126, 20);
            this.txbMaPhieu.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(535, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tiền cọc";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lượng bàn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sảnh";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày đặt";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 11);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã ca";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 47);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cô dâu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chú rể";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu";
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 209);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(738, 32);
            this.panel5.TabIndex = 4;
            // 
            // dataDichVu
            // 
            this.dataDichVu.DataSetName = "DataDichVu";
            this.dataDichVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataDichVuBindingSource
            // 
            this.dataDichVuBindingSource.DataSource = this.dataDichVu;
            this.dataDichVuBindingSource.Position = 0;
            // 
            // btnDanhSachCa
            // 
            this.btnDanhSachCa.BackColor = System.Drawing.Color.White;
            this.btnDanhSachCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachCa.ForeColor = System.Drawing.Color.Orange;
            this.btnDanhSachCa.Location = new System.Drawing.Point(12, 12);
            this.btnDanhSachCa.Name = "btnDanhSachCa";
            this.btnDanhSachCa.Size = new System.Drawing.Size(200, 29);
            this.btnDanhSachCa.TabIndex = 22;
            this.btnDanhSachCa.Text = "Danh sách ca";
            this.btnDanhSachCa.UseVisualStyleBackColor = false;
            this.btnDanhSachCa.Click += new System.EventHandler(this.btnDanhSachCa_Click);
            // 
            // sANHBindingSource
            // 
            this.sANHBindingSource.DataMember = "SANH";
            this.sANHBindingSource.DataSource = this.dataDichVuBindingSource;
            // 
            // sANHTableAdapter
            // 
            this.sANHTableAdapter.ClearBeforeFill = true;
            // 
            // cbbCa
            // 
            this.cbbCa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cABindingSource, "MaCa", true));
            this.cbbCa.DataSource = this.cABindingSource;
            this.cbbCa.DisplayMember = "LoaiCa";
            this.cbbCa.FormattingEnabled = true;
            this.cbbCa.Location = new System.Drawing.Point(604, 10);
            this.cbbCa.Margin = new System.Windows.Forms.Padding(2);
            this.cbbCa.Name = "cbbCa";
            this.cbbCa.Size = new System.Drawing.Size(126, 21);
            this.cbbCa.TabIndex = 20;
            this.cbbCa.ValueMember = "MaCa";
            // 
            // cABindingSource
            // 
            this.cABindingSource.DataMember = "CA";
            this.cABindingSource.DataSource = this.dataDichVuBindingSource;
            // 
            // cATableAdapter
            // 
            this.cATableAdapter.ClearBeforeFill = true;
            // 
            // PhieuDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(738, 609);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhieuDatTiec";
            this.Text = "PhieuDatTiec";
            this.Load += new System.EventHandler(this.PhieuDatTiec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTienCoc;
        private System.Windows.Forms.TextBox txbSLBan;
        private System.Windows.Forms.TextBox txbCoDau;
        private System.Windows.Forms.TextBox txbMaKhachHang;
        private System.Windows.Forms.TextBox txbChuRe;
        private System.Windows.Forms.TextBox txbMaPhieu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private DataDichVu dataDichVu;
        private System.Windows.Forms.BindingSource dataDichVuBindingSource;
        private System.Windows.Forms.TextBox txbNgayDaiTiec;
        private System.Windows.Forms.ComboBox cbbSanh;
        private System.Windows.Forms.Button btnDanhSachCa;
        private System.Windows.Forms.BindingSource sANHBindingSource;
        private DataDichVuTableAdapters.SANHTableAdapter sANHTableAdapter;
        private System.Windows.Forms.ComboBox cbbCa;
        private System.Windows.Forms.BindingSource cABindingSource;
        private DataDichVuTableAdapters.CATableAdapter cATableAdapter;
    }
}