using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using DTO;
using BUS;
using DAL;

namespace GUI
{
    public partial class frmThemXe : Form 
    {
        BUS_KhachHang buskh = new BUS_KhachHang();
        BUS_ThemXe busxe = new BUS_ThemXe();
        public frmThemXe()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            DTO_KhachHang kh = new DTO_KhachHang(textBoxTenKH.Text, textBoxDienThoai.Text, textBoxDiaChi.Text, 0);
                if (buskh.ThemKhachHang(kh))
                {
                    DAL_KhachHang layttkh = new DAL_KhachHang();
                    DataTable dt = layttkh.LayMaKH(textBoxTenKH.Text, textBoxDienThoai.Text);
                    DateTime now = DateTime.Now;
                    int imakh = int.Parse(dt.Rows[0]["MaKH"].ToString());
                    DTO_Xe xe = new DTO_Xe(imakh, textBoxBienSo.Text, comboBoxHieuXe.Text, now);
                    if (busxe.ThemXe(xe))
                    {
                        MessageBox.Show("Thêm xe thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm xe không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng không thành công hoặc khách hàng đã có sẵn trong hệ thống");
                }   
        }

        private void frmThemXe_Load(object sender, EventArgs e)
        {

        }
    }
}
