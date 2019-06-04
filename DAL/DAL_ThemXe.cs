using DTO;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_ThemXe : DBConnect
    {
        public bool ThemXe(DTO_Xe xe)
        {
            try
            {
                _conn.Open();
                var cmd = new SqlCommand("ThemXe", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@BienSo", SqlDbType.VarChar).Value = xe.sBienSo;
                cmd.Parameters.Add("@HieuXe", SqlDbType.VarChar).Value = xe.sHieuXe;
                cmd.Parameters.Add("@MaKH", SqlDbType.Int).Value = xe.iMaKH;
                cmd.Parameters.Add("@NgaySuaChua", SqlDbType.DateTime).Value = xe.dtNgaySuaChua;
                if (cmd.ExecuteNonQuery() > 0) return true;    
            }
            catch (Exception e)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
