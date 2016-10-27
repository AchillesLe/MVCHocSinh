using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class LopDTO
    {
        private int maLop;
        private string tenlop;
        private int siso;
        public int Malop
        {
            get {return maLop; }
            set { maLop = value; }
        }
        public int Siso
        {
            get { return siso; }
            set { siso = value; }
        }
        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }
        public LopDTO (int _malop,string _tenlop,int _siso)
        {
            this.maLop = _malop;
            this.siso = _siso;
            this.tenlop = _tenlop;
        }
    }
}
