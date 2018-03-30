using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QLGV.Object;
using System.Windows.Forms;

namespace QLGV.Model
{
    class GiangVienMod
    {

        ConnecttoSQL Con = new ConnecttoSQL();
        SqlCommand cmd = new SqlCommand();


        public DataTable GetData()
        {

            /*DataTable dt = new DataTable();
           string Text =@"Select * from ThongTinGiangVien";
            cmd = new SqlCommand(Text,Con.Connection);
            */
            DataTable dt = new DataTable();
            cmd.CommandText = "Select * from ThongTinGiangVien";
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
        public DataTable Timdata(string tim)
        {

            /*DataTable dt = new DataTable();
           string Text =@"Select * from ThongTinGiangVien";
            cmd = new SqlCommand(Text,Con.Connection);
            */
            DataTable dt = new DataTable();
            cmd.CommandText = "Select * from ThongTinGiangVien where TenGiaoVien like N'%" + tim + "%' or MaGiaoVien like'%" + tim + "%' or Email like '%" + tim + "%' or DienThoai like'%" + tim + "%' or GioiTinh like N'%" + tim + "%'or DiaChi like N'%" + tim + "%'";
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
        public bool Addata(GiangVien gv)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "insert into ThongTinGiangVien values(N'" + gv.TenGiaoVien1 + "','" + gv.MaGiaoVien1 + "',N'" + gv.GioiTinh1 + "',CONVERT(date,'" + gv.NgaySinh1 + "',103),N'" + gv.DiaChi1 + "','" + gv.Email1 + "','" + gv.DienThoai1 + "')";
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
        public bool Upddate(GiangVien gv)
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "update ThongTinGiangVien set TenGiaoVien=N'" + gv.TenGiaoVien1 + "',GioiTinh=N'" + gv.GioiTinh1 + "',NgaySinh=CONVERT(date,'" + gv.NgaySinh1 + "',103),DiaChi=N'" + gv.DiaChi1 + "',Email='" + gv.Email1 + "',DienThoai='" + gv.DienThoai1 + "' where MaGiaoVien='" + gv.MaGiaoVien1 + "'";
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
            cmd.CommandText = "delete ThongTinGiangVien where MaGiaoVien like'" + ma + "'";
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
            cmd.CommandText = "select MaGiaoVien from ThongTinGiangVien";
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
                g = "GV0001";

            }
            else
            {
                int k;
                g = "GV";
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2));
                k = k + 1;
               
                if (k < 10)
                { g = g + "000"; }
                if(k>=10 && k<100)
                { g = g + "00"; }
                if (k >= 100 && k < 1000)
                { g = g + "0"; }
                g = g + k.ToString();
            }
            return g;
        }

    }
}
