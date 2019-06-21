using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGarage.DAO;

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
            this.dataGridViewXeDaTiepNhan.DataSource = DataProvider.Instance.ExecuteQuery("select * from XE");
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnInPhieuSuaChua_Click(object sender, EventArgs e)
        {
            printDialogPSC.ShowDialog();
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

        private void HướngDẫnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:/Git/QuanLyGarage/README.md") ;
        }

        private void LiênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/AProperName/QuanLyGarage");
        }

        private void ButtonPhieuThuTienMoiPTT_Click(object sender, EventArgs e)
        {
            textBoxBienSoPTT.Text = "";
            textBoxDienThoaiPTT.Text = "";
            textBoxEmailPTT.Text = "";
            textBoxHoTenChuXePTT.Text = "";
            textBoxSoTienThuPTT.Text = "";
            dateTimePickerNgayThuTienPTT.Value = DateTime.Now;
        }

        private void ButtonInPhieuThuTienPTT_Click(object sender, EventArgs e)
        {
            printDialogPTT.ShowDialog();
        }

        private void ComboBoxMaVTPTPhieuNhapVTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaVTPTPhieuNhapVTPT.Text.ToString() == "khác")
            {
                panelMaVTPT.Visible = false;
                panelMaVTPTMoiPhieuNhap.Visible = true;
                panelTenVTPTPhieuNhap.Visible = true;
            }
        }
        private void textBoxSoLuongPhieuNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonInPhieuNhapVTPT_Click(object sender, EventArgs e)
        {
            printDialogPhieuNhapVTPT.ShowDialog();
        }

        private void ButtonPhieuNhapVTPTMoi_Click(object sender, EventArgs e)
        {
            textBoxMaVTPTMoiPhieuNhap.Text = "";
            textBoxTenVTPTPhieuNhap.Text = "";
            comboBoxMaVTPTPhieuNhapVTPT.Text = "";
            textBoxSoLuongPhieuNhap.Text = "";
        }
        private void DataGridViewXeDaTiepNhan_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded!");

        }
    }
}
