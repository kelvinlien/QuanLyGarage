using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class PhieuSuaChuaDAO
    {
        private static PhieuSuaChuaDAO instance;
        private PhieuSuaChuaDAO() { }
        public static PhieuSuaChuaDAO Instance {
            get { if (instance == null) instance = new PhieuSuaChuaDAO(); return instance; }
            private set { PhieuSuaChuaDAO.instance = value; }
        }

        public DataTable TaoDataTable(int a, string[] name)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            for (int i = 0; i < a; i ++)
            {
                dt.Columns.Add(name[i]);
            }
            return dt;
        }

        public DataTable ThemHangVTPT(DataTable dt, int a, string VTPT, int Soluong, int DonGia)
        {
            DataRow dr = dt.NewRow();
            dr["STT"] = a;
            dr["Vật tư phụ tùng"] = VTPT;
            dr["Số lượng"] = Soluong;
            dr["Đơn giá"] = DonGia;
            dr["Thành tiền"] = Soluong * DonGia;
            dt.Rows.Add(dr);
            return dt;
        }

        public DataTable ThemHangTienCong(DataTable dt, int a, string NoiDung, int ChiPhi)
        {
            DataRow dr = dt.NewRow();
            dr["STT"] = a;
            dr["Nội dung"] = NoiDung;
            dr["Chi phí"] = ChiPhi;
            dt.Rows.Add(dr);
            return dt;
        }

        public int LayDonGiaVTPT(string maVTPT)
        {
            string query = "Select from KHO where MaPhuTung = " + maVTPT;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int DonGia = int.Parse(result.Rows[0][3].ToString());
            return DonGia;
        }

        public int LayChiPhiTienCong(string maTienCong)
        {
            string query = "Select from TIENCONG where MaTC = " + maTienCong;
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            int ChiPhi = int.Parse(result.Rows[0][2].ToString());
            return ChiPhi;
        }

        
    }
}
