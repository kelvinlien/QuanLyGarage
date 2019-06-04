using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        public string sTenDangNhap;
        public string sMatKhau;
        public string sQuyenHan;

        public string TenDangNhap
        {
            get
            {
                return sTenDangNhap;
            }
            set
            {
                sTenDangNhap = value;
            }
        }
        public string MatKhau
        {
            get
            {
                return sMatKhau;
            }
            set
            {
                sMatKhau = value;
            }
        }
        public string QuyenHan
        {
            get
            {
                return sQuyenHan;
            }
            set
            {
                sQuyenHan = value;
            }
        }
        public DTO_DangNhap(string tendangnhap, string matkhau)
        {
            this.sTenDangNhap = tendangnhap;
            this.sMatKhau = matkhau;
        }
        public DTO_DangNhap(){
        }
    }

}
