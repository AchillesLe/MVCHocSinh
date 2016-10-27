using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HocSinhDAO
    {
        public HocSinhDAO()
        {

        }
        public DataTable LoadDSHocSinh()
        {
            DataTable dtbHs = new DataTable();
            SqlConnection cn = Connection.ConnectData();
            SqlCommand cm = new SqlCommand("sp_DSHocSinh", cn);
            cm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dtbHs);

            return dtbHs;
        }
        public void themhs(HocSinhDTO hs)
        {
            SqlConnection cn = Connection.ConnectData();
            SqlCommand cm = new SqlCommand("sp_InSertHocSinh", cn);
            cm.CommandType = CommandType.StoredProcedure;

            cm.Parameters.Add("@MaHS", SqlDbType.Int).Direction = ParameterDirection.Output;
            cm.Parameters.Add("@TenHS", SqlDbType.NVarChar);
            cm.Parameters.Add("@DiaChi", SqlDbType.NVarChar);
            cm.Parameters.Add("@DienThoai", SqlDbType.NVarChar);
            cm.Parameters.Add("@Ngaysinh", SqlDbType.Date);
            cm.Parameters.Add("@MaLop", SqlDbType.Int);

            cm.Parameters["@TenHS"].Value = hs.Tenhs;
            cm.Parameters["@DiaChi"].Value = hs.Diachi;
            cm.Parameters["@DienThoai"].Value = hs.Dienthoai;
            cm.Parameters["@NgaySinh"].Value = hs.Ngaysinh;
            cm.Parameters["@MaLop"].Value = hs.Malop;

            cm.ExecuteNonQuery();
            int maHs = Convert.ToInt32(cm.Parameters["@MaHS"].Value);
            hs.Mahs = maHs;
            cn.Close();
        }
        public Boolean deleteHS(int mahs)
        {
            Boolean check = false;
            SqlConnection cn = Connection.ConnectData();
            SqlCommand cm = new SqlCommand("sp_deleteHS", cn);
            cm.CommandType = CommandType.StoredProcedure;
            cm.Parameters.Add("@id", SqlDbType.Int);
            cm.Parameters["@id"].Value = mahs;
            int result = cm.ExecuteNonQuery();
            if (result > 0)
            {
                check = true;
            }

            return check;
        }
        
    }
}
