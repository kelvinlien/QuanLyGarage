using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAO;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (textDangNhap.Text.Length == 0)
            {
                labelThongBao.Text = "Vui lòng nhập tài khoản!";
                labelThongBao.Visible = true;
            }
            else if (textMatKhau.Text.Length == 0)
            {
                labelThongBao.Text = "Vui lòng nhập mật khẩu!";
                labelThongBao.Visible = true;
            }
            else
            {
                string TaiKhoan = textDangNhap.Text;
                string MatKhau = textMatKhau.Text;
                if (DangNhap(TaiKhoan, MatKhau))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                    frmMain f = new frmMain();
                    this.Hide();
                    f.ShowDialog();
                    labelThongBao.Visible = false;
                    this.Show();
                }
                else
                {
                    labelThongBao.Text = "Vui lòng kiểm tra lại tên hoặc mật khẩu!";
                    labelThongBao.Visible = true;
                }

            }
        }
        
        bool DangNhap(string TaiKhoan, string MatKhau)
        {
            return TaiKhoanDAO.Instance.DangNhap(TaiKhoan,MatKhau);
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Đóng ứng dụng?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void TextDangNhap_TextChanged(object sender, EventArgs e)
        {
            labelThongBao.Visible = false;
        }

        private void TextMatKhau_TextChanged(object sender, EventArgs e)
        {
            labelThongBao.Visible = false;
        }
    }
}
