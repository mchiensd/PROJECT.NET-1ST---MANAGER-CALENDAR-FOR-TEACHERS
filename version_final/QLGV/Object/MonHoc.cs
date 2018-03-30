using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Object
{
   public class MonHoc
    {
        string MaMon, TenMon, SoTiet;

        public string MaMon1
        {
            get
            {
                return MaMon;
            }

            set
            {
                MaMon = value;
            }
        }

        public string SoTiet1
        {
            get
            {
                return SoTiet;
            }

            set
            {
                SoTiet = value;
            }
        }
        public string TenMon1
        {
            get
            {
                return TenMon;
            }

            set
            {
                TenMon = value;
            }
        }
        public MonHoc() { }
        public MonHoc(string ma, string ten, string tiet)
        {
        }
    }
}
