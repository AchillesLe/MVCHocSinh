using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HocSinhDTO
    {
        private int mahs;
        private string tenhs;
        private string diachi;
        private string dienthoai;
        private DateTime ngaysinh;
        private int malop;
        public HocSinhDTO(int _mahs, string _tenhs, string _diachi, string _dienthoai, DateTime _ngaysinh, int _malop)
        {
            this.mahs = _mahs;//hfjkhsdakjfhadfha
            this.dienthoai = _dienthoai;
           
            this.tenhs = _tenhs;
            this.ngaysinh = _ngaysinh;
            this.diachi = _diachi;
            this.malop = _malop;
        }
        public HocSinhDTO()
        {

        }
        public int Mahs
        {
            get { return mahs; }
            set { mahs = value; }
        }
        public string Tenhs
        {
            get { return tenhs; }
            set { tenhs = value; }
        }
        public string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public string Dienthoai
        {
            get { return dienthoai; }
            set { dienthoai = value; }
        }
        public int Malop
        {
            get { return mahs; }
            set { malop = value; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

    }
}
