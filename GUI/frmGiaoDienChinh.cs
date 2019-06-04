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
    public partial class frmGiaoDienChinh : Form
    {
        DTO_Xe dtoXe = new DTO_Xe();
        BUS_DuyetXe busDuyetXe = new BUS_DuyetXe();
        public frmGiaoDienChinh()
        {
            InitializeComponent();
        }

        private void buttonDuyetXe_Click(object sender, EventArgs e)
        {
            dataXe.DataSource = busDuyetXe.getXe();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGiaoDienChinh_Load(object sender, EventArgs e)
        {
            dataXe.DataSource = busDuyetXe.getXe();
        }

        private void buttonThemXe_Click(object sender, EventArgs e)
        {
            frmThemXe f = new frmThemXe();
            f.ShowDialog();
        }
    }
}
