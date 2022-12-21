namespace QLTC
{
    partial class InPhieuDatTiec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InPhieuDatTiec));
            this.panelPrint = new System.Windows.Forms.Panel();
            this.dgvCTDV = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChuDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCTMA = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChuMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbSLBan = new System.Windows.Forms.Label();
            this.lbTenCoDau = new System.Windows.Forms.Label();
            this.lbMaCa = new System.Windows.Forms.Label();
            this.lbSanh = new System.Windows.Forms.Label();
            this.lbTenChuRe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbNgayDat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuat = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelPrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrint
            // 
            this.panelPrint.Controls.Add(this.dgvCTDV);
            this.panelPrint.Controls.Add(this.dgvCTMA);
            this.panelPrint.Controls.Add(this.lbSLBan);
            this.panelPrint.Controls.Add(this.lbTenCoDau);
            this.panelPrint.Controls.Add(this.lbMaCa);
            this.panelPrint.Controls.Add(this.lbSanh);
            this.panelPrint.Controls.Add(this.lbTenChuRe);
            this.panelPrint.Controls.Add(this.label1);
            this.panelPrint.Controls.Add(this.label6);
            this.panelPrint.Controls.Add(this.label9);
            this.panelPrint.Controls.Add(this.label10);
            this.panelPrint.Controls.Add(this.lbNgayDat);
            this.panelPrint.Controls.Add(this.label5);
            this.panelPrint.Controls.Add(this.label3);
            this.panelPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelPrint.Location = new System.Drawing.Point(0, 0);
            this.panelPrint.Margin = new System.Windows.Forms.Padding(2);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(626, 602);
            this.panelPrint.TabIndex = 0;
            // 
            // dgvCTDV
            // 
            this.dgvCTDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTDV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.SoLuongDichVu,
            this.GhiChuDichVu});
            this.dgvCTDV.Location = new System.Drawing.Point(38, 430);
            this.dgvCTDV.Name = "dgvCTDV";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTDV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCTDV.RowHeadersVisible = false;
            this.dgvCTDV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCTDV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCTDV.RowTemplate.Height = 24;
            this.dgvCTDV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCTDV.Size = new System.Drawing.Size(548, 165);
            this.dgvCTDV.TabIndex = 60;
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MaDichVu";
            this.MaDichVu.HeaderText = "Mã dịch vụ";
            this.MaDichVu.MinimumWidth = 6;
            this.MaDichVu.Name = "MaDichVu";
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Dịch vụ";
            this.TenDichVu.MinimumWidth = 6;
            this.TenDichVu.Name = "TenDichVu";
            // 
            // SoLuongDichVu
            // 
            this.SoLuongDichVu.DataPropertyName = "SoLuong";
            this.SoLuongDichVu.HeaderText = "Số lượng";
            this.SoLuongDichVu.MinimumWidth = 6;
            this.SoLuongDichVu.Name = "SoLuongDichVu";
            // 
            // GhiChuDichVu
            // 
            this.GhiChuDichVu.HeaderText = "Ghi chú";
            this.GhiChuDichVu.MinimumWidth = 6;
            this.GhiChuDichVu.Name = "GhiChuDichVu";
            // 
            // dgvCTMA
            // 
            this.dgvCTMA.AllowDrop = true;
            this.dgvCTMA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCTMA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTMA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTMA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTMA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.DonGia,
            this.GhiChuMonAn});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCTMA.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCTMA.Location = new System.Drawing.Point(38, 249);
            this.dgvCTMA.Name = "dgvCTMA";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTMA.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCTMA.RowHeadersVisible = false;
            this.dgvCTMA.RowHeadersWidth = 51;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCTMA.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCTMA.RowTemplate.Height = 24;
            this.dgvCTMA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCTMA.Size = new System.Drawing.Size(548, 161);
            this.dgvCTMA.TabIndex = 59;
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã món ăn";
            this.MaMonAn.MinimumWidth = 6;
            this.MaMonAn.Name = "MaMonAn";
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.HeaderText = "Món ăn";
            this.TenMonAn.MinimumWidth = 6;
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            // 
            // GhiChuMonAn
            // 
            this.GhiChuMonAn.HeaderText = "Ghi chú";
            this.GhiChuMonAn.MinimumWidth = 6;
            this.GhiChuMonAn.Name = "GhiChuMonAn";
            // 
            // lbSLBan
            // 
            this.lbSLBan.AutoSize = true;
            this.lbSLBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLBan.Location = new System.Drawing.Point(439, 138);
            this.lbSLBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSLBan.Name = "lbSLBan";
            this.lbSLBan.Size = new System.Drawing.Size(16, 17);
            this.lbSLBan.TabIndex = 55;
            this.lbSLBan.Text = "?";
            // 
            // lbTenCoDau
            // 
            this.lbTenCoDau.AutoSize = true;
            this.lbTenCoDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenCoDau.Location = new System.Drawing.Point(410, 98);
            this.lbTenCoDau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenCoDau.Name = "lbTenCoDau";
            this.lbTenCoDau.Size = new System.Drawing.Size(16, 17);
            this.lbTenCoDau.TabIndex = 54;
            this.lbTenCoDau.Text = "?";
            // 
            // lbMaCa
            // 
            this.lbMaCa.AutoSize = true;
            this.lbMaCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaCa.Location = new System.Drawing.Point(163, 175);
            this.lbMaCa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaCa.Name = "lbMaCa";
            this.lbMaCa.Size = new System.Drawing.Size(16, 17);
            this.lbMaCa.TabIndex = 52;
            this.lbMaCa.Text = "?";
            // 
            // lbSanh
            // 
            this.lbSanh.AutoSize = true;
            this.lbSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSanh.Location = new System.Drawing.Point(163, 138);
            this.lbSanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSanh.Name = "lbSanh";
            this.lbSanh.Size = new System.Drawing.Size(16, 17);
            this.lbSanh.TabIndex = 51;
            this.lbSanh.Text = "?";
            // 
            // lbTenChuRe
            // 
            this.lbTenChuRe.AutoSize = true;
            this.lbTenChuRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenChuRe.Location = new System.Drawing.Point(172, 98);
            this.lbTenChuRe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenChuRe.Name = "lbTenChuRe";
            this.lbTenChuRe.Size = new System.Drawing.Size(16, 17);
            this.lbTenChuRe.TabIndex = 50;
            this.lbTenChuRe.Text = "?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(208, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "GRAND PALACE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 175);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Mã ca";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(343, 138);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Số lượng bàn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(108, 138);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Sảnh";
            // 
            // lbNgayDat
            // 
            this.lbNgayDat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgayDat.AutoSize = true;
            this.lbNgayDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayDat.Location = new System.Drawing.Point(292, 49);
            this.lbNgayDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNgayDat.Name = "lbNgayDat";
            this.lbNgayDat.Size = new System.Drawing.Size(64, 17);
            this.lbNgayDat.TabIndex = 34;
            this.lbNgayDat.Text = "Ngày đãi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "Cô dâu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Chú rể";
            // 
            // btnXuat
            // 
            this.btnXuat.Location = new System.Drawing.Point(518, 611);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(68, 26);
            this.btnXuat.TabIndex = 1;
            this.btnXuat.Text = "Xuất";
            this.btnXuat.UseVisualStyleBackColor = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // InPhieuDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 648);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.panelPrint);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InPhieuDatTiec";
            this.Text = "InPhieuDatTiec";
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTMA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNgayDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSLBan;
        private System.Windows.Forms.Label lbTenCoDau;
        private System.Windows.Forms.Label lbMaCa;
        private System.Windows.Forms.Label lbSanh;
        private System.Windows.Forms.Label lbTenChuRe;
        private System.Windows.Forms.DataGridView dgvCTMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChuMonAn;
        private System.Windows.Forms.DataGridView dgvCTDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChuDichVu;
        private System.Windows.Forms.Button btnXuat;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}