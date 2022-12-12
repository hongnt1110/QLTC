namespace QLTC.AdminChildForm
{
    partial class TiecCuoiForm
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
            this.lbTiecCuoi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTiecCuoi
            // 
            this.lbTiecCuoi.AutoSize = true;
            this.lbTiecCuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiecCuoi.Location = new System.Drawing.Point(27, 116);
            this.lbTiecCuoi.Name = "lbTiecCuoi";
            this.lbTiecCuoi.Size = new System.Drawing.Size(784, 189);
            this.lbTiecCuoi.TabIndex = 0;
            this.lbTiecCuoi.Text = "Tiệc Cưới";
            // 
            // TiecCuoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTiecCuoi);
            this.Name = "TiecCuoiForm";
            this.Text = "TiecCuoiForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTiecCuoi;
    }
}