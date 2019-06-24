namespace GUI
{
    partial class frmThongTinTaiKhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.btnMatKhauHienAn = new System.Windows.Forms.Button();
            this.txtBoxMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtBoxMaNV = new System.Windows.Forms.TextBox();
            this.lblMaSo = new System.Windows.Forms.Label();
            this.txtBoxHoTen = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.btnMatKhauHienAn);
            this.panel1.Controls.Add(this.txtBoxMatKhau);
            this.panel1.Controls.Add(this.lblMatKhau);
            this.panel1.Controls.Add(this.txtBoxTaiKhoan);
            this.panel1.Controls.Add(this.lblTaiKhoan);
            this.panel1.Controls.Add(this.txtBoxMaNV);
            this.panel1.Controls.Add(this.lblMaSo);
            this.panel1.Controls.Add(this.txtBoxHoTen);
            this.panel1.Controls.Add(this.lblHoten);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(667, 280);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(547, 244);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 30);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(547, 185);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(115, 30);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.BtnDoiMatKhau_Click);
            // 
            // btnMatKhauHienAn
            // 
            this.btnMatKhauHienAn.Location = new System.Drawing.Point(400, 185);
            this.btnMatKhauHienAn.Name = "btnMatKhauHienAn";
            this.btnMatKhauHienAn.Size = new System.Drawing.Size(115, 30);
            this.btnMatKhauHienAn.TabIndex = 8;
            this.btnMatKhauHienAn.Text = "Hiện mật khẩu";
            this.btnMatKhauHienAn.UseVisualStyleBackColor = true;
            this.btnMatKhauHienAn.Click += new System.EventHandler(this.BtnMatKhauHienAn_Click);
            // 
            // txtBoxMatKhau
            // 
            this.txtBoxMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMatKhau.Location = new System.Drawing.Point(101, 185);
            this.txtBoxMatKhau.Name = "txtBoxMatKhau";
            this.txtBoxMatKhau.ReadOnly = true;
            this.txtBoxMatKhau.Size = new System.Drawing.Size(272, 30);
            this.txtBoxMatKhau.TabIndex = 7;
            this.txtBoxMatKhau.UseSystemPasswordChar = true;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.Location = new System.Drawing.Point(3, 188);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(88, 22);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtBoxTaiKhoan
            // 
            this.txtBoxTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTaiKhoan.Location = new System.Drawing.Point(101, 121);
            this.txtBoxTaiKhoan.Name = "txtBoxTaiKhoan";
            this.txtBoxTaiKhoan.ReadOnly = true;
            this.txtBoxTaiKhoan.Size = new System.Drawing.Size(272, 30);
            this.txtBoxTaiKhoan.TabIndex = 5;
            this.txtBoxTaiKhoan.TextChanged += new System.EventHandler(this.TxtBoxTaiKhoan_TextChanged);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(3, 124);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(94, 22);
            this.lblTaiKhoan.TabIndex = 4;
            this.lblTaiKhoan.Text = "Tài khoản:";
            this.lblTaiKhoan.Click += new System.EventHandler(this.LblTaiKhoan_Click);
            // 
            // txtBoxMaNV
            // 
            this.txtBoxMaNV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMaNV.Location = new System.Drawing.Point(101, 60);
            this.txtBoxMaNV.Name = "txtBoxMaNV";
            this.txtBoxMaNV.ReadOnly = true;
            this.txtBoxMaNV.Size = new System.Drawing.Size(272, 30);
            this.txtBoxMaNV.TabIndex = 3;
            // 
            // lblMaSo
            // 
            this.lblMaSo.AutoSize = true;
            this.lblMaSo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSo.Location = new System.Drawing.Point(3, 63);
            this.lblMaSo.Name = "lblMaSo";
            this.lblMaSo.Size = new System.Drawing.Size(65, 22);
            this.lblMaSo.TabIndex = 2;
            this.lblMaSo.Text = "Mã số:";
            // 
            // txtBoxHoTen
            // 
            this.txtBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoTen.Location = new System.Drawing.Point(101, 1);
            this.txtBoxHoTen.Name = "txtBoxHoTen";
            this.txtBoxHoTen.ReadOnly = true;
            this.txtBoxHoTen.Size = new System.Drawing.Size(414, 30);
            this.txtBoxHoTen.TabIndex = 1;
            this.txtBoxHoTen.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(3, 4);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(92, 22);
            this.lblHoten.TabIndex = 0;
            this.lblHoten.Text = "Họ và tên:";
            // 
            // frmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 298);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongTinTaiKhoan";
            this.Text = "Thông tin tài khoản";
            this.Load += new System.EventHandler(this.FrmThongTinTaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxHoTen;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtBoxTaiKhoan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtBoxMaNV;
        private System.Windows.Forms.Label lblMaSo;
        private System.Windows.Forms.TextBox txtBoxMatKhau;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Button btnMatKhauHienAn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}