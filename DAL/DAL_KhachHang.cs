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
    public class DAL_KhachHang : DBConnect
    {
        public bool ThemKhachHang(DTO_KhachHang kh)
        {
            bool test = false;
            try
            {
                _conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TenKH FROM KHACHHANG Where TenKH = '" + kh.sTenKH + "' and DienThoai='" + kh.sDienThoai + "'", _conn);
                DataTable dtkh = new DataTable();
                da.Fill(dtkh);
                if (dtkh == null)
                {
                    var cmd = new SqlCommand("ThemKhachHang", _conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@TenKH", SqlDbType.VarChar).Value = kh.sTenKH;
                    cmd.Parameters.Add("@DienThoai", SqlDbType.VarChar).Value = kh.sDienThoai;
                    cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = kh.sDiaChi;
                    cmd.Parameters.Add("@TienNo", SqlDbType.Int).Value = kh.iTienNo;
                    if (cmd.ExecuteNonQuery() > 0) return true;
                }
                else test = true;
            }
            catch (Exception e)
            {
 
            }
            finally
            {
                _conn.Close();
            }
            if (test) return true; else return false;
        }
        
        public DataTable LayMaKH(string tenkh, string dienthoai)
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT MaKH FROM KHACHHANG WHERE TenKH='" + tenkh + "' and DienThoai='" + dienthoai +"'", _conn);
            DataTable dtlaymakh = new DataTable();
            da.Fill(dtlaymakh);
            da.Dispose();
            return dtlaymakh;
        }
    }
}
