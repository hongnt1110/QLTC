namespace QLTC
{
    partial class LapBaoCao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.doanhthu = new System.Windows.Forms.TextBox();
            this.soluongtiec = new System.Windows.Forms.TextBox();
            this.tennguoilap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.thang = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.thang);
            this.groupBox1.Controls.Add(this.doanhthu);
            this.groupBox1.Controls.Add(this.soluongtiec);
            this.groupBox1.Controls.Add(this.tennguoilap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ngaylap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(131, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // doanhthu
            // 
            this.doanhthu.Location = new System.Drawing.Point(469, 94);
            this.doanhthu.Name = "doanhthu";
            this.doanhthu.Size = new System.Drawing.Size(147, 23);
            this.doanhthu.TabIndex = 9;
            this.doanhthu.TextChanged += new System.EventHandler(this.doanhthu_TextChanged);
            this.doanhthu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.doanhthu_KeyPress);
            // 
            // soluongtiec
            // 
            this.soluongtiec.Location = new System.Drawing.Point(166, 91);
            this.soluongtiec.Name = "soluongtiec";
            this.soluongtiec.Size = new System.Drawing.Size(147, 23);
            this.soluongtiec.TabIndex = 8;
            this.soluongtiec.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.soluongtiec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soluongtiec_KeyPress);
            // 
            // tennguoilap
            // 
            this.tennguoilap.Location = new System.Drawing.Point(469, 45);
            this.tennguoilap.Name = "tennguoilap";
            this.tennguoilap.Size = new System.Drawing.Size(147, 23);
            this.tennguoilap.TabIndex = 6;
            this.tennguoilap.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tennguoilap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tennguoilap_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Location = new System.Drawing.Point(361, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Doanh thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(41, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số lượng tiệc";
            // 
            // ngaylap
            // 
            this.ngaylap.CustomFormat = "dd/MM/yyyy  ";
            this.ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ngaylap.Location = new System.Drawing.Point(166, 45);
            this.ngaylap.MaxDate = new System.DateTime(3000, 12, 31, 14, 6, 0, 0);
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.Size = new System.Drawing.Size(147, 23);
            this.ngaylap.TabIndex = 3;
            this.ngaylap.Value = new System.DateTime(2022, 12, 14, 0, 0, 0, 0);
            this.ngaylap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label3.Location = new System.Drawing.Point(41, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Location = new System.Drawing.Point(361, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người lập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày lập";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(521, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lưu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(719, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(380, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lập Báo Cáo";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(623, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Nhập lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // thang
            // 
            this.thang.Location = new System.Drawing.Point(166, 132);
            this.thang.Name = "thang";
            this.thang.Size = new System.Drawing.Size(147, 23);
            this.thang.TabIndex = 10;
            this.thang.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thang_KeyPress_1);
            // 
            // LapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 572);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "LapBaoCao";
            this.Text = "LapBaoCao";
            this.Load += new System.EventHandler(this.LapBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker ngaylap;
        private System.Windows.Forms.TextBox doanhthu;
        private System.Windows.Forms.TextBox soluongtiec;
        private System.Windows.Forms.TextBox tennguoilap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox thang;
    }
}