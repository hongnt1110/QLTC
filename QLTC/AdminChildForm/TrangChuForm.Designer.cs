namespace QLTC.AdminChildForm
{
    partial class TrangChuForm
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
            this.lbTrangChu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTrangChu
            // 
            this.lbTrangChu.AutoSize = true;
            this.lbTrangChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangChu.Location = new System.Drawing.Point(174, 155);
            this.lbTrangChu.Name = "lbTrangChu";
            this.lbTrangChu.Size = new System.Drawing.Size(437, 95);
            this.lbTrangChu.TabIndex = 0;
            this.lbTrangChu.Text = "Trang Chủ";
            // 
            // TrangChuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTrangChu);
            this.Name = "TrangChuForm";
            this.Text = "TrangChuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTrangChu;
    }
}