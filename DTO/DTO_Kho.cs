using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Kho
    {
        public int iMaPhuTung;
        public string sTenVatTuPhuTung;
        public int iSoLuong;
        public int iDonGia;

        public int MaPhuTung
        {
            get { return iMaPhuTung; }
            set { iMaPhuTung = value; }
        }
        public string TenVatTuPhuTung
        {
            get { return sTenVatTuPhuTung; }
            set { sTenVatTuPhuTung = value; }
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
        public DTO_Kho(int maphutung, string tenvattuphutung, int soluong, int dongia)
        {
            this.iMaPhuTung = maphutung;
            this.sTenVatTuPhuTung = tenvattuphutung;
            this.iSoLuong = soluong;
            this.iDonGia = dongia;
        }
    }
}
