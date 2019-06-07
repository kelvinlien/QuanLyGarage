namespace GUI
{
    partial class frmGiaoDienChinh
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
            this.buttonThemXe = new System.Windows.Forms.Button();
            this.buttonHoaDon = new System.Windows.Forms.Button();
            this.buttonKho = new System.Windows.Forms.Button();
            this.dataXe = new System.Windows.Forms.DataGridView();
            this.buttonDuyetXe = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataXe)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThemXe
            // 
            this.buttonThemXe.Location = new System.Drawing.Point(69, 102);
            this.buttonThemXe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThemXe.Name = "buttonThemXe";
            this.buttonThemXe.Size = new System.Drawing.Size(181, 28);
            this.buttonThemXe.TabIndex = 2;
            this.buttonThemXe.Text = "Thêm Xe";
            this.buttonThemXe.UseVisualStyleBackColor = true;
            this.buttonThemXe.Click += new System.EventHandler(this.buttonThemXe_Click);
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.Location = new System.Drawing.Point(69, 177);
            this.buttonHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(181, 28);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "In Hóa Đơn";
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            // 
            // buttonKho
            // 
            this.buttonKho.Location = new System.Drawing.Point(69, 256);
            this.buttonKho.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKho.Name = "buttonKho";
            this.buttonKho.Size = new System.Drawing.Size(181, 28);
            this.buttonKho.TabIndex = 4;
            this.buttonKho.Text = "Kho";
            this.buttonKho.UseVisualStyleBackColor = true;
            // 
            // dataXe
            // 
            this.dataXe.AllowUserToAddRows = false;
            this.dataXe.AllowUserToDeleteRows = false;
            this.dataXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXe.Location = new System.Drawing.Point(299, 30);
            this.dataXe.Margin = new System.Windows.Forms.Padding(4);
            this.dataXe.Name = "dataXe";
            this.dataXe.ReadOnly = true;
            this.dataXe.RowHeadersWidth = 51;
            this.dataXe.Size = new System.Drawing.Size(724, 255);
            this.dataXe.TabIndex = 4;
            this.dataXe.TabStop = false;
            this.dataXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataXe_CellContentClick);
            // 
            // buttonDuyetXe
            // 
            this.buttonDuyetXe.Location = new System.Drawing.Point(69, 30);
            this.buttonDuyetXe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDuyetXe.Name = "buttonDuyetXe";
            this.buttonDuyetXe.Size = new System.Drawing.Size(181, 28);
            this.buttonDuyetXe.TabIndex = 0;
            this.buttonDuyetXe.Text = "Duyệt Xe";
            this.buttonDuyetXe.UseVisualStyleBackColor = true;
            this.buttonDuyetXe.Click += new System.EventHandler(this.buttonDuyetXe_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(859, 330);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(164, 28);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 503);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDuyetXe);
            this.Controls.Add(this.dataXe);
            this.Controls.Add(this.buttonKho);
            this.Controls.Add(this.buttonHoaDon);
            this.Controls.Add(this.buttonThemXe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmGiaoDienChinh";
            this.Text = "Phần mềm quản lý garage";
            this.Load += new System.EventHandler(this.frmGiaoDienChinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonThemXe;
        private System.Windows.Forms.Button buttonHoaDon;
        private System.Windows.Forms.Button buttonKho;
        private System.Windows.Forms.DataGridView dataXe;
        private System.Windows.Forms.Button buttonDuyetXe;
        private System.Windows.Forms.Button buttonThoat;
    }
}