using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance {
            get
            {
                if (instance == null)
                    instance = new TaiKhoanDAO();
                return instance;
            }
            private set
            {
                instance = value;
            }
                }
        private TaiKhoanDAO() { }
        public bool DangNhap(string TaiKhoan, string MatKhau)
        {
            string query = "USP_Dangnhap @TenDangNhap , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });

            return result.Rows.Count > 0;
        }
    }
}
