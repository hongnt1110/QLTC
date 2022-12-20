
namespace QLTC
{
    partial class DanhSachDoanhSo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maDoanhSoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayLapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDoanhThuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOANHSOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDichVu = new QLTC.DataDichVu();
            this.dOANHSOTableAdapter = new QLTC.DataDichVuTableAdapters.DOANHSOTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHSOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDoanhSoDataGridViewTextBoxColumn,
            this.ngayLapDataGridViewTextBoxColumn,
            this.thangDataGridViewTextBoxColumn,
            this.tongDoanhThuDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dOANHSOBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // maDoanhSoDataGridViewTextBoxColumn
            // 
            this.maDoanhSoDataGridViewTextBoxColumn.DataPropertyName = "MaDoanhSo";
            this.maDoanhSoDataGridViewTextBoxColumn.HeaderText = "MaDoanhSo";
            this.maDoanhSoDataGridViewTextBoxColumn.Name = "maDoanhSoDataGridViewTextBoxColumn";
            this.maDoanhSoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayLapDataGridViewTextBoxColumn
            // 
            this.ngayLapDataGridViewTextBoxColumn.DataPropertyName = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.HeaderText = "NgayLap";
            this.ngayLapDataGridViewTextBoxColumn.Name = "ngayLapDataGridViewTextBoxColumn";
            // 
            // thangDataGridViewTextBoxColumn
            // 
            this.thangDataGridViewTextBoxColumn.DataPropertyName = "Thang";
            this.thangDataGridViewTextBoxColumn.HeaderText = "Thang";
            this.thangDataGridViewTextBoxColumn.Name = "thangDataGridViewTextBoxColumn";
            // 
            // tongDoanhThuDataGridViewTextBoxColumn
            // 
            this.tongDoanhThuDataGridViewTextBoxColumn.DataPropertyName = "TongDoanhThu";
            this.tongDoanhThuDataGridViewTextBoxColumn.HeaderText = "TongDoanhThu";
            this.tongDoanhThuDataGridViewTextBoxColumn.Name = "tongDoanhThuDataGridViewTextBoxColumn";
            // 
            // dOANHSOBindingSource
            // 
            this.dOANHSOBindingSource.DataMember = "DOANHSO";
            this.dOANHSOBindingSource.DataSource = this.dataDichVu;
            // 
            // dataDichVu
            // 
            this.dataDichVu.DataSetName = "DataDichVu";
            this.dataDichVu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dOANHSOTableAdapter
            // 
            this.dOANHSOTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "THỐNG KÊ DOANH THU THÁNG";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Orange;
            this.btnExit.Location = new System.Drawing.Point(509, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 26);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DanhSachDoanhSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(725, 389);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachDoanhSo";
            this.Text = "DanhSachDoanhSo";
            this.Load += new System.EventHandler(this.DanhSachDoanhSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHSOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataDichVu dataDichVu;
        private System.Windows.Forms.BindingSource dOANHSOBindingSource;
        private DataDichVuTableAdapters.DOANHSOTableAdapter dOANHSOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoanhSoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDoanhThuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
    }
}