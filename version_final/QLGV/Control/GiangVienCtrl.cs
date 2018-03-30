using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Model;
using QLGV.Object;
using System.Data;
using System.Windows.Forms;


namespace QLGV.Control
{
    public class GiangVienCtrl
    {
        GiangVienMod gvm = new GiangVienMod();
        public DataTable Getdata()
        {

            return gvm.GetData();
        }
        public bool Addata(GiangVien gv)
        {
            return gvm.Addata(gv);
        }
        public bool Upddata(GiangVien gv)
        {
            return gvm.Upddate(gv);
        }
        public bool Deldata(string magv)
        {
            return gvm.Deldata(magv);
        }
        public DataTable Timdata(string gv)
        {
            return gvm.Timdata(gv);
        }
        public string Tangma()
        {
            return gvm.Tudongtangma();
        }
    }

}
