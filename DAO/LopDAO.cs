using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class LopDAO 
    {
        public LopDAO()
        {

        }
        public DataTable LoadDSLop()
        {
            DataTable dtbLop = new DataTable();
            //IList<LopDTO> listLop = new IList<LopDTO>();
            //ArrayL
            SqlConnection conn = Connection.ConnectData();
            SqlCommand cm = new SqlCommand("LoadDSLop", conn);
            cm.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dtbLop);
            conn.Close();
            return dtbLop;
        }
    }
}
