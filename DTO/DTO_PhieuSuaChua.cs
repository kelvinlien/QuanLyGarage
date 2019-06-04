using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuSuaChua
    {
        public int iMaPhieuSuaChua;
        public string sBienSo;
        public int iMaKH;
        public DateTime dtNgaySuaChua;
        public int iTienCong;
        public int iTienPhuTung;
        public int iTongTien;

        public int MaPhieuSuaChua
        {
            get { return iMaPhieuSuaChua; }
            set { iMaPhieuSuaChua = value; }
        }
        public string BienSo
        {
            get { return sBienSo; }
            set { sBienSo = value; }
        }
        public int MaKH
        {
            get { return iMaKH; }
            set { iMaKH = value; }
        }
        public DateTime NgaySuaChua
        {
            get { return dtNgaySuaChua; }
            set { dtNgaySuaChua = value; }
        }
        public int TienCong
        {
            get { return iTienCong; }
            set { iTienCong = value; }
        }
        public int TienPhuTung
        {
            get { return iTienPhuTung; }
            set { iTienPhuTung = value; }
        }
        public int TongTien
        {
            get { return iTongTien; }
            set { iTongTien = value; }
        }
        DTO_PhieuSuaChua(int maphieusuachua, string bienso, int makh, DateTime ngaysuachua, int tiencong, int tienphutung, int tienno)
        {
            this.iMaPhieuSuaChua = maphieusuachua;
            this.sBienSo = bienso;
            this.iMaKH = makh;
            this.dtNgaySuaChua = ngaysuachua;
            this.iTienCong = tiencong;
            this.iTienPhuTung = tienphutung;
            this.iTongTien = TongTien;
        }
    }
}
