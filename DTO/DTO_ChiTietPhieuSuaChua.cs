using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_ChiTietPhieuSuaChua
    {
        public int iMaPhieuSuaChua;
        public string sNoiDung;
        public int iMaPhuTung;
        public int iSoLuong;
        public int iDonGia;
        public int iTienCong;

        public int MaPhieuSuaChua
        {
            get { return iMaPhieuSuaChua; }
            set { iMaPhieuSuaChua = value; }
        }
        public string NoiDung
        {
            get { return sNoiDung; }
            set { sNoiDung = value; }
        }
        public int MaPhuTung
        {
            get { return iMaPhuTung; }
            set { iMaPhuTung = value; }
        }
        public int SoLuong
        {
            get { return iSoLuong; }
            set { iSoLuong = value; }
        }
        public int DonGia
        {
            get { return iDonGia; }
            set { iDonGia = value; }
        }
        public int TienCong
        {
            get { return iTienCong; }
            set { iTienCong = value; }
        }
        public DTO_ChiTietPhieuSuaChua(int maphieusuachua, string noidung, int maphutung, int soluong, int dongia, int tiencong)
        {
            this.iMaPhieuSuaChua = maphieusuachua;
            this.sNoiDung = noidung;
            this.iMaPhuTung = maphutung;
            this.iSoLuong = soluong;
            this.iDonGia = dongia;
            this.iTienCong = tiencong;
        }
    }
}
