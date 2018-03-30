using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLGV.Object;


namespace QLGV.Model
{
    public class LopHocMod
    {
        ConnecttoSQL Con = new ConnecttoSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable Getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from ThongTinLop";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;
            try
            {
                Con.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                string tex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return dt;
        }
        public DataTable Timdata(string tim)
        {


            DataTable dt = new DataTable();
            cmd.CommandText = "Select * from ThongTinLop where TenLop like N'%" + tim + "%' or MaLop like N'%" + tim + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;
            try
            {
                Con.OpenCon();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                ad.Fill(dt);

            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return dt;
        }
        public bool Addata(LopHoc lh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into ThongTinLop values('" + lh.MaLop1 + "',N'" + lh.TenLop1 + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;

            try
            {
                Con.OpenCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return false;
        }
        public bool Update(LopHoc lh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "update ThongTinLop set MaLop='" + lh.MaLop1 + "',TenLop=N'" + lh.TenLop1 + "' where MaLop='" + lh.MaLop1 + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;

            try
            {
                Con.OpenCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return false;
        }
        public bool Deldata(string malop)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete ThongTinLop where MaLop='" + malop + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;

            try
            {
                Con.OpenCon();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            return false;
        }
        public string Tudongtangma()
        {
            cmd.CommandText = "select * from ThongTinLop";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = Con.Connection;
            DataTable dt = new DataTable();
            try
            {
                Con.OpenCon();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);


            }
            catch (Exception ex)
            {
                string test = ex.Message;
                cmd.Dispose();
                Con.CloseCon();
            }
            string g = "";
            if (dt.Rows.Count <= 0)
            {
                g = "ML001";

            }
            else
            {
                int k;
                g = "ML";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;
                if (k < 10)
                {
                    g = g + "00";
                }
                else
                {
                    g = g + "0";
                }
                g = g + k.ToString();
            }
            return g;
        }
    }
}
