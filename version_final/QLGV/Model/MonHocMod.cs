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
    class MonHocMod
    {
        ConnecttoSQL Con = new ConnecttoSQL();
        SqlCommand cmd = new SqlCommand();
        public DataTable getdata()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from ThongTinMonHoc";
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

            /*DataTable dt = new DataTable();
           string Text =@"Select * from ThongTinGiangVien";
            cmd = new SqlCommand(Text,Con.Connection);
            */
            DataTable dt = new DataTable();
            cmd.CommandText = "Select * from ThongTinMonHoc where MaMon like N'%" + tim + "%' or TenMon like N'%" + tim + "%'";
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
        public bool Addata(MonHoc mh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into ThongTinMonHoc values('" + mh.MaMon1 + "',N'" + mh.TenMon1 + "','" + mh.SoTiet1 + "')";
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
        public bool Upddate(MonHoc mh)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "update ThongTinMonHoc set TenMon=N'" + mh.TenMon1 + "',SoTiet='" + mh.SoTiet1 + "' where MaMon='" + mh.MaMon1 + "'";
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
        public bool Deldata(string ma)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "delete ThongTinMonHoc where MaMon='" + ma + "'";
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
            cmd.CommandText = "select MaMon from ThongTinMonHoc";
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
                g = "MH001";

            }
            else
            {
                int k;
                g = "MH";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;

                if (k < 10)
                { g = g + "00"; }
                if (k >= 10 && k < 100)
                { g = g + "0"; }

                g = g + k.ToString();
               
            }
            return g;
        }
    }
}
