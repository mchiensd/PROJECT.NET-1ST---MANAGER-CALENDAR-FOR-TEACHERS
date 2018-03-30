using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Model;
using System.Data;
using QLGV.Object;

namespace QLGV.Control
{
    class ChitietCtrl
    {
        ChiTietGVMod ctm = new ChiTietGVMod();
        public DataTable Getdata()
        {

            return ctm.Getdata();
        }
        public bool Addata(ChiTietMG mg)
        {
            return ctm.Addata(mg);
        }
        public bool Upddata(ChiTietMG mg)
        {
            return ctm.Update(mg);
        }
        public bool Deldata(string mactgv)
        {
            return ctm.Deldata(mactgv);
        }
        public DataTable Timdata(string ctgv)
        {
            return ctm.Timdata(ctgv);
        }
        public string Tangma()
        {
            return ctm.Tudongtangma();
        }
    }
}
