using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        public SqlConnection _conn = new SqlConnection(@"Data Source=MAHLAP\MAHLAP;Initial Catalog=Karaoke;Integrated Security=True");
    }
}
