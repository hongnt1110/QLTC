
namespace QLTC
{
    partial class DanhSachLoaiSanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaLoaiSanh = new System.Windows.Forms.Button();
            this.btnXoaLoaiSanh = new System.Windows.Forms.Button();
            this.btnThemLoaiSanh = new System.Windows.Forms.Button();
            this.danhSachLSanh = new System.Windows.Forms.DataGridView();
            this.btnHienThiLoaiSanh = new System.Windows.Forms.Button();
            this.btnTimLoaiSanh = new System.Windows.Forms.Button();
            this.timLoaiSanh = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLSanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "DANH SÁCH LOẠI SẢNH";
            // 
            // btnSuaLoaiSanh
            // 
            this.btnSuaLoaiSanh.BackColor = System.Drawing.Color.White;
            this.btnSuaLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaLoaiSanh.ForeColor = System.Drawing.Color.Orange;
            this.btnSuaLoaiSanh.Location = new System.Drawing.Point(241, 398);
            this.btnSuaLoaiSanh.Name = "btnSuaLoaiSanh";
            this.btnSuaLoaiSanh.Size = new System.Drawing.Size(106, 26);
            this.btnSuaLoaiSanh.TabIndex = 25;
            this.btnSuaLoaiSanh.Text = "Sửa";
            this.btnSuaLoaiSanh.UseVisualStyleBackColor = false;
            this.btnSuaLoaiSanh.UseWaitCursor = true;
            this.btnSuaLoaiSanh.Click += new System.EventHandler(this.btnSuaLoaiSanh_Click);
            // 
            // btnXoaLoaiSanh
            // 
            this.btnXoaLoaiSanh.BackColor = System.Drawing.Color.White;
            this.btnXoaLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaLoaiSanh.ForeColor = System.Drawing.Color.Orange;
            this.btnXoaLoaiSanh.Location = new System.Drawing.Point(129, 398);
            this.btnXoaLoaiSanh.Name = "btnXoaLoaiSanh";
            this.btnXoaLoaiSanh.Size = new System.Drawing.Size(106, 26);
            this.btnXoaLoaiSanh.TabIndex = 24;
            this.btnXoaLoaiSanh.Text = "Xóa";
            this.btnXoaLoaiSanh.UseVisualStyleBackColor = false;
            this.btnXoaLoaiSanh.UseWaitCursor = true;
            this.btnXoaLoaiSanh.Click += new System.EventHandler(this.btnXoaLoaiSanh_Click);
            // 
            // btnThemLoaiSanh
            // 
            this.btnThemLoaiSanh.BackColor = System.Drawing.Color.White;
            this.btnThemLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemLoaiSanh.ForeColor = System.Drawing.Color.Orange;
            this.btnThemLoaiSanh.Location = new System.Drawing.Point(17, 398);
            this.btnThemLoaiSanh.Name = "btnThemLoaiSanh";
            this.btnThemLoaiSanh.Size = new System.Drawing.Size(106, 26);
            this.btnThemLoaiSanh.TabIndex = 23;
            this.btnThemLoaiSanh.Text = "Thêm";
            this.btnThemLoaiSanh.UseVisualStyleBackColor = false;
            this.btnThemLoaiSanh.UseWaitCursor = true;
            this.btnThemLoaiSanh.Click += new System.EventHandler(this.btnThemLoaiSanh_Click);
            // 
            // danhSachLSanh
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachLSanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.danhSachLSanh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.danhSachLSanh.BackgroundColor = System.Drawing.Color.White;
            this.danhSachLSanh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.danhSachLSanh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Wheat;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachLSanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.danhSachLSanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachLSanh.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.danhSachLSanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.danhSachLSanh.GridColor = System.Drawing.Color.Orange;
            this.danhSachLSanh.Location = new System.Drawing.Point(17, 92);
            this.danhSachLSanh.Name = "danhSachLSanh";
            this.danhSachLSanh.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.danhSachLSanh.Size = new System.Drawing.Size(771, 300);
            this.danhSachLSanh.TabIndex = 22;
            this.danhSachLSanh.UseWaitCursor = true;
            // 
            // btnHienThiLoaiSanh
            // 
            this.btnHienThiLoaiSanh.BackColor = System.Drawing.Color.White;
            this.btnHienThiLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiLoaiSanh.ForeColor = System.Drawing.Color.Orange;
            this.btnHienThiLoaiSanh.Location = new System.Drawing.Point(575, 60);
            this.btnHienThiLoaiSanh.Name = "btnHienThiLoaiSanh";
            this.btnHienThiLoaiSanh.Size = new System.Drawing.Size(213, 26);
            this.btnHienThiLoaiSanh.TabIndex = 21;
            this.btnHienThiLoaiSanh.Text = "Hiển thị danh sách";
            this.btnHienThiLoaiSanh.UseVisualStyleBackColor = false;
            this.btnHienThiLoaiSanh.UseWaitCursor = true;
            this.btnHienThiLoaiSanh.Click += new System.EventHandler(this.btnHienThiLoaiSanh_Click);
            // 
            // btnTimLoaiSanh
            // 
            this.btnTimLoaiSanh.BackColor = System.Drawing.Color.White;
            this.btnTimLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimLoaiSanh.ForeColor = System.Drawing.Color.Orange;
            this.btnTimLoaiSanh.Location = new System.Drawing.Point(451, 60);
            this.btnTimLoaiSanh.Name = "btnTimLoaiSanh";
            this.btnTimLoaiSanh.Size = new System.Drawing.Size(118, 26);
            this.btnTimLoaiSanh.TabIndex = 20;
            this.btnTimLoaiSanh.Text = "Tìm kiếm";
            this.btnTimLoaiSanh.UseVisualStyleBackColor = false;
            this.btnTimLoaiSanh.UseWaitCursor = true;
            this.btnTimLoaiSanh.Click += new System.EventHandler(this.btnTimLoaiSanh_Click);
            // 
            // timLoaiSanh
            // 
            this.timLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timLoaiSanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.timLoaiSanh.Location = new System.Drawing.Point(17, 60);
            this.timLoaiSanh.Name = "timLoaiSanh";
            this.timLoaiSanh.Size = new System.Drawing.Size(428, 26);
            this.timLoaiSanh.TabIndex = 19;
            this.timLoaiSanh.Text = "Tìm kiếm theo tên loại sảnh";
            this.timLoaiSanh.UseWaitCursor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Orange;
            this.btnThoat.Location = new System.Drawing.Point(682, 398);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 26);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.UseWaitCursor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DanhSachLoaiSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaLoaiSanh);
            this.Controls.Add(this.btnXoaLoaiSanh);
            this.Controls.Add(this.btnThemLoaiSanh);
            this.Controls.Add(this.danhSachLSanh);
            this.Controls.Add(this.btnHienThiLoaiSanh);
            this.Controls.Add(this.btnTimLoaiSanh);
            this.Controls.Add(this.timLoaiSanh);
            this.Controls.Add(this.label1);
            this.Name = "DanhSachLoaiSanh";
            this.Text = "DanhSachLoaiSanh";
            ((System.ComponentModel.ISupportInitialize)(this.danhSachLSanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaLoaiSanh;
        private System.Windows.Forms.Button btnXoaLoaiSanh;
        private System.Windows.Forms.Button btnThemLoaiSanh;
        private System.Windows.Forms.DataGridView danhSachLSanh;
        private System.Windows.Forms.Button btnHienThiLoaiSanh;
        private System.Windows.Forms.Button btnTimLoaiSanh;
        private System.Windows.Forms.TextBox timLoaiSanh;
        private System.Windows.Forms.Button btnThoat;
    }
}