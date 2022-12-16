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
            this.txbTienCoc = new System.Windows.Forms.TextBox();
            this.txbMaCa = new System.Windows.Forms.TextBox();
            this.txbSLBan = new System.Windows.Forms.TextBox();
            this.txbCoDau = new System.Windows.Forms.TextBox();
            this.txbMaKhachHang = new System.Windows.Forms.TextBox();
            this.txbSanh = new System.Windows.Forms.TextBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvPhieuDacTiec = new System.Windows.Forms.DataGridView();
            this.dataDichVu = new QLTC.DataDichVu();
            this.dataDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txbNgayDaiTiec = new System.Windows.Forms.TextBox();
            this.MaPhieuDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenChuRe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCoDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDaiTiec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDacTiec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐẶT TIỆC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbNgayDaiTiec);
            this.panel2.Controls.Add(this.txbTienCoc);
            this.panel2.Controls.Add(this.txbMaCa);
            this.panel2.Controls.Add(this.txbSLBan);
            this.panel2.Controls.Add(this.txbCoDau);
            this.panel2.Controls.Add(this.txbMaKhachHang);
            this.panel2.Controls.Add(this.txbSanh);
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
            this.panel2.Location = new System.Drawing.Point(0, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 191);
            this.panel2.TabIndex = 1;
            // 
            // txbTienCoc
            // 
            this.txbTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTienCoc.Location = new System.Drawing.Point(805, 128);
            this.txbTienCoc.Name = "txbTienCoc";
            this.txbTienCoc.Size = new System.Drawing.Size(167, 22);
            this.txbTienCoc.TabIndex = 17;
            // 
            // txbMaCa
            // 
            this.txbMaCa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbMaCa.Location = new System.Drawing.Point(805, 13);
            this.txbMaCa.Name = "txbMaCa";
            this.txbMaCa.Size = new System.Drawing.Size(167, 22);
            this.txbMaCa.TabIndex = 15;
            // 
            // txbSLBan
            // 
            this.txbSLBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSLBan.Location = new System.Drawing.Point(478, 128);
            this.txbSLBan.Name = "txbSLBan";
            this.txbSLBan.Size = new System.Drawing.Size(157, 22);
            this.txbSLBan.TabIndex = 14;
            // 
            // txbCoDau
            // 
            this.txbCoDau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCoDau.Location = new System.Drawing.Point(478, 70);
            this.txbCoDau.Name = "txbCoDau";
            this.txbCoDau.Size = new System.Drawing.Size(157, 22);
            this.txbCoDau.TabIndex = 13;
            // 
            // txbMaKhachHang
            // 
            this.txbMaKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbMaKhachHang.Location = new System.Drawing.Point(478, 13);
            this.txbMaKhachHang.Name = "txbMaKhachHang";
            this.txbMaKhachHang.Size = new System.Drawing.Size(157, 22);
            this.txbMaKhachHang.TabIndex = 12;
            // 
            // txbSanh
            // 
            this.txbSanh.Location = new System.Drawing.Point(105, 128);
            this.txbSanh.Name = "txbSanh";
            this.txbSanh.Size = new System.Drawing.Size(167, 22);
            this.txbSanh.TabIndex = 11;
            // 
            // txbChuRe
            // 
            this.txbChuRe.Location = new System.Drawing.Point(105, 70);
            this.txbChuRe.Name = "txbChuRe";
            this.txbChuRe.Size = new System.Drawing.Size(167, 22);
            this.txbChuRe.TabIndex = 10;
            // 
            // txbMaPhieu
            // 
            this.txbMaPhieu.Location = new System.Drawing.Point(105, 13);
            this.txbMaPhieu.Name = "txbMaPhieu";
            this.txbMaPhieu.Size = new System.Drawing.Size(167, 22);
            this.txbMaPhieu.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(713, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tiền cọc";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(338, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lượng bàn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sảnh";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(713, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày đặt";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mã ca";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cô dâu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chú rể";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 258);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 495);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(951, 258);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(33, 495);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label11);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(38, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(913, 40);
            this.panel5.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(-4, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Danh sách phiếu đặt tiệc";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(38, 713);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(913, 40);
            this.panel6.TabIndex = 5;
            // 
            // dgvPhieuDacTiec
            // 
            this.dgvPhieuDacTiec.AllowUserToAddRows = false;
            this.dgvPhieuDacTiec.AllowUserToDeleteRows = false;
            this.dgvPhieuDacTiec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDacTiec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDacTiec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhieuDT,
            this.MaKH,
            this.TenChuRe,
            this.TenCoDau,
            this.NgayDaiTiec,
            this.MaSanh,
            this.TienCoc,
            this.SoLuongBan,
            this.MaCa});
            this.dgvPhieuDacTiec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuDacTiec.Location = new System.Drawing.Point(38, 298);
            this.dgvPhieuDacTiec.Name = "dgvPhieuDacTiec";
            this.dgvPhieuDacTiec.ReadOnly = true;
            this.dgvPhieuDacTiec.RowHeadersVisible = false;
            this.dgvPhieuDacTiec.RowHeadersWidth = 51;
            this.dgvPhieuDacTiec.RowTemplate.Height = 24;
            this.dgvPhieuDacTiec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuDacTiec.Size = new System.Drawing.Size(913, 415);
            this.dgvPhieuDacTiec.TabIndex = 6;
            this.dgvPhieuDacTiec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDacTiec_CellClick);
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
            // txbNgayDaiTiec
            // 
            this.txbNgayDaiTiec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNgayDaiTiec.Location = new System.Drawing.Point(805, 67);
            this.txbNgayDaiTiec.Name = "txbNgayDaiTiec";
            this.txbNgayDaiTiec.Size = new System.Drawing.Size(167, 22);
            this.txbNgayDaiTiec.TabIndex = 18;
            // 
            // MaPhieuDT
            // 
            this.MaPhieuDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaPhieuDT.DataPropertyName = "MaPhieuDT";
            this.MaPhieuDT.HeaderText = "Mã phiếu";
            this.MaPhieuDT.MinimumWidth = 6;
            this.MaPhieuDT.Name = "MaPhieuDT";
            this.MaPhieuDT.ReadOnly = true;
            this.MaPhieuDT.Width = 114;
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.ReadOnly = true;
            // 
            // TenChuRe
            // 
            this.TenChuRe.DataPropertyName = "TenChuRe";
            this.TenChuRe.HeaderText = "Chú rể";
            this.TenChuRe.MinimumWidth = 6;
            this.TenChuRe.Name = "TenChuRe";
            this.TenChuRe.ReadOnly = true;
            // 
            // TenCoDau
            // 
            this.TenCoDau.DataPropertyName = "TenCoDau";
            this.TenCoDau.HeaderText = "Cô Dâu";
            this.TenCoDau.MinimumWidth = 6;
            this.TenCoDau.Name = "TenCoDau";
            this.TenCoDau.ReadOnly = true;
            // 
            // NgayDaiTiec
            // 
            this.NgayDaiTiec.DataPropertyName = "NgayDaiTiec";
            this.NgayDaiTiec.HeaderText = "Ngày đãi tiệc";
            this.NgayDaiTiec.MinimumWidth = 6;
            this.NgayDaiTiec.Name = "NgayDaiTiec";
            this.NgayDaiTiec.ReadOnly = true;
            // 
            // MaSanh
            // 
            this.MaSanh.DataPropertyName = "MaSanh";
            this.MaSanh.HeaderText = "Mã sảnh";
            this.MaSanh.MinimumWidth = 6;
            this.MaSanh.Name = "MaSanh";
            this.MaSanh.ReadOnly = true;
            // 
            // TienCoc
            // 
            this.TienCoc.DataPropertyName = "TienCoc";
            this.TienCoc.HeaderText = "Tiền cọc";
            this.TienCoc.MinimumWidth = 6;
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.ReadOnly = true;
            // 
            // SoLuongBan
            // 
            this.SoLuongBan.DataPropertyName = "SoLuongBan";
            this.SoLuongBan.HeaderText = "Số lượng bàn";
            this.SoLuongBan.MinimumWidth = 6;
            this.SoLuongBan.Name = "SoLuongBan";
            this.SoLuongBan.ReadOnly = true;
            // 
            // MaCa
            // 
            this.MaCa.DataPropertyName = "MaCa";
            this.MaCa.HeaderText = "Mã Ca";
            this.MaCa.MinimumWidth = 6;
            this.MaCa.Name = "MaCa";
            this.MaCa.ReadOnly = true;
            // 
            // PhieuDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(984, 753);
            this.Controls.Add(this.dgvPhieuDacTiec);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PhieuDatTiec";
            this.Text = "PhieuDatTiec";
            this.Load += new System.EventHandler(this.PhieuDatTiec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDacTiec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTienCoc;
        private System.Windows.Forms.TextBox txbMaCa;
        private System.Windows.Forms.TextBox txbSLBan;
        private System.Windows.Forms.TextBox txbCoDau;
        private System.Windows.Forms.TextBox txbMaKhachHang;
        private System.Windows.Forms.TextBox txbSanh;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvPhieuDacTiec;
        private System.Windows.Forms.Label label11;
        private DataDichVu dataDichVu;
        private System.Windows.Forms.BindingSource dataDichVuBindingSource;
        private System.Windows.Forms.TextBox txbNgayDaiTiec;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenChuRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCoDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDaiTiec;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCa;
    }
}