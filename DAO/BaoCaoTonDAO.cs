using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BaoCaoTonDAO
    {
        private static BaoCaoTonDAO instance;

        public static BaoCaoTonDAO Instance { get {
                if (instance == null)
                    instance = new BaoCaoTonDAO();
                return instance;
            } private set => instance = value; }

    }
}
