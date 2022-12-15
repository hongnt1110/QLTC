
namespace QLTC
{
    partial class ThemSanh
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.donGiaBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenSanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loaiSanh = new System.Windows.Forms.ComboBox();
            this.lOAISANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDichVu = new QLTC.DataDichVu();
            this.label6 = new System.Windows.Forms.Label();
            this.soLuongBan = new System.Windows.Forms.TextBox();
            this.lOAISANHTableAdapter = new QLTC.DataDichVuTableAdapters.LOAISANHTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.ghiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(220, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 29);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Orange;
            this.btnThem.Location = new System.Drawing.Point(23, 383);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 29);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(19, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Đơn giá bàn tối thiểu:";
            // 
            // donGiaBan
            // 
            this.donGiaBan.BackColor = System.Drawing.Color.White;
            this.donGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaBan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.donGiaBan.Location = new System.Drawing.Point(23, 229);
            this.donGiaBan.Name = "donGiaBan";
            this.donGiaBan.Size = new System.Drawing.Size(301, 26);
            this.donGiaBan.TabIndex = 14;
            this.donGiaBan.Text = "Nhập đơn giá bàn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(19, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên sảnh:";
            // 
            // tenSanh
            // 
            this.tenSanh.BackColor = System.Drawing.Color.White;
            this.tenSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenSanh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tenSanh.Location = new System.Drawing.Point(23, 74);
            this.tenSanh.Name = "tenSanh";
            this.tenSanh.Size = new System.Drawing.Size(301, 26);
            this.tenSanh.TabIndex = 12;
            this.tenSanh.Text = "Nhập tên sảnh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "THÊM SẢNH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(19, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Loại sảnh:";
            // 
            // loaiSanh
            // 
            this.loaiSanh.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lOAISANHBindingSource, "MaLoaiSanh", true));
            this.loaiSanh.DataSource = this.lOAISANHBindingSource;
            this.loaiSanh.DisplayMember = "LoaiSanh";
            this.loaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loaiSanh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.loaiSanh.FormattingEnabled = true;
            this.loaiSanh.Location = new System.Drawing.Point(117, 113);
            this.loaiSanh.Name = "loaiSanh";
            this.loaiSanh.Size = new System.Drawing.Size(207, 28);
            this.loaiSanh.TabIndex = 19;
            this.loaiSanh.TabStop = false;
            this.loaiSanh.ValueMember = "MaLoaiSanh";
            // 
            // lOAISANHBindingSource
            // 
            this.lOAISANHBindingSource.DataMember = "LOAISANH";
            this.lOAISANHBindingSource.DataSource = this.dataDichVu;
            // 
            // dataDichVu
            // 
            this.dataDichVu.DataSetName = "DataDichVu";
            this.dataDichVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(19, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "Số lượng bàn tối đa:";
            // 
            // soLuongBan
            // 
            this.soLuongBan.BackColor = System.Drawing.Color.White;
            this.soLuongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuongBan.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.soLuongBan.Location = new System.Drawing.Point(195, 159);
            this.soLuongBan.Name = "soLuongBan";
            this.soLuongBan.Size = new System.Drawing.Size(129, 26);
            this.soLuongBan.TabIndex = 20;
            this.soLuongBan.Text = "Nhập số lượng";
            // 
            // lOAISANHTableAdapter
            // 
            this.lOAISANHTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(19, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Ghi chú:";
            // 
            // ghiChu
            // 
            this.ghiChu.BackColor = System.Drawing.Color.White;
            this.ghiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ghiChu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.ghiChu.Location = new System.Drawing.Point(23, 291);
            this.ghiChu.Multiline = true;
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.Size = new System.Drawing.Size(301, 86);
            this.ghiChu.TabIndex = 22;
            this.ghiChu.Text = "Nhập ghi chú";
            // 
            // ThemSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(347, 424);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ghiChu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.soLuongBan);
            this.Controls.Add(this.loaiSanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.donGiaBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenSanh);
            this.Controls.Add(this.label1);
            this.Name = "ThemSanh";
            this.Text = "ThemSanh";
            this.Load += new System.EventHandler(this.ThemSanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox donGiaBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenSanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox loaiSanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox soLuongBan;
        private DataDichVu dataDichVu;
        private System.Windows.Forms.BindingSource lOAISANHBindingSource;
        private DataDichVuTableAdapters.LOAISANHTableAdapter lOAISANHTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ghiChu;
    }
}