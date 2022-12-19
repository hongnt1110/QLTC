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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTraCuuTiecCuoi = new System.Windows.Forms.DataGridView();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSua = new System.Windows.Forms.Button();
            this.textBoxTiecCuoi = new System.Windows.Forms.TextBox();
            this.radioButtonMaKH = new System.Windows.Forms.RadioButton();
            this.buttonTim = new System.Windows.Forms.Button();
            this.radioButtonMaDatTiec = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTraCuuTiecCuoi)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonThoat);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonXoa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSua);
            this.panel1.Controls.Add(this.textBoxTiecCuoi);
            this.panel1.Controls.Add(this.radioButtonMaKH);
            this.panel1.Controls.Add(this.buttonTim);
            this.panel1.Controls.Add(this.radioButtonMaDatTiec);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 423);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Tính tiền";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(491, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.Location = new System.Drawing.Point(615, 388);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 14;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewTraCuuTiecCuoi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Orange;
            this.groupBox1.Location = new System.Drawing.Point(10, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 247);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu đặt tiệc";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridViewTraCuuTiecCuoi
            // 
            this.dataGridViewTraCuuTiecCuoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTraCuuTiecCuoi.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewTraCuuTiecCuoi.Name = "dataGridViewTraCuuTiecCuoi";
            this.dataGridViewTraCuuTiecCuoi.Size = new System.Drawing.Size(702, 222);
            this.dataGridViewTraCuuTiecCuoi.TabIndex = 0;
            this.dataGridViewTraCuuTiecCuoi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTraCuuHopDong_CellContentClick);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXoa.Location = new System.Drawing.Point(491, 388);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 13;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(272, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tra Cứu Tiệc Cưới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(366, 388);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 12;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // textBoxTiecCuoi
            // 
            this.textBoxTiecCuoi.Location = new System.Drawing.Point(286, 52);
            this.textBoxTiecCuoi.Name = "textBoxTiecCuoi";
            this.textBoxTiecCuoi.Size = new System.Drawing.Size(177, 20);
            this.textBoxTiecCuoi.TabIndex = 1;
            // 
            // radioButtonMaKH
            // 
            this.radioButtonMaKH.AutoSize = true;
            this.radioButtonMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaKH.Location = new System.Drawing.Point(276, 78);
            this.radioButtonMaKH.Name = "radioButtonMaKH";
            this.radioButtonMaKH.Size = new System.Drawing.Size(120, 20);
            this.radioButtonMaKH.TabIndex = 4;
            this.radioButtonMaKH.TabStop = true;
            this.radioButtonMaKH.Text = "Mã Khách Hàng";
            this.radioButtonMaKH.UseVisualStyleBackColor = true;
            this.radioButtonMaKH.CheckedChanged += new System.EventHandler(this.radioButtonMaKH_CheckedChanged);
            // 
            // buttonTim
            // 
            this.buttonTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTim.Location = new System.Drawing.Point(615, 106);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(75, 23);
            this.buttonTim.TabIndex = 6;
            this.buttonTim.Text = "Tìm ";
            this.buttonTim.UseVisualStyleBackColor = true;
            this.buttonTim.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonMaDatTiec
            // 
            this.radioButtonMaDatTiec.AutoSize = true;
            this.radioButtonMaDatTiec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMaDatTiec.Location = new System.Drawing.Point(414, 78);
            this.radioButtonMaDatTiec.Name = "radioButtonMaDatTiec";
            this.radioButtonMaDatTiec.Size = new System.Drawing.Size(125, 20);
            this.radioButtonMaDatTiec.TabIndex = 5;
            this.radioButtonMaDatTiec.TabStop = true;
            this.radioButtonMaDatTiec.Text = "Tên Khách Hàng";
            this.radioButtonMaDatTiec.UseVisualStyleBackColor = true;
            this.radioButtonMaDatTiec.CheckedChanged += new System.EventHandler(this.radioButtonMaDatTiec_CheckedChanged);
            // 
            // TraCuuTiecCuoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 425);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTiecCuoi;
        private System.Windows.Forms.RadioButton radioButtonMaKH;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.RadioButton radioButtonMaDatTiec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.DataGridView dataGridViewTraCuuTiecCuoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}