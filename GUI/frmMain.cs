using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Methods
        void DoiDateTimePickerFormat(DateTimePicker dtp) //Ham thuc hien chuyen format DateTimePicker sang MM/yyyy.
        {
                dtp.CustomFormat = "MM/yyyy";
                dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                dtp.ShowUpDown = true;
        }
        void TaoThoiDiemBaoCao() //Ham thuc hien format DateTimePicker cho cac bao cao thang.
        {
            DoiDateTimePickerFormat(this.dateTimePickerChonThoiDiemBaoCaoDoanhSo);
            DoiDateTimePickerFormat(this.dateTimePickerChonThoiDiemBaoCaoTon);
        }
        string LayNgayThangNamHienTai() //Ham thuc hien lay ngay/thang/nam thoi diem hien tai.
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }
        void DatThoiDiemHienTai(TextBox tb) //Ham dat noi dung textbox la thoi diem hien tai.
        {
            tb.Text = LayNgayThangNamHienTai();
        }
        void DatLaiDateTimePicker(DateTimePicker dtp) //Dat lai gia tri DatTimePicker thanh hom nay.
        {
            dtp.Value = DateTime.Now;
        }
        void DatVisibleChoControl(Control ctrl, bool result) //Dat thuoc tinh Visible cho Control.
        {
            ctrl.Visible = result;
        }
        #endregion

        #region Events
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
            TaoThoiDiemBaoCao();
            DatThoiDiemHienTai(this.txtBoxNgaySuaChua);
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
            DatVisibleChoControl(flowLayoutPanelTimChinhXac, false);
            lblTraCuuChinh.Text = "Từ khóa:";
        }

        private void RadioButtonTimChinhXac_CheckedChanged(object sender, EventArgs e)
        {
            DatVisibleChoControl(flowLayoutPanelTimChinhXac, true);
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
            DatLaiDateTimePicker(dateTimePickerChonThoiDiemBaoCaoTon);
            lblThangBaoCaoTon.Text = "Tháng";
        }

        private void BtnBaoCaoDoanhSoMoi_Click(object sender, EventArgs e)
        {
            DatLaiDateTimePicker(dateTimePickerChonThoiDiemBaoCaoDoanhSo);
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
            DatLaiDateTimePicker(dateTimePickerNgayThuTienPTT);
        }

        private void ButtonInPhieuThuTienPTT_Click(object sender, EventArgs e)
        {
            printDialogPTT.ShowDialog();
        }

        private void ComboBoxMaVTPTPhieuNhapVTPT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMaVTPTPhieuNhapVTPT.Text.ToString() == "khác")
            {
                DatVisibleChoControl(panelMaVTPT, false);
                DatVisibleChoControl(panelMaVTPTMoiPhieuNhap, true);
                DatVisibleChoControl(panelTenVTPTPhieuNhap, true);
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

        private void TCtrlChucNang_Enter(object sender, EventArgs e)
        {
            this.dataGridViewXeDaTiepNhan.DataSource = DataProvider.Instance.ExecuteQuery("select * from XE");
        }

        private void TPQuyDinh_Enter(object sender, EventArgs e)
        {
            this.dataGridViewGiaTriHienTai.DataSource = DataProvider.Instance.ExecuteQuery("select * from THAMSO");
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaiKhoanDAO.Instance.XoaThongTinNguoiDungGanNhat();
        }

        #endregion
    }
}
