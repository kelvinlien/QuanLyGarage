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
            this.dateTimePickerChonThoiDiem.CustomFormat = "MM/yyyy";
            this.dateTimePickerChonThoiDiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerChonThoiDiem.ShowUpDown = true;
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ShowUpDown = true;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void BtnInPhieuSuaChua_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
    }
}
