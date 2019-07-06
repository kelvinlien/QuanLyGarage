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
            this.txtBoxQuyenHan = new System.Windows.Forms.TextBox();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.txtBoxTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblQuyenHan = new System.Windows.Forms.Label();
            this.txtBoxHoTen = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Controls.Add(this.txtBoxQuyenHan);
            this.panel1.Controls.Add(this.lblTaiKhoan);
            this.panel1.Controls.Add(this.txtBoxTaiKhoan);
            this.panel1.Controls.Add(this.lblQuyenHan);
            this.panel1.Controls.Add(this.txtBoxHoTen);
            this.panel1.Controls.Add(this.lblHoten);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 158);
            this.panel1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(333, 106);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(162, 40);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(333, 56);
            this.btnDoiMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(162, 41);
            this.btnDoiMatKhau.TabIndex = 9;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.BtnDoiMatKhau_Click);
            // 
            // txtBoxQuyenHan
            // 
            this.txtBoxQuyenHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQuyenHan.Location = new System.Drawing.Point(76, 113);
            this.txtBoxQuyenHan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxQuyenHan.Name = "txtBoxQuyenHan";
            this.txtBoxQuyenHan.ReadOnly = true;
            this.txtBoxQuyenHan.Size = new System.Drawing.Size(205, 26);
            this.txtBoxQuyenHan.TabIndex = 5;
            this.txtBoxQuyenHan.TextChanged += new System.EventHandler(this.TxtBoxTaiKhoan_TextChanged);
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaiKhoan.Location = new System.Drawing.Point(2, 66);
            this.lblTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(72, 19);
            this.lblTaiKhoan.TabIndex = 4;
            this.lblTaiKhoan.Text = "Tài khoản:";
            this.lblTaiKhoan.Click += new System.EventHandler(this.LblTaiKhoan_Click);
            // 
            // txtBoxTaiKhoan
            // 
            this.txtBoxTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTaiKhoan.Location = new System.Drawing.Point(76, 63);
            this.txtBoxTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxTaiKhoan.Name = "txtBoxTaiKhoan";
            this.txtBoxTaiKhoan.ReadOnly = true;
            this.txtBoxTaiKhoan.Size = new System.Drawing.Size(205, 26);
            this.txtBoxTaiKhoan.TabIndex = 3;
            // 
            // lblQuyenHan
            // 
            this.lblQuyenHan.AutoSize = true;
            this.lblQuyenHan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyenHan.Location = new System.Drawing.Point(2, 116);
            this.lblQuyenHan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuyenHan.Name = "lblQuyenHan";
            this.lblQuyenHan.Size = new System.Drawing.Size(81, 19);
            this.lblQuyenHan.TabIndex = 2;
            this.lblQuyenHan.Text = "Quyền hạn: ";
            // 
            // txtBoxHoTen
            // 
            this.txtBoxHoTen.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHoTen.Location = new System.Drawing.Point(76, 15);
            this.txtBoxHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBoxHoTen.Name = "txtBoxHoTen";
            this.txtBoxHoTen.ReadOnly = true;
            this.txtBoxHoTen.Size = new System.Drawing.Size(312, 26);
            this.txtBoxHoTen.TabIndex = 1;
            this.txtBoxHoTen.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoten.Location = new System.Drawing.Point(3, 18);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(71, 19);
            this.lblHoten.TabIndex = 0;
            this.lblHoten.Text = "Họ và tên:";
            // 
            // frmThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 174);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox txtBoxQuyenHan;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.TextBox txtBoxTaiKhoan;
        private System.Windows.Forms.Label lblQuyenHan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
    }
}