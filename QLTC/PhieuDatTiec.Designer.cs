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
            this.cABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDichVu = new QLTC.DataDichVu();
            this.sANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONANBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInPhieu = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCa = new System.Windows.Forms.Button();
            this.dICHVUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sANHTableAdapter = new QLTC.DataDichVuTableAdapters.SANHTableAdapter();
            this.cATableAdapter = new QLTC.DataDichVuTableAdapters.CATableAdapter();
            this.mONANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mONANTableAdapter = new QLTC.DataDichVuTableAdapters.MONANTableAdapter();
            this.dICHVUTableAdapter = new QLTC.DataDichVuTableAdapters.DICHVUTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDichVu1 = new QLTC.DataDichVu();
            this.listMonAn = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.listDichVu = new System.Windows.Forms.ListView();
            this.tenDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.donGiaDichVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbChuRe = new System.Windows.Forms.TextBox();
            this.txbCodau = new System.Windows.Forms.TextBox();
            this.txbSLBan = new System.Windows.Forms.TextBox();
            this.txbTienCoc = new System.Windows.Forms.TextBox();
            this.cbbSanh = new System.Windows.Forms.ComboBox();
            this.txbGiaBan = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbMaCa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANBindingSource1)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 54);
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
            // cABindingSource
            // 
            this.cABindingSource.DataMember = "CA";
            this.cABindingSource.DataSource = this.dataDichVuBindingSource;
            // 
            // dataDichVuBindingSource
            // 
            this.dataDichVuBindingSource.DataSource = this.dataDichVu;
            this.dataDichVuBindingSource.Position = 0;
            // 
            // dataDichVu
            // 
            this.dataDichVu.DataSetName = "DataDichVu";
            this.dataDichVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sANHBindingSource
            // 
            this.sANHBindingSource.DataMember = "SANH";
            this.sANHBindingSource.DataSource = this.dataDichVuBindingSource;
            // 
            // mONANBindingSource1
            // 
            this.mONANBindingSource1.DataMember = "MONAN";
            this.mONANBindingSource1.DataSource = this.dataDichVuBindingSource;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnThoat);
            this.panel9.Controls.Add(this.btnInPhieu);
            this.panel9.Controls.Add(this.btnLuu);
            this.panel9.Controls.Add(this.btnCa);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 457);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(730, 54);
            this.panel9.TabIndex = 8;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Orange;
            this.btnThoat.Location = new System.Drawing.Point(608, 16);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(110, 26);
            this.btnThoat.TabIndex = 24;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInPhieu
            // 
            this.btnInPhieu.BackColor = System.Drawing.Color.White;
            this.btnInPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInPhieu.ForeColor = System.Drawing.Color.Orange;
            this.btnInPhieu.Location = new System.Drawing.Point(519, 16);
            this.btnInPhieu.Name = "btnInPhieu";
            this.btnInPhieu.Size = new System.Drawing.Size(83, 26);
            this.btnInPhieu.TabIndex = 23;
            this.btnInPhieu.Text = "In";
            this.btnInPhieu.UseVisualStyleBackColor = false;
            this.btnInPhieu.Click += new System.EventHandler(this.btnInPhieu_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Orange;
            this.btnLuu.Location = new System.Drawing.Point(430, 16);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 26);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCa
            // 
            this.btnCa.BackColor = System.Drawing.Color.White;
            this.btnCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCa.ForeColor = System.Drawing.Color.Orange;
            this.btnCa.Location = new System.Drawing.Point(12, 14);
            this.btnCa.Name = "btnCa";
            this.btnCa.Size = new System.Drawing.Size(185, 26);
            this.btnCa.TabIndex = 16;
            this.btnCa.Text = "Danh sách ca";
            this.btnCa.UseVisualStyleBackColor = false;
            this.btnCa.Click += new System.EventHandler(this.btnCa_Click);
            // 
            // dICHVUBindingSource
            // 
            this.dICHVUBindingSource.DataMember = "DICHVU";
            this.dICHVUBindingSource.DataSource = this.dataDichVuBindingSource;
            // 
            // sANHTableAdapter
            // 
            this.sANHTableAdapter.ClearBeforeFill = true;
            // 
            // cATableAdapter
            // 
            this.cATableAdapter.ClearBeforeFill = true;
            // 
            // mONANBindingSource
            // 
            this.mONANBindingSource.DataMember = "MONAN";
            this.mONANBindingSource.DataSource = this.dataDichVuBindingSource;
            // 
            // mONANTableAdapter
            // 
            this.mONANTableAdapter.ClearBeforeFill = true;
            // 
            // dICHVUTableAdapter
            // 
            this.dICHVUTableAdapter.ClearBeforeFill = true;
            // 
            // dataDichVu1
            // 
            this.dataDichVu1.DataSetName = "DataDichVu";
            this.dataDichVu1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listMonAn
            // 
            this.listMonAn.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listMonAn.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listMonAn.CheckBoxes = true;
            this.listMonAn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listMonAn.GridLines = true;
            this.listMonAn.HideSelection = false;
            this.listMonAn.HoverSelection = true;
            this.listMonAn.Location = new System.Drawing.Point(61, 199);
            this.listMonAn.Name = "listMonAn";
            this.listMonAn.Size = new System.Drawing.Size(610, 113);
            this.listMonAn.TabIndex = 3;
            this.listMonAn.UseCompatibleStateImageBehavior = false;
            this.listMonAn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn";
            this.columnHeader1.Width = 267;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn Giá Món Ăn";
            this.columnHeader2.Width = 339;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Các món ăn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(58, 315);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Các dịch vụ khác";
            // 
            // listDichVu
            // 
            this.listDichVu.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listDichVu.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listDichVu.CheckBoxes = true;
            this.listDichVu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.tenDichVu,
            this.donGiaDichVu});
            this.listDichVu.GridLines = true;
            this.listDichVu.HideSelection = false;
            this.listDichVu.HoverSelection = true;
            this.listDichVu.Location = new System.Drawing.Point(61, 335);
            this.listDichVu.Name = "listDichVu";
            this.listDichVu.Size = new System.Drawing.Size(610, 114);
            this.listDichVu.TabIndex = 10;
            this.listDichVu.UseCompatibleStateImageBehavior = false;
            this.listDichVu.View = System.Windows.Forms.View.Details;
            // 
            // tenDichVu
            // 
            this.tenDichVu.Text = "Tên Dịch Vụ";
            this.tenDichVu.Width = 267;
            // 
            // donGiaDichVu
            // 
            this.donGiaDichVu.Text = "Đơn Giá Dịch Vụ";
            this.donGiaDichVu.Width = 339;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chú rể";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cô dâu";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(508, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Ngày đãi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(22, 50);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Sảnh";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lượng bàn";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(509, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tiền cọc";
            // 
            // txbChuRe
            // 
            this.txbChuRe.Location = new System.Drawing.Point(86, 11);
            this.txbChuRe.Margin = new System.Windows.Forms.Padding(2);
            this.txbChuRe.Name = "txbChuRe";
            this.txbChuRe.Size = new System.Drawing.Size(126, 20);
            this.txbChuRe.TabIndex = 10;
            // 
            // txbCodau
            // 
            this.txbCodau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbCodau.Location = new System.Drawing.Point(346, 11);
            this.txbCodau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbCodau.Name = "txbCodau";
            this.txbCodau.Size = new System.Drawing.Size(120, 20);
            this.txbCodau.TabIndex = 13;
            // 
            // txbSLBan
            // 
            this.txbSLBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbSLBan.Location = new System.Drawing.Point(347, 48);
            this.txbSLBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSLBan.Name = "txbSLBan";
            this.txbSLBan.Size = new System.Drawing.Size(118, 20);
            this.txbSLBan.TabIndex = 14;
            // 
            // txbTienCoc
            // 
            this.txbTienCoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTienCoc.Location = new System.Drawing.Point(770, 103);
            this.txbTienCoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTienCoc.Name = "txbTienCoc";
            this.txbTienCoc.Size = new System.Drawing.Size(126, 20);
            this.txbTienCoc.TabIndex = 17;
            // 
            // cbbSanh
            // 
            this.cbbSanh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.sANHBindingSource, "MaSanh", true));
            this.cbbSanh.DataSource = this.sANHBindingSource;
            this.cbbSanh.DisplayMember = "TenSanh";
            this.cbbSanh.FormattingEnabled = true;
            this.cbbSanh.Location = new System.Drawing.Point(86, 50);
            this.cbbSanh.Name = "cbbSanh";
            this.cbbSanh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbSanh.Size = new System.Drawing.Size(126, 21);
            this.cbbSanh.TabIndex = 19;
            this.cbbSanh.ValueMember = "MaSanh";
            this.cbbSanh.SelectedIndexChanged += new System.EventHandler(this.cbbSanh_SelectedIndexChanged);
            // 
            // txbGiaBan
            // 
            this.txbGiaBan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbGiaBan.Location = new System.Drawing.Point(770, 55);
            this.txbGiaBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbGiaBan.Name = "txbGiaBan";
            this.txbGiaBan.Size = new System.Drawing.Size(167, 20);
            this.txbGiaBan.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(594, 11);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ca";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(594, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 27;
            // 
            // cbbMaCa
            // 
            this.cbbMaCa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbMaCa.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cABindingSource, "MaCa", true));
            this.cbbMaCa.DataSource = this.cABindingSource;
            this.cbbMaCa.DisplayMember = "LoaiCa";
            this.cbbMaCa.FormattingEnabled = true;
            this.cbbMaCa.Location = new System.Drawing.Point(86, 79);
            this.cbbMaCa.Name = "cbbMaCa";
            this.cbbMaCa.Size = new System.Drawing.Size(126, 21);
            this.cbbMaCa.TabIndex = 22;
            this.cbbMaCa.ValueMember = "MaCa";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.cbbMaCa);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.txbGiaBan);
            this.panel2.Controls.Add(this.cbbSanh);
            this.panel2.Controls.Add(this.txbTienCoc);
            this.panel2.Controls.Add(this.txbSLBan);
            this.panel2.Controls.Add(this.txbCodau);
            this.panel2.Controls.Add(this.txbChuRe);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 125);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(254, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá Bàn";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.Location = new System.Drawing.Point(347, 82);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 20);
            this.textBox2.TabIndex = 28;
            // 
            // PhieuDatTiec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(730, 511);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listDichVu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.listMonAn);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhieuDatTiec";
            this.Text = "PhieuDatTiec";
            this.Load += new System.EventHandler(this.PhieuDatTiec_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANBindingSource1)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dICHVUBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONANBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private DataDichVu dataDichVu;
        private System.Windows.Forms.BindingSource dataDichVuBindingSource;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.BindingSource sANHBindingSource;
        private DataDichVuTableAdapters.SANHTableAdapter sANHTableAdapter;
        private DataDichVuTableAdapters.CATableAdapter cATableAdapter;
        private System.Windows.Forms.BindingSource mONANBindingSource;
        private DataDichVuTableAdapters.MONANTableAdapter mONANTableAdapter;
        private System.Windows.Forms.BindingSource mONANBindingSource1;
        private System.Windows.Forms.BindingSource dICHVUBindingSource;
        private DataDichVuTableAdapters.DICHVUTableAdapter dICHVUTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DataDichVu dataDichVu1;
        private System.Windows.Forms.ListView listMonAn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listDichVu;
        private System.Windows.Forms.ColumnHeader tenDichVu;
        private System.Windows.Forms.ColumnHeader donGiaDichVu;
        private System.Windows.Forms.BindingSource cABindingSource;
        private System.Windows.Forms.Button btnCa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInPhieu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbChuRe;
        private System.Windows.Forms.TextBox txbCodau;
        private System.Windows.Forms.TextBox txbSLBan;
        private System.Windows.Forms.TextBox txbTienCoc;
        private System.Windows.Forms.ComboBox cbbSanh;
        private System.Windows.Forms.TextBox txbGiaBan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbbMaCa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}