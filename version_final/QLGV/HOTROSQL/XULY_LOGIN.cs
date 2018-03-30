using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.HOTROSQL
{
    public class XULY_LOGIN
    {
        private static XULY_LOGIN xL_LOGIN;

        public static XULY_LOGIN XL_LOGIN
        {
            get
            {
                if (xL_LOGIN == null)
                {
                    xL_LOGIN = new XULY_LOGIN();
                }
                return XULY_LOGIN.xL_LOGIN;
            }
            private set { XULY_LOGIN.xL_LOGIN = value; }
        }

        public string TIEN_HANH_PHAN_QUYEN(string User, string pass)
        {
            string lenh = @"select * from dbo.ThongTinDangNhap where tendangnhap = '" + User + "' and MatKhau = '" + pass + "'";
            DataTable bang = HOTRO.SQL.TAIBANGDULIEU(lenh);

            if (bang.Rows.Count > 0)
            {
                LOGIN login = new LOGIN(bang.Rows[0]);
                return login.Quyen;
            }
            return User;

        }
    }
}
