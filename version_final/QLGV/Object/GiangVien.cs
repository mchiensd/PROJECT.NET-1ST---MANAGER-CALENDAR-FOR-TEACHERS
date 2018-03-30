using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Object
{
    public class GiangVien
    {
        string MaGiaoVien, TenGiaoVien, GioiTinh, NgaySinh, DiaChi, Email, DienThoai;
        #region Khai Bao
        public string DiaChi1
        {
            get
            {
                return DiaChi;
            }

            set
            {
                DiaChi = value;
            }
        }

        public string DienThoai1
        {
            get
            {
                return DienThoai;
            }

            set
            {
                DienThoai = value;
            }
        }

        public string Email1
        {
            get
            {
                return Email;
            }

            set
            {
                Email = value;
            }
        }

        public string GioiTinh1
        {
            get
            {
                return GioiTinh;
            }

            set
            {
                GioiTinh = value;
            }
        }

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

        public string NgaySinh1
        {
            get
            {
                return NgaySinh;
            }

            set
            {
                NgaySinh = value;
            }
        }

        public string TenGiaoVien1
        {
            get
            {
                return TenGiaoVien;
            }

            set
            {
                TenGiaoVien = value;
            }
        }
        #endregion
        public GiangVien() { }
        public GiangVien(string ma, string ten, string gt, string ns, string dc, string em, string dt)
        {
            this.MaGiaoVien = ma;
            this.TenGiaoVien = ten;
            this.GioiTinh = gt;
            this.NgaySinh = ns;
            this.DiaChi = dc;
            this.Email = em;
            this.DienThoai = dt;


        }
    }
}
