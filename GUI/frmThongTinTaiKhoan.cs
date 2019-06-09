using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void LblTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnMatKhauHienAn_Click(object sender, EventArgs e)
        {
            if (txtBoxMatKhau.UseSystemPasswordChar)
                btnMatKhauHienAn.Text = "Hiện mật khẩu";
            else
                btnMatKhauHienAn.Text = "Ẩn mật khẩu";
            txtBoxMatKhau.UseSystemPasswordChar = !txtBoxMatKhau.UseSystemPasswordChar;
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDoiMatKhau_Click(object sender, EventArgs e)
        {
            frmThayDoiMatKhau tdmk = new frmThayDoiMatKhau();
            tdmk.ShowDialog();
        }
    }
}
