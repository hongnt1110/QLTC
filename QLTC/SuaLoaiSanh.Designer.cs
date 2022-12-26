
namespace QLTC
{
    partial class SuaLoaiSanh
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.donGiaLoaiSanh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tenLoaiSanh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.maLoaiSanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(219, 234);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 29);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.White;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Orange;
            this.btnLuu.Location = new System.Drawing.Point(22, 234);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 29);
            this.btnLuu.TabIndex = 34;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(18, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Đơn giá:";
            // 
            // donGiaLoaiSanh
            // 
            this.donGiaLoaiSanh.BackColor = System.Drawing.Color.White;
            this.donGiaLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGiaLoaiSanh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.donGiaLoaiSanh.Location = new System.Drawing.Point(22, 190);
            this.donGiaLoaiSanh.Name = "donGiaLoaiSanh";
            this.donGiaLoaiSanh.Size = new System.Drawing.Size(301, 26);
            this.donGiaLoaiSanh.TabIndex = 32;
            this.donGiaLoaiSanh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.donGiaLoaiSanh_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(18, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Tên loại sảnh:";
            // 
            // tenLoaiSanh
            // 
            this.tenLoaiSanh.BackColor = System.Drawing.Color.White;
            this.tenLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenLoaiSanh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tenLoaiSanh.Location = new System.Drawing.Point(22, 125);
            this.tenLoaiSanh.Name = "tenLoaiSanh";
            this.tenLoaiSanh.Size = new System.Drawing.Size(301, 26);
            this.tenLoaiSanh.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã loại sảnh:";
            // 
            // maLoaiSanh
            // 
            this.maLoaiSanh.BackColor = System.Drawing.Color.Gainsboro;
            this.maLoaiSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLoaiSanh.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.maLoaiSanh.Location = new System.Drawing.Point(139, 60);
            this.maLoaiSanh.Name = "maLoaiSanh";
            this.maLoaiSanh.Size = new System.Drawing.Size(179, 26);
            this.maLoaiSanh.TabIndex = 28;
            this.maLoaiSanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "THÔNG TIN LOẠI SẢNH";
            // 
            // SuaLoaiSanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(347, 283);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.donGiaLoaiSanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tenLoaiSanh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maLoaiSanh);
            this.Controls.Add(this.label1);
            this.Name = "SuaLoaiSanh";
            this.Text = "SuaLoaiSanh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox donGiaLoaiSanh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tenLoaiSanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox maLoaiSanh;
        private System.Windows.Forms.Label label1;
    }
}