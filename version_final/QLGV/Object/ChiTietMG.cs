using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Object
{
    public class ChiTietMG
    {
        string MaMoiGiang, MaGiaoVien, MaLop, MaMon, NgayBatDau, NgayKetThuc;

        public string MaGiaoVien1
        {
            get
            {
                return MaGiaoVien;
            }

            set
            {
                MaGiaoVien = value;
            }
        }

        public string MaLop1
        {
            get
            {
                return MaLop;
            }

            set
            {
                MaLop = value;
            }
        }

        public string MaMoiGiang1
        {
            get
            {
                return MaMoiGiang;
            }

            set
            {
                MaMoiGiang = value;
            }
        }

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

        public string NgayBatDau1
        {
            get
            {
                return NgayBatDau;
            }

            set
            {
                NgayBatDau = value;
            }
        }

        public string NgayKetThuc1
        {
            get
            {
                return NgayKetThuc;
            }

            set
            {
                NgayKetThuc = value;
            }
        }
        public ChiTietMG() { }
        public ChiTietMG(string mamoi, string magv, string mal, string mam, string ngaybd, string ngaykt)
        {
            this.MaMoiGiang = mamoi;
            this.MaGiaoVien = magv;
            this.MaLop = mal;
            this.MaMon = mam;
            this.NgayBatDau = ngaybd;
            this.NgayKetThuc = ngaykt;
        }
    }

}
