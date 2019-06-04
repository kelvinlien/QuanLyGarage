using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using System.Configuration;

namespace DAL
{
    public class DAL_DuyetXe : DBConnect
    {
        public DataTable getXe()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT TenKH, BienSo, TenHieuXe, NgaySuaChua, TienNo FROM XE, KHACHHANG AS KH,HIEUXE AS HX Where XE.MaKH = KH.MaKH and KH.TienNo > 0 and XE.MaHX=HX.MaHX order by KH.MaKH desc", _conn);
            DataTable dtXe = new DataTable();
            da.Fill(dtXe);
            return dtXe;
        }
    }
}
