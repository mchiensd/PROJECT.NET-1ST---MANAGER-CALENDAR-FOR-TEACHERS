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
    public class LopHocCtrl
    {
        LopHocMod lopx = new LopHocMod();

        public DataTable Getdata()
        {
            return lopx.Getdata();
        }
        public bool Addata(LopHoc lo)
        {
            return lopx.Addata(lo);
        }
        public bool Update(LopHoc lo)
        {
            return lopx.Update(lo);
        }
        public bool Deldata(string malop)
        {
            return lopx.Deldata(malop);
        }
        public DataTable Timdata(string malop)
        {
            return lopx.Timdata(malop);
        }
        public string Tangma()
        {
            return lopx.Tudongtangma();
        }
    }
}
