namespace GUI
{
    partial class frmDangNhap
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
            this.account = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textDangNhap = new System.Windows.Forms.TextBox();
            this.textMatKhau = new System.Windows.Forms.TextBox();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // account
            // 
            this.account.AutoSize = true;
            this.account.Location = new System.Drawing.Point(175, 68);
            this.account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(117, 17);
            this.account.TabIndex = 0;
            this.account.Text = "Tên Đăng Nhập: ";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(175, 102);
            this.password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(76, 17);
            this.password.TabIndex = 1;
            this.password.Text = "Mật Khẩu: ";
            // 
            // textDangNhap
            // 
            this.textDangNhap.Location = new System.Drawing.Point(303, 64);
            this.textDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.textDangNhap.MaxLength = 30;
            this.textDangNhap.Name = "textDangNhap";
            this.textDangNhap.Size = new System.Drawing.Size(184, 22);
            this.textDangNhap.TabIndex = 2;
            // 
            // textMatKhau
            // 
            this.textMatKhau.Location = new System.Drawing.Point(303, 98);
            this.textMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textMatKhau.MaxLength = 30;
            this.textMatKhau.Name = "textMatKhau";
            this.textMatKhau.Size = new System.Drawing.Size(184, 22);
            this.textMatKhau.TabIndex = 3;
            this.textMatKhau.UseSystemPasswordChar = true;
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Location = new System.Drawing.Point(303, 183);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(100, 28);
            this.buttonDangNhap.TabIndex = 4;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = true;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(461, 183);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 28);
            this.buttonThoat.TabIndex = 5;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.BackColor = System.Drawing.Color.Yellow;
            this.labelThongBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongBao.ForeColor = System.Drawing.Color.Red;
            this.labelThongBao.Location = new System.Drawing.Point(167, 139);
            this.labelThongBao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(296, 25);
            this.labelThongBao.TabIndex = 6;
            this.labelThongBao.Text = "Sai tên tài khoản hoặc mặt khẩu!";
            this.labelThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelThongBao.Visible = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.buttonDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 262);
            this.Controls.Add(this.labelThongBao);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.textMatKhau);
            this.Controls.Add(this.textDangNhap);
            this.Controls.Add(this.password);
            this.Controls.Add(this.account);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangNhap_FormClosing);
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.Enter += new System.EventHandler(this.buttonDangNhap_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label account;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textDangNhap;
        private System.Windows.Forms.TextBox textMatKhau;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelThongBao;
    }
}