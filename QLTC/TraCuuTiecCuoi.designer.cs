namespace QLTC
{
    partial class TraCuuTiecCuoi
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTraCuuTiecCuoi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTiecCuoi = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.radioButtonMaDatTiec = new System.Windows.Forms.RadioButton();
            this.dataDichVu = new QLTC.DataDichVu();
            this.pHIEUDATTIECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHIEUDATTIECTableAdapter = new QLTC.DataDichVuTableAdapters.PHIEUDATTIECTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuuTiecCuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATTIECBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxTiecCuoi);
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.radioButtonMaDatTiec);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 423);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(392, 86);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 20);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Tên cô dâu";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(271, 86);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 20);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tên chú rễ";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(681, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.White;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Orange;
            this.buttonThoat.Location = new System.Drawing.Point(825, 388);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 14;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewTraCuuTiecCuoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(10, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(896, 247);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu đặt tiệc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewTraCuuTiecCuoi
            // 
            this.dataGridViewTraCuuTiecCuoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTraCuuTiecCuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraCuuTiecCuoi.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTraCuuTiecCuoi.Name = "dataGridViewTraCuuTiecCuoi";
            this.dataGridViewTraCuuTiecCuoi.Size = new System.Drawing.Size(884, 222);
            this.dataGridViewTraCuuTiecCuoi.TabIndex = 0;
            this.dataGridViewTraCuuTiecCuoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTraCuuHopDong_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(352, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Tiệc Cưới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxTiecCuoi
            // 
            this.textBoxTiecCuoi.Location = new System.Drawing.Point(330, 60);
            this.textBoxTiecCuoi.Name = "textBoxTiecCuoi";
            this.textBoxTiecCuoi.Size = new System.Drawing.Size(259, 20);
            this.textBoxTiecCuoi.TabIndex = 1;
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.SystemColors.HighlightText;
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.ForeColor = System.Drawing.Color.Orange;
            this.buttonTim.Location = new System.Drawing.Point(792, 106);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(108, 23);
            this.buttonTim.TabIndex = 6;
            this.buttonTim.Text = "Tìm ";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonMaDatTiec
            // 
            this.radioButtonMaDatTiec.AutoSize = true;
            this.radioButtonMaDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaDatTiec.Location = new System.Drawing.Point(525, 86);
            this.radioButtonMaDatTiec.Name = "radioButtonMaDatTiec";
            this.radioButtonMaDatTiec.Size = new System.Drawing.Size(104, 20);
            this.radioButtonMaDatTiec.TabIndex = 5;
            this.radioButtonMaDatTiec.TabStop = true;
            this.radioButtonMaDatTiec.Text = "Ngày đãi tiệc";
            this.radioButtonMaDatTiec.UseVisualStyleBackColor = true;
            this.radioButtonMaDatTiec.CheckedChanged += new System.EventHandler(this.radioButtonMaDatTiec_CheckedChanged);
            // 
            // dataDichVu
            // 
            this.dataDichVu.DataSetName = "DataDichVu";
            this.dataDichVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHIEUDATTIECBindingSource
            // 
            this.pHIEUDATTIECBindingSource.DataMember = "PHIEUDATTIEC";
            this.pHIEUDATTIECBindingSource.DataSource = this.dataDichVu;
            // 
            // pHIEUDATTIECTableAdapter
            // 
            this.pHIEUDATTIECTableAdapter.ClearBeforeFill = true;
            // 
            // TraCuuTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 425);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TraCuuTiecCuoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý tiệc cưới";
            this.Load += new System.EventHandler(this.TraCuuTiecCuoi_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuuTiecCuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDATTIECBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTiecCuoi;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.RadioButton radioButtonMaDatTiec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.DataGridView dataGridViewTraCuuTiecCuoi;
        private System.Windows.Forms.Button button1;
        private DataDichVu dataDichVu;
        private System.Windows.Forms.BindingSource pHIEUDATTIECBindingSource;
        private DataDichVuTableAdapters.PHIEUDATTIECTableAdapter pHIEUDATTIECTableAdapter;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}