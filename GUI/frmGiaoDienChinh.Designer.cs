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
            this.buttonThemXe.Location = new System.Drawing.Point(52, 83);
            this.buttonThemXe.Name = "buttonThemXe";
            this.buttonThemXe.Size = new System.Drawing.Size(136, 23);
            this.buttonThemXe.TabIndex = 2;
            this.buttonThemXe.Text = "Thêm Xe";
            this.buttonThemXe.UseVisualStyleBackColor = true;
            this.buttonThemXe.Click += new System.EventHandler(this.buttonThemXe_Click);
            // 
            // buttonHoaDon
            // 
            this.buttonHoaDon.Location = new System.Drawing.Point(52, 144);
            this.buttonHoaDon.Name = "buttonHoaDon";
            this.buttonHoaDon.Size = new System.Drawing.Size(136, 23);
            this.buttonHoaDon.TabIndex = 3;
            this.buttonHoaDon.Text = "In Hóa Đơn";
            this.buttonHoaDon.UseVisualStyleBackColor = true;
            // 
            // buttonKho
            // 
            this.buttonKho.Location = new System.Drawing.Point(52, 208);
            this.buttonKho.Name = "buttonKho";
            this.buttonKho.Size = new System.Drawing.Size(136, 23);
            this.buttonKho.TabIndex = 4;
            this.buttonKho.Text = "Kho";
            this.buttonKho.UseVisualStyleBackColor = true;
            // 
            // dataXe
            // 
            this.dataXe.AllowUserToAddRows = false;
            this.dataXe.AllowUserToDeleteRows = false;
            this.dataXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataXe.Location = new System.Drawing.Point(224, 24);
            this.dataXe.Name = "dataXe";
            this.dataXe.ReadOnly = true;
            this.dataXe.Size = new System.Drawing.Size(543, 207);
            this.dataXe.TabIndex = 4;
            this.dataXe.TabStop = false;
            // 
            // buttonDuyetXe
            // 
            this.buttonDuyetXe.Location = new System.Drawing.Point(52, 24);
            this.buttonDuyetXe.Name = "buttonDuyetXe";
            this.buttonDuyetXe.Size = new System.Drawing.Size(136, 23);
            this.buttonDuyetXe.TabIndex = 0;
            this.buttonDuyetXe.Text = "Duyệt Xe";
            this.buttonDuyetXe.UseVisualStyleBackColor = true;
            this.buttonDuyetXe.Click += new System.EventHandler(this.buttonDuyetXe_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(644, 268);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(123, 23);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // frmGiaoDienChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 303);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDuyetXe);
            this.Controls.Add(this.dataXe);
            this.Controls.Add(this.buttonKho);
            this.Controls.Add(this.buttonHoaDon);
            this.Controls.Add(this.buttonThemXe);
            this.MaximizeBox = false;
            this.Name = "frmGiaoDienChinh";
            this.Text = "Gara";
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