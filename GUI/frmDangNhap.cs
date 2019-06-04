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

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        BUS_DangNhap busDN = new BUS.BUS_DangNhap();
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
            else if (textDangNhap.Text.Length > 20)
            {
                labelThongBao.Text = "Tài khoản gồm 20 kí tự trở xuống!";
                labelThongBao.Visible = true;
            }
            else if (textMatKhau.Text.Length == 0)
            {
                labelThongBao.Text = "Vui lòng nhập mật khẩu!";
                labelThongBao.Visible = true;
            }
            else if (textMatKhau.Text.Length > 20)
            {
                labelThongBao.Text = "Mật khẩu gồm 20 kí tự trở xuống!";
                labelThongBao.Visible = true;
            }
            else
            {
                DTO_DangNhap dn = new DTO_DangNhap(textDangNhap.Text, textMatKhau.Text);
                if (busDN.checkDangNhap(dn) == true)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo");
                    frmGiaoDienChinh f = new frmGiaoDienChinh();
                    f.ShowDialog();
                    labelThongBao.Visible = false;                 
                }
                else
                {
                    labelThongBao.Visible = true;
                }

            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
