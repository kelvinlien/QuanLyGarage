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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void ThôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan tttk = new frmThongTinTaiKhoan();
            tttk.ShowDialog();
        }


        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LabelTenKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.dateTimePickerChonThoiDiemBaoCaoDoanhSo.CustomFormat = "MM/yyyy";
            this.dateTimePickerChonThoiDiemBaoCaoDoanhSo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChonThoiDiemBaoCaoDoanhSo.ShowUpDown = true;
            this.dateTimePickerChonThoiDiemBaoCaoTon.CustomFormat = "MM/yyyy";
            this.dateTimePickerChonThoiDiemBaoCaoTon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChonThoiDiemBaoCaoTon.ShowUpDown = true;
            this.txtBoxNgaySuaChua.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnInPhieuSuaChua_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void BtnInKetQuaTraCuu_Click(object sender, EventArgs e)
        {
            printDialog2.ShowDialog();
        }

        private void BtnDatLaiTraCuu_Click(object sender, EventArgs e)
        {
            textBoxTraCuuChinh.Text = "";
            txtBoxBienSoTraCuu.Text = "";
            comboBoxHieuXeTraCuu.Text = "";
        }

        private void RadioButtonTimTuongDoi_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelTimChinhXac.Visible = false;
            lblTraCuuChinh.Text = "Từ khóa:";
        }

        private void RadioButtonTimChinhXac_CheckedChanged(object sender, EventArgs e)
        {
            flowLayoutPanelTimChinhXac.Visible = true;
            lblTraCuuChinh.Text = "Điện thoại:";
        }

        private void BtnLapBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            lblThangBaoCaoDoanhSo.Text = "Tháng " + dateTimePickerChonThoiDiemBaoCaoDoanhSo.Value.ToString("MM/yyyy");
        }

        private void BtnLapBaoCaoTon_Click(object sender, EventArgs e)
        {
            lblThangBaoCaoTon.Text = "Tháng " + dateTimePickerChonThoiDiemBaoCaoTon.Value.ToString("MM/yyyy");
        }

        private void BtnBaoCaoTonMoi_Click(object sender, EventArgs e)
        {
            dateTimePickerChonThoiDiemBaoCaoTon.Value = DateTime.Now;
            lblThangBaoCaoTon.Text = "Tháng";
        }

        private void BtnBaoCaoDoanhSoMoi_Click(object sender, EventArgs e)
        {
            dateTimePickerChonThoiDiemBaoCaoDoanhSo.Value = DateTime.Now;
            lblThangBaoCaoDoanhSo.Text = "Tháng";
        }
    }
}
