using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

using System.Data;

namespace BUS
{
   public class LopBUS
    {
        public LopBUS()
        {

        }
        
        public DataTable LoadDSLop()
        {
            LopDAO lopdao = new LopDAO();
            DataTable data = new DataTable();
            data = lopdao.LoadDSLop();
            return data;
        }
    }
}
