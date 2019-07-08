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

        #region Parameters
        #endregion

        #region Methods
        void DoiDateTimePickerFormat(DateTimePicker dtp) //Ham thuc hien chuyen format DateTimePicker sang MM/yyyy.
        {
                dtp.CustomFormat = "MM/yyyy";
                dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
                dtp.ShowUpDown = true;
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

        void KhoiTaoDataGridviewVTPT()
        {
            DataTable dt = PhieuSuaChuaDAO.Instance.TaoDataTable(6, new string[] { "STT", "Vật tư phụ tùng", "Số lượng", "Đơn giá", "Thành tiền", "Mã phụ tùng" });
            dataGridViewVTPTPhieuSuaChua.DataSource = dt;
            int dc = dataGridViewVTPTPhieuSuaChua.ColumnCount;
            for (int i = 0; i < dc; i++)
            {
                dataGridViewVTPTPhieuSuaChua.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            //dataGridViewVTPTPhieuSuaChua.Columns["Mã phụ tùng"].Visible = false;
        }

        void KhoiTaoDataGridviewTienCong()
        {
            dataGridViewTienCongPhieuSuaChua.DataSource = PhieuSuaChuaDAO.Instance.TaoDataTable(4, new string[] { "STT", "Nội dung", "Chi phí" ,"Mã tiền công"});
            int dc = dataGridViewTienCongPhieuSuaChua.ColumnCount;
            for (int i = 0; i < dc; i++)
            {
                dataGridViewTienCongPhieuSuaChua.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
            //dataGridViewVTPTPhieuSuaChua.Columns["Mã tiền công"].Visible = false;
        }

        void NhapVTPTChoPhieuSuaChua(int DonGia)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridViewVTPTPhieuSuaChua.DataSource;
            PhieuSuaChuaDAO.Instance.ThemHangVTPT(dt, dt.Rows.Count, comboBoxVTPTPhieuSuaChua.Text, int.Parse(textBoxSoLuongVTPTPhieuSuaChua.Text), DonGia, comboBoxVTPTPhieuSuaChua.SelectedValue.ToString());
        }

        void NhapTienCongChoPhieuSuaChua(int ChiPhi)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)dataGridViewTienCongPhieuSuaChua.DataSource;
            PhieuSuaChuaDAO.Instance.ThemHangTienCong(dt, dt.Rows.Count, PhieuSuaChuaDAO.Instance.LayNoiDungTienCong(comboBoxTienCongPhieuSuaChua.SelectedValue.ToString()), ChiPhi, comboBoxTienCongPhieuSuaChua.SelectedValue.ToString());
        }

        int TinhTongThanhTien()
        {
            int TongThanhTien = 0;
            foreach (DataGridViewRow row in dataGridViewVTPTPhieuSuaChua.Rows)
            {
                TongThanhTien += int.Parse(row.Cells["Thành tiền"].Value.ToString());
            }
            return TongThanhTien;
        }

        int TinhTongChiPhi()
        {
            int TongChiPhi = 0;
            foreach (DataGridViewRow row in dataGridViewTienCongPhieuSuaChua.Rows)
            {
                TongChiPhi += int.Parse(row.Cells["Chi phí"].Value.ToString());
            }
            return TongChiPhi;
        }

        void KiemTraDuLieuBaoCaoKhiLoad(DateTime a)
        {
            if (!BaoCaoTonDAO.Instance.KiemTraDuLieuBaoCao(a))
            {
                DataTable dt = new DataTable();
                BaoCaoTonDAO.Instance.NhapBaoCaoTon(BaoCaoTonDAO.Instance.TaoBaoCaoTon(dt,a), a);
            }
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
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.TIENCONG' table. You can move, or remove it, as needed.
            this.tIENCONGTableAdapter.Fill(this.quanLyGarageDataSet.TIENCONG);
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.KHO' table. You can move, or remove it, as needed.
            this.kHOTableAdapter.Fill(this.quanLyGarageDataSet.KHO);
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.XE' table. You can move, or remove it, as needed.
            this.xETableAdapter.Fill(this.quanLyGarageDataSet.XE);
            // TODO: This line of code loads data into the 'quanLyGarageDataSet.HIEUXE' table. You can move, or remove it, as needed.
            this.hIEUXETableAdapter.Fill(this.quanLyGarageDataSet.HIEUXE);
            // Lấy dữ liệu các xe đã tiếp nhận
            string query = "SELECT BienSo, TenHieuXe, TenKH, DienThoai, DiaChi FROM XE, HIEUXE as HX, KHACHHANG as KH WHERE XE.MaKH = KH.MaKH and XE.MaHX = HX.MaHX and XE.TrangThai = 1";
            dataGridViewXeDaTiepNhan.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dataGridViewXeDaTiepNhan.Show();
            // Lấy thông tin cho progressbar số xe đã tiếp nhận 1 ngày
            DateTime now = DateTime.Now;
            textBoxNgayThuTien.Text = now.ToString("dd-MM-yyyy");
            DataTable iSoXeDaTiepNhanTrongNgay;
            query = "SELECT GiaTri FROM THAMSO WHERE MaThamSo = 'TS2'";
            iSoXeDaTiepNhanTrongNgay = DataProvider.Instance.ExecuteQuery(query);
            progressBarSoXeDaThem.Maximum = int.Parse(iSoXeDaTiepNhanTrongNgay.Rows[0][0].ToString());
            query = "SELECT COUNT(BienSo) FROM XE WHERE day(NgayTiepNhan) = " + now.Day + " and month(NgayTiepNhan) = " + now.Month + " and year(NgayTiepNhan) = " + now.Year;
            iSoXeDaTiepNhanTrongNgay = DataProvider.Instance.ExecuteQuery(query);
            progressBarSoXeDaThem.Value = int.Parse(iSoXeDaTiepNhanTrongNgay.Rows[0][0].ToString());
            // Auto điền thông tin phiếu thu tiền theo biển số đã chọn
            query = "SELECT TenKH, DienThoai, DiaChi FROM KHACHHANG as KH, XE WHERE KH.MaKH = XE.MaKH and XE.BienSo = '" + comboBienSoXe2.SelectedValue + "'";
            DataTable TTKhachHangLPTT;
            TTKhachHangLPTT = DataProvider.Instance.ExecuteQuery(query);
            textBoxHoTenChuXePTT.Text = TTKhachHangLPTT.Rows[0][0].ToString();
            textBoxDienThoaiPTT.Text = TTKhachHangLPTT.Rows[0][1].ToString();
            textBoxDiaChiPTT.Text = TTKhachHangLPTT.Rows[0][2].ToString();
            // Điển ngày thu tiền
            textBoxNgayThuTien.Text = now.ToString("dd-MM-yyyy");
            //Khởi tạo Datagridview Phiếu sửa chữa và tiền công
            KhoiTaoDataGridviewTienCong();
            KhoiTaoDataGridviewVTPT();
            //Khởi tạo 1 dt để lưu lại các mã vtpt đã nhập và kiểm tra, so sánh số lượng nhập vào.
            PhieuSuaChuaDAO.Instance.KhoiTaoDtVTPTDangNhap();
            KiemTraDuLieuBaoCaoKhiLoad(DateTime.Now);
            dataGridViewBaoCaoTon.DataSource=BaoCaoTonDAO.Instance.KhoiTaoBaoCaoTon();
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
            lblTraCuuChinh.Visible = true;
            textBoxTraCuuChinh.Visible = true;
        }

        private void RadioButtonTimChinhXac_CheckedChanged(object sender, EventArgs e)
        {
            DatVisibleChoControl(flowLayoutPanelTimChinhXac, true);
            lblTraCuuChinh.Visible = false;
            textBoxTraCuuChinh.Visible = false;
        }

        private void BtnLapBaoCaoDoanhSo_Click(object sender, EventArgs e)
        {
            DataTable BaoCaoDS;
            string query = "BaoCaoDoanhThu @Thang , @Nam";
            BaoCaoDS = DataProvider.Instance.ExecuteQuery(query, new object[] { int.Parse(textBoxThangBaoCao.Text), int.Parse(textBoxNamBaoCao.Text) });
            dataGridViewBaoCaoDoanhSo.DataSource = BaoCaoDS;
            dataGridViewBaoCaoDoanhSo.Show();
            query = "TongTienDoanhThu @Thang , @Nam";
            BaoCaoDS = DataProvider.Instance.ExecuteQuery(query, new object[] { int.Parse(textBoxThangBaoCao.Text), int.Parse(textBoxNamBaoCao.Text) });
            textBoxTongDoanhThu.Text = BaoCaoDS.Rows[0][0].ToString();
        }

        private void BtnLapBaoCaoTon_Click(object sender, EventArgs e)
        {
            if (BaoCaoTonDAO.Instance.KiemTraThoiDiem(dateTimePickerChonThoiDiemBaoCaoTon.Value))
            {
                lblThangBaoCaoTon.Text = "Tháng " + dateTimePickerChonThoiDiemBaoCaoTon.Value.ToString("MM/yyyy");
                dataGridViewBaoCaoTon.DataSource=BaoCaoTonDAO.Instance.TruyXuatBaoCaoTon(dateTimePickerChonThoiDiemBaoCaoTon.Value);
            }
        }

        private void BtnBaoCaoTonMoi_Click(object sender, EventArgs e)
        {
            DatLaiDateTimePicker(dateTimePickerChonThoiDiemBaoCaoTon);
            lblThangBaoCaoTon.Text = "Tháng";
            BaoCaoTonDAO.Instance.TaoBaoCaoMoi((DataTable)dataGridViewBaoCaoTon.DataSource);
        }

        private void BtnBaoCaoDoanhSoMoi_Click(object sender, EventArgs e)
        {
            textBoxThangBaoCao.Clear();
            textBoxNamBaoCao.Clear();
            textBoxTongDoanhThu.Clear();
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
            textBoxDienThoaiPTT.Clear();
            textBoxDiaChiPTT.Clear();
            textBoxHoTenChuXePTT.Clear();
            textBoxSoTienThuPTT.Clear();
            DateTime now = DateTime.Now;
            textBoxNgayThuTien.Text = now.ToString("dd-MM-yyyy");
        }

        private void ButtonInPhieuThuTienPTT_Click(object sender, EventArgs e)
        {
            printDialogPTT.ShowDialog();
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
            textBoxTenVTPTMoi.Clear();
            textBoxSoLuongVTPT.Clear();
            textBoxGiaVTPT.Clear();
            textBoxTenVTPTMoi.Enabled = true;
            textBoxGiaVTPT.Enabled = true;
        }


        //private void TPQuyDinh_Enter(object sender, EventArgs e)
        //{
        //    this.dataGridViewGiaTriHienTai.DataSource = DataProvider.Instance.ExecuteQuery("select * from THAMSO");
        //}

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            TaiKhoanDAO.Instance.XoaThongTinNguoiDungGanNhat();
        }

        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            if (txtBoxTenKH.Text.Length == 0)
                MessageBox.Show("Vui lòng nhập tên khách hàng!");
            else
            {
                if (txtBoxDienThoai.Text.Length == 0)
                    MessageBox.Show("Vui lòng nhập điện thoại của khách hàng!");
                else
                {
                    if (txtBoxDiaChi.Text.Length == 0)
                        MessageBox.Show("Vui lòng nhập địa chỉ khách hàng!");
                    else
                    {
                        if (txtBoxBienSo.Text.Length == 0)
                            MessageBox.Show("Vui lòng nhập biển số xe !");
                    }
                }
            }
            string query1 = "ThemKhachHang @TenKH , @DienThoai , @DiaChi , @TienNo";
            int test = 0;
            DataTable tMaKH;
            int iMaKH;
            DateTime now = DateTime.Now;
            test = DataProvider.Instance.ExecuteNonQuery(query1, new object[] { txtBoxTenKH.Text, txtBoxDienThoai.Text, txtBoxDiaChi.Text, 0 });
            string query2 = "SELECT MaKH FROM KHACHHANG WHERE TenKH = '" + txtBoxTenKH.Text + "' and DienThoai = '" + txtBoxDienThoai.Text + "'";
            tMaKH = DataProvider.Instance.ExecuteQuery(query2);
            iMaKH = int.Parse(tMaKH.Rows[0][0].ToString());
            query2 = "ThemXe @BienSo , @HieuXe , @MaKH , @NgayTiepNhan";
            test = DataProvider.Instance.ExecuteNonQuery(query2, new object[] { txtBoxBienSo.Text, comBoxHieuXe.SelectedValue, iMaKH, now });
            if (test != 0)
            {
                MessageBox.Show("Thêm xe thành công!");
                progressBarSoXeDaThem.Value = progressBarSoXeDaThem.Value + 1;
            }
            if (progressBarSoXeDaThem.Value == progressBarSoXeDaThem.Maximum)
            {
                txtBoxTenKH.Clear();
                txtBoxDienThoai.Clear();
                txtBoxDiaChi.Clear();
                txtBoxBienSo.Clear();
                txtBoxTenKH.Visible = false;
                txtBoxDienThoai.Visible = false;
                txtBoxDiaChi.Visible = false;
                txtBoxBienSo.Visible = false;
                buttonThemXe.Enabled = false;
                buttonClear.Enabled = false;
            }
            else
            {
                txtBoxTenKH.Clear();
                txtBoxDienThoai.Clear();
                txtBoxDiaChi.Clear();
                txtBoxBienSo.Clear();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtBoxTenKH.Clear();
            txtBoxDienThoai.Clear();
            txtBoxDiaChi.Clear();
            txtBoxBienSo.Clear();
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            string query = "SELECT TenHieuXe, BienSo, TenKH, DienThoai, DiaChi FROM XE, HIEUXE as HX, KHACHHANG as KH WHERE Xe.MaKH = KH.MaKH and Xe.MaHX = HX.MaHX and XE.TrangThai = 1";
            dataGridViewXeDaTiepNhan.DataSource = DataProvider.Instance.ExecuteQuery(query);
            dataGridViewXeDaTiepNhan.Show();
        }

        private void buttonLapPhieuThuTienPTT_Click(object sender, EventArgs e)
        {
            if (textBoxSoTienThuPTT.Text != "")
            {
                int iTienNo = 0;
                DataTable TienNo;
                string query1 = "SELECT TienNo from KHACHHANG as KH, XE WHERE XE.BienSo = '" + comboBienSoXe2.Text + "' and XE.MaKH = KH.MaKH";
                TienNo = DataProvider.Instance.ExecuteQuery(query1);
                iTienNo = int.Parse(TienNo.Rows[0][0].ToString());
                if (iTienNo < int.Parse(textBoxSoTienThuPTT.Text))
                    MessageBox.Show("Vui lòng nhập lại tiền thu!");
                else
                {
                    string query = " ThemPhieuThuTien @BienSo , @TienThu , @NgayThuTien";
                    int test = 0;
                    DateTime now = DateTime.Now;
                    test = DataProvider.Instance.ExecuteNonQuery(query, new object[] { comboBienSoXe2.Text, int.Parse(textBoxSoTienThuPTT.Text), now });
                    if (test != 0)
                        MessageBox.Show("Thêm Phiếu Thu Tiền thành công!");

                }
            }
            else
                MessageBox.Show("Vui lòng nhập số tiền thu !");
        }

        private void comboBienSoXe2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "SELECT TenKH, DienThoai, DiaChi FROM KHACHHANG as KH, XE WHERE KH.MaKH = XE.MaKH and XE.BienSo = " + comboBienSoXe2.SelectedValue;
            DataTable TTKhachHangLPTT;
            TTKhachHangLPTT = DataProvider.Instance.ExecuteQuery(query);
            textBoxHoTenChuXePTT.Text = TTKhachHangLPTT.Rows[0][0].ToString();
            textBoxDienThoaiPTT.Text = TTKhachHangLPTT.Rows[0][1].ToString();
            textBoxDiaChiPTT.Text = TTKhachHangLPTT.Rows[0][2].ToString();
        }

        private void buttonLapPhieuNhapVTPT_Click(object sender, EventArgs e) //chỗ này chỉnh lại database này
        {
            if (textBoxSoLuongVTPT.Text == "")
                MessageBox.Show("Vui lòng nhập số lượng vật tư trước khi thêm mới phiếu nhập !");
            else
            {
                DateTime now = DateTime.Now;
                string query = "NhapVTPT @MaPhuTung , @SoLuong , @ThoiDiem";
                int test = 0;
                test = DataProvider.Instance.ExecuteNonQuery(query, new object[] { comboBoxTenVTPT.SelectedValue, int.Parse(textBoxSoLuongVTPT.Text), now });
                if (test > 0)
                    MessageBox.Show("Nhập vật thêm tư phụ tùng thành công!");
            }
        }

        private void buttonTaoMoiVTPT_Click(object sender, EventArgs e) //chỗ này thiếu thêm thời gian, để tối về anh kiểm tra thử database có thêm chưa, nếu chưa thêm thì anh gởi lệnh SQL qua và sửa vào trong này
        {
            if (textBoxSoLuongVTPT.Text == "")
                MessageBox.Show("Vui lòng nhập số lượng vật tư trước khi thêm mới vật tư vào kho !");
            else
            {
                string query = "NhapMoiVTPT @TenPhuTung , @SoLuong , @DonGia";
                int test = 0;
                test = DataProvider.Instance.ExecuteNonQuery(query, new object[] { textBoxTenVTPTMoi.Text, int.Parse(textBoxSoLuongVTPT.Text), int.Parse(textBoxGiaVTPT.Text) });
                if (test > 0)
                    MessageBox.Show("Nhập mới vật tư phụ tùng thành công");
            }
        }

        private void btnTimKiemTraCuu_Click(object sender, EventArgs e)
        {
            if (radioButtonTimTuongDoi.Checked == true)
            {
                if (textBoxTraCuuChinh.Text == "")
                    MessageBox.Show("Nhập từ khóa tìm kiếm !");
                else
                {
                    string query = "TimKiemTuongDoi @DuLieu";
                    DataTable Find;
                    Find = DataProvider.Instance.ExecuteQuery(query, new object[] { textBoxTraCuuChinh.Text });
                    dataGridView2.DataSource = Find;
                    dataGridView2.Show();
                }
            }
            else
            {
                if (txtBoxBienSoTraCuu.Text == "")
                    MessageBox.Show("Nhập từ khóa tìm kiếm !");
                else
                {
                    string query = "TimKiemChinhXac @BienSo , @HieuXe";
                    DataTable Find;
                    Find = DataProvider.Instance.ExecuteQuery(query, new object[] { txtBoxBienSoTraCuu.Text, comboBoxHieuXeTraCuu.Text });
                    dataGridView2.DataSource = Find;
                    dataGridView2.Show();
                }
            }
        }

        private void btnCapNhatSoHieuXe_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THAMSO SET GiaTri =" + int.Parse(txtBoxSoHieuXe.Text) + " WHERE MaThamSo = 'TS1'";
            int test = 0;
            test = DataProvider.Instance.ExecuteNonQuery(query);
            if (test != 0)
            {
                MessageBox.Show("Thay đổi số hiệu xe thành công !");
                txtBoxSoHieuXe.Clear();
            }
        }

        private void btnCapNhatSoXeSuaToiDa_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THAMSO SET GiaTri =" + int.Parse(txtBoxSoXeSuaChuaToiDa.Text) + " WHERE MaThamSo = 'TS2'";
            int test = 0;
            test = DataProvider.Instance.ExecuteNonQuery(query);
            if (test != 0)
            {
                MessageBox.Show("Thay đổi số xe sữa chữa tối đa mỗi ngày thành công !");
                txtBoxSoXeSuaChuaToiDa.Clear();
            }
        }

        private void btnCapNhatSoLoaiVatTu_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THAMSO SET GiaTri =" + int.Parse(txtBoxSoLoaiVatTu.Text) + " WHERE MaThamSo = 'TS3'";
            int test = 0;
            test = DataProvider.Instance.ExecuteNonQuery(query);
            if (test != 0)
            {
                MessageBox.Show("Thay đổi số loại vật tư thành công !");
                txtBoxSoLoaiVatTu.Clear();
            }
        }

        private void btnCapNhatSoLoaiTienCong_Click(object sender, EventArgs e)
        {
            string query = "UPDATE THAMSO SET GiaTri =" + int.Parse(txtBoxSoLoaiTienCong.Text) + " WHERE MaThamSo = 'TS4'";
            int test = 0;
            test = DataProvider.Instance.ExecuteNonQuery(query);
            if (test != 0)
            {
                MessageBox.Show("Thay đổi số loại tiền công thành công !");
                txtBoxSoLoaiTienCong.Clear();
            }
        }

        private void TextBoxSoLuongVTPTPhieuSuaChua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonNhapVTPTPhieuSuaChua_Click(object sender, EventArgs e)
        {
            if (PhieuSuaChuaDAO.Instance.KiemTraSoLuong(comboBoxVTPTPhieuSuaChua.SelectedValue.ToString(), int.Parse(textBoxSoLuongVTPTPhieuSuaChua.Text)))
            {
                NhapVTPTChoPhieuSuaChua(PhieuSuaChuaDAO.Instance.LayDonGiaVTPT(comboBoxVTPTPhieuSuaChua.SelectedValue.ToString()));
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại số lượng vật tư phụ tùng!", "Kho không đủ đáp ứng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonNhapTienCongPhieuSuaChua_Click(object sender, EventArgs e)
        {
            NhapTienCongChoPhieuSuaChua(PhieuSuaChuaDAO.Instance.LayChiPhiTienCong(comboBoxTienCongPhieuSuaChua.SelectedValue.ToString()));
        }

        private void BtnHoanTat_Click(object sender, EventArgs e)
        {
            int TongTien;
            TongTien = TinhTongThanhTien() + TinhTongChiPhi();
            textBoxTongTienPhieuSuaChua.Text = TongTien.ToString();

        }

        private void comboBoxTenVTPT_Click(object sender, EventArgs e)
        {
            textBoxTenVTPTMoi.Enabled = false;
            textBoxGiaVTPT.Enabled = false;
        }

        private void BtnTaoMoiPCS_Click(object sender, EventArgs e)
        {
            comboBoxBienSoXe1.Text = "";
            comboBoxVTPTPhieuSuaChua.Text = "";
            comboBoxTienCongPhieuSuaChua.Text = "";
            textBoxSoLuongVTPTPhieuSuaChua.Text = "";
            KhoiTaoDataGridviewVTPT();
            KhoiTaoDataGridviewTienCong();
            PhieuSuaChuaDAO.Instance.XoaDtVTPTDangNhap();
        }

        private void BtnLuuPSC_Click(object sender, EventArgs e)
        {
            PhieuSuaChuaDAO.Instance.NhapVTPT();
            PhieuSuaChuaDAO.Instance.LuuPhieuSuaChua(comboBoxBienSoXe1.Text, TinhTongChiPhi(), TinhTongThanhTien(), TinhTongThanhTien() + TinhTongChiPhi(), (DataTable)dataGridViewTienCongPhieuSuaChua.DataSource);
        }

        #endregion

    }
}
