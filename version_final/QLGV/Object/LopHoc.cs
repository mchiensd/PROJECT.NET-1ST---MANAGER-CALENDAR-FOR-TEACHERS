using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Object
{
    public class LopHoc
    {
        string MaLop, TenLop;

        public string TenLop1
        {
            get { return TenLop; }
            set { TenLop = value; }
        }

        public string MaLop1
        {
            get { return MaLop; }
            set { MaLop = value; }
        }

        public LopHoc() { }
        public LopHoc(string malop, string tenlop)
        {
            //this.MaLop = malop;
            //this.TenLop = tenlop;
        }

    }
}
