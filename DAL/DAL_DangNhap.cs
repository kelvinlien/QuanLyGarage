using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAL
{
   public class DAL_DangNhap : DBConnect
   {
        public DataTable sosanhUsernamePassword(DTO_DangNhap dn)
        {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM TAIKHOAN WHERE TenDangNhap='" + dn.sTenDangNhap + "' COLLATE SQL_Latin1_General_CP1_CS_AS AND MatKhau='" + dn.sMatKhau + "'COLLATE SQL_Latin1_General_CP1_CS_AS ", _conn);
                DataTable dtcheckUsernamePassword = new DataTable();
                da.Fill(dtcheckUsernamePassword);
                da.Dispose();
                return dtcheckUsernamePassword;
        }
   }
    
}
