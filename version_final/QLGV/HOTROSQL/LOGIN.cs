using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.HOTROSQL
{
    public class LOGIN
    {
        private string tendangnhap;

        public string Tendangnhap
        {
            get { return tendangnhap; }
            set { tendangnhap = value; }
        }

        private string matkhau;

        public string Matkhau
        {
            get { return matkhau; }
            set { matkhau = value; }
        }

        private string magiaovien;

        public string Magiaovien
        {
            get { return magiaovien; }
            set { magiaovien = value; }
        }

        public string Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        private string quyen;
        public LOGIN() { }
        public LOGIN(DataRow ROW)
        {
            this.Tendangnhap = ROW["tendangnhap"].ToString();
            this.Matkhau = ROW["matkhau"].ToString();
            this.Magiaovien = ROW["magiaovien"].ToString();
            this.Quyen = ROW["quyen"].ToString();
        }
    }
}
