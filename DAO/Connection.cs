using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    class Connection
    {
        public static SqlConnection ConnectData()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-3OG7IFJ\ACHILLES;Initial Catalog=QLHS;User ID=sa;Password=haithanhf");
            conn.Open();
            return conn;
        }
        
    }
}
