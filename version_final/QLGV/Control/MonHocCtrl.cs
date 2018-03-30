using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Model;
using QLGV.Object;
using System.Data;

namespace QLGV.Control
{
    public class MonHocCtrl
    {
        MonHocMod mhm = new MonHocMod();

        public DataTable Getdata()
        {
            return mhm.getdata();
        }
        public bool Adddata(MonHoc monhoc)
        {
            return mhm.Addata(monhoc);
        }
        public bool Upddata(MonHoc monhoc)
        {
            return mhm.Upddate(monhoc);
        }
        public bool Deldata(string mamh)
        {
            return mhm.Deldata(mamh);
        }
        public DataTable Timdata(string mh)
        {
            return mhm.Timdata(mh);
        }
        public string Tangma()
        {
            return mhm.Tudongtangma();
        }
    }
}
