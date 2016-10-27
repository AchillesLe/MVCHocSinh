using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class HocSinhBUS
    {
        public HocSinhBUS()
        {
            
        }
        public DataTable LoadDSHocSinh()
        {
            DataTable data = new DataTable();
            HocSinhDAO hsdao = new HocSinhDAO();
            data = hsdao.LoadDSHocSinh();

            return data;
        }
        public void AddHocSinh(HocSinhDTO hs)
        {
            HocSinhDAO hsdao = new HocSinhDAO();
            hsdao.themhs(hs);

        }
        public Boolean deleteHS(int mahs)
        {
            HocSinhDAO hsdao = new HocSinhDAO();
            return hsdao.deleteHS(mahs);
        }
           
    }
}
