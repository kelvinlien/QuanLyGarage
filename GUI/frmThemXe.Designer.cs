namespace GUI
{
    partial class frmThemXe
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
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.labelBienSo = new System.Windows.Forms.Label();
            this.comboBoxHieuXe = new System.Windows.Forms.ComboBox();
            this.labelHieuXe = new System.Windows.Forms.Label();
            this.textBoxBienSo = new System.Windows.Forms.TextBox();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelDienThoai = new System.Windows.Forms.Label();
            this.textBoxDienThoai = new System.Windows.Forms.TextBox();
            this.textBoxTenKH = new System.Windows.Forms.TextBox();
            this.labelTenKhachHang = new System.Windows.Forms.Label();
            this.dTOKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dTOKhachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.BackColor = System.Drawing.SystemColors.Control;
            this.labelTieuDe.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTieuDe.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTieuDe.Location = new System.Drawing.Point(227, 21);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(391, 27);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "THÊM THÔNG TIN KHÁCH HÀNG VÀ XE";
            // 
            // labelBienSo
            // 
            this.labelBienSo.AutoSize = true;
            this.labelBienSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelBienSo.Location = new System.Drawing.Point(428, 62);
            this.labelBienSo.Name = "labelBienSo";
            this.labelBienSo.Size = new System.Drawing.Size(64, 19);
            this.labelBienSo.TabIndex = 4;
            this.labelBienSo.Text = "Biển Số: ";
            // 
            // comboBoxHieuXe
            // 
            this.comboBoxHieuXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHieuXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxHieuXe.FormattingEnabled = true;
            this.comboBoxHieuXe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxHieuXe.Items.AddRange(new object[] {
            "Dream",
            "Innova",
            "Honda"});
            this.comboBoxHieuXe.Location = new System.Drawing.Point(504, 97);
            this.comboBoxHieuXe.Name = "comboBoxHieuXe";
            this.comboBoxHieuXe.Size = new System.Drawing.Size(194, 27);
            this.comboBoxHieuXe.TabIndex = 4;
            // 
            // labelHieuXe
            // 
            this.labelHieuXe.AutoSize = true;
            this.labelHieuXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelHieuXe.Location = new System.Drawing.Point(428, 99);
            this.labelHieuXe.Name = "labelHieuXe";
            this.labelHieuXe.Size = new System.Drawing.Size(66, 19);
            this.labelHieuXe.TabIndex = 6;
            this.labelHieuXe.Text = "Hiệu Xe: ";
            // 
            // textBoxBienSo
            // 
            this.textBoxBienSo.AllowDrop = true;
            this.textBoxBienSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxBienSo.Location = new System.Drawing.Point(504, 60);
            this.textBoxBienSo.MaxLength = 10;
            this.textBoxBienSo.Name = "textBoxBienSo";
            this.textBoxBienSo.Size = new System.Drawing.Size(194, 26);
            this.textBoxBienSo.TabIndex = 3;
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(519, 179);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 7;
            this.buttonThem.Text = "THÊM";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(658, 179);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "THOÁT";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelDienThoai
            // 
            this.labelDienThoai.AutoSize = true;
            this.labelDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDienThoai.Location = new System.Drawing.Point(40, 101);
            this.labelDienThoai.Name = "labelDienThoai";
            this.labelDienThoai.Size = new System.Drawing.Size(82, 19);
            this.labelDienThoai.TabIndex = 2;
            this.labelDienThoai.Text = "Điện Thoại: ";
            // 
            // textBoxDienThoai
            // 
            this.textBoxDienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDienThoai.Location = new System.Drawing.Point(162, 99);
            this.textBoxDienThoai.MaxLength = 10;
            this.textBoxDienThoai.Name = "textBoxDienThoai";
            this.textBoxDienThoai.Size = new System.Drawing.Size(194, 26);
            this.textBoxDienThoai.TabIndex = 1;
            // 
            // textBoxTenKH
            // 
            this.textBoxTenKH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxTenKH.Location = new System.Drawing.Point(162, 60);
            this.textBoxTenKH.MaxLength = 30;
            this.textBoxTenKH.Name = "textBoxTenKH";
            this.textBoxTenKH.Size = new System.Drawing.Size(194, 26);
            this.textBoxTenKH.TabIndex = 0;
            // 
            // labelTenKhachHang
            // 
            this.labelTenKhachHang.AutoSize = true;
            this.labelTenKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelTenKhachHang.Location = new System.Drawing.Point(36, 62);
            this.labelTenKhachHang.Name = "labelTenKhachHang";
            this.labelTenKhachHang.Size = new System.Drawing.Size(119, 19);
            this.labelTenKhachHang.TabIndex = 1;
            this.labelTenKhachHang.Text = "Tên Khách Hàng: ";
            // 
            // dTOKhachHangBindingSource
            // 
            this.dTOKhachHangBindingSource.DataSource = typeof(DTO.DTO_KhachHang);
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelDiaChi.Location = new System.Drawing.Point(40, 140);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(62, 19);
            this.labelDiaChi.TabIndex = 3;
            this.labelDiaChi.Text = "Địa Chỉ: ";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBoxDiaChi.Location = new System.Drawing.Point(162, 138);
            this.textBoxDiaChi.MaxLength = 100;
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(194, 26);
            this.textBoxDiaChi.TabIndex = 2;
            // 
            // frmThemXe
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 223);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.textBoxBienSo);
            this.Controls.Add(this.labelHieuXe);
            this.Controls.Add(this.comboBoxHieuXe);
            this.Controls.Add(this.labelBienSo);
            this.Controls.Add(this.textBoxDiaChi);
            this.Controls.Add(this.textBoxDienThoai);
            this.Controls.Add(this.textBoxTenKH);
            this.Controls.Add(this.labelDiaChi);
            this.Controls.Add(this.labelDienThoai);
            this.Controls.Add(this.labelTenKhachHang);
            this.Controls.Add(this.labelTieuDe);
            this.Name = "frmThemXe";
            this.Text = "frmThemXe";
            this.Load += new System.EventHandler(this.frmThemXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dTOKhachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.Label labelBienSo;
        private System.Windows.Forms.ComboBox comboBoxHieuXe;
        private System.Windows.Forms.Label labelHieuXe;
        private System.Windows.Forms.TextBox textBoxBienSo;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelDienThoai;
        private System.Windows.Forms.TextBox textBoxDienThoai;
        private System.Windows.Forms.TextBox textBoxTenKH;
        private System.Windows.Forms.Label labelTenKhachHang;
        private System.Windows.Forms.BindingSource dTOKhachHangBindingSource;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.TextBox textBoxDiaChi;
    }
}